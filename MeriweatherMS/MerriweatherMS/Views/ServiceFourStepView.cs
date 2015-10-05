using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DGVPrinterHelper;
using System.Linq;

namespace System.Windows.Forms.MMS.Views
{

    public partial class ServiceFourStepView : BaseView
    {

        class FourStepItems
        {
            public string FirstName;
            public string LastName;
            public string Address;
            public bool Step1;
            public bool Step2;
            public bool Step3;
            public bool Step4;
        } 

        private bool bDirty = false; //has been clicked
        private int nJobCount = 0;
        private int nJobStep1Count = 0;
        private int nJobStep2Count = 0;
        private int nJobStep3Count = 0;
        private int nJobStep4Count = 0;
        private int nUpperBound = 0;
        private int nLowerBound = 0;
        private int nLeftBound = 5;
        private int nRightBound = 8;
        private bool bSelected = false;
        private List<FourStepItems> FourStepJobList = new List<FourStepItems>();

        public ServiceFourStepView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "4-Step Service";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
            JobFilterComboBox.SelectedIndex = 0;
            EnableControl(false);
            cancelButton.Visible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                this.propServiceTableAdapter.FillByFourStep(this.mMSDataSet.PropService);
                //this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);
                this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            }
            UpdateJobLabel(true);
            nUpperBound = this.serviceDataGridView.RowCount;
            FourStepFilterCheckbox.Checked = true;
            FourStepFilterCheckbox_CheckedChanged(null,null);
            ProtectStepCellDone();
        }

        public override void RefreshView()
        {
            int nIndex = 0;
            ClearJobs();
            this.propServiceBindingSource.CancelEdit();

            if (this.serviceDataGridView.CurrentRow != null)
                nIndex = this.serviceDataGridView.CurrentRow.Index;

            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            if (serviceDataGridView.RowCount > 0)
            {
                this.serviceDataGridView.CurrentCell = this.serviceDataGridView.Rows[nIndex].Cells[0];
            }
            //this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);
            InitialClear();
            ProtectStepCellDone();
            MMSUtility.PlayAcceptSound();

        }

        public void ProtectStepCellDone()
        {
            //if it is already done, make the cell readonly
            for (int row = 0; row < serviceDataGridView.RowCount; row++)
            {
                for (int i = 5; i <= 8; i++)
                {
                    string lname = this.serviceDataGridView.Rows[row].Cells[0].Value.ToString();
                    string address = this.serviceDataGridView.Rows[row].Cells[2].Value.ToString();
                    FourStepItems jobitem = FindFourStepJobItem(lname, address);

                    if (this.serviceDataGridView.Rows[row].Cells[i].Value.ToString() == "True")
                    {
                        if (jobitem == null)
                        {
                            this.serviceDataGridView.Rows[row].Cells[i].ReadOnly = true;
                            this.serviceDataGridView.Rows[row].Cells[i].Style.ForeColor = Color.Green;
                            this.serviceDataGridView.Rows[row].Cells[i].Style.BackColor = Color.Yellow;
                        }
                        else  
                        {
                            switch (i)
                            {
                                case 5:
                                    if (!jobitem.Step1)
                                    {
                                        this.serviceDataGridView.Rows[row].Cells[i].ReadOnly = true;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.ForeColor = Color.Green;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.BackColor = Color.Yellow;
                                    }
                                    break;
                                case 6:
                                    if (!jobitem.Step2)
                                    {
                                        this.serviceDataGridView.Rows[row].Cells[i].ReadOnly = true;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.ForeColor = Color.Green;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.BackColor = Color.Yellow;
                                    }
                                    break;
                                case 7:
                                    if (!jobitem.Step3)
                                    {
                                        this.serviceDataGridView.Rows[row].Cells[i].ReadOnly = true;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.ForeColor = Color.Green;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.BackColor = Color.Yellow;
                                    }
                                    break;
                                case 8:
                                    if (!jobitem.Step4)
                                    {
                                        this.serviceDataGridView.Rows[row].Cells[i].ReadOnly = true;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.ForeColor = Color.Green;
                                        this.serviceDataGridView.Rows[row].Cells[i].Style.BackColor = Color.Yellow;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
      

        private void serviceDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            bDirty = true;
            if (serviceDataGridView.CurrentCell is DataGridViewCheckBoxCell)
            {
                serviceDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                this.propServiceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
            }
        }
        
        private FourStepItems GetFourStepJobItem(string firstName, string lastName, string address)
        {
            //find
            foreach (FourStepItems jobitem in FourStepJobList)
            {
                if ((jobitem.LastName == lastName) && (jobitem.Address == address))
                {
                    return jobitem;
                }
            }


            var newitem = new FourStepItems
            {
                FirstName = firstName,
                LastName =  lastName,
                Address = address,
                Step1 = false,
                Step2 = false,
                Step3 = false,
                Step4 = false, 
            };
            FourStepJobList.Add(newitem);

            return newitem;
        }

        private FourStepItems FindFourStepJobItem(string lastName, string address)
        {
            //find
            foreach (FourStepItems jobitem in FourStepJobList)
            {
                if ((jobitem.LastName == lastName) && (jobitem.Address == address))
                {
                    return jobitem;
                }
            }

            return null;
        }
        private void serviceDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            FourStepItems item = GetFourStepJobItem(this.serviceDataGridView[1, e.RowIndex].Value.ToString(),
               this.serviceDataGridView[0, e.RowIndex].Value.ToString(),
               this.serviceDataGridView[2, e.RowIndex].Value.ToString());

            if (e.ColumnIndex == 5) //step1
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nJobStep1Count++;
                    item.Step1 = true;
                }
                else
                {
                    nJobStep1Count--;
                    item.Step1 = false;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 6) //step2
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nJobStep2Count++;
                    item.Step2 = true;
                }
                else
                {
                    nJobStep2Count--;
                    item.Step2 = false;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 7) //step3
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nJobStep3Count++;
                    item.Step3 = true;
                }
                else
                {
                    nJobStep3Count--;
                    item.Step3 = false;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 8) //step4
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nJobStep4Count++;
                    item.Step4 = true;
                }
                else
                {
                    nJobStep4Count--;
                   item.Step4 = false;
                }
                UpdateJobLabel(false);
            }
            //for performance
            if ((e.ColumnIndex >= 5) && (e.ColumnIndex <= 8))
            {
                if (!bSelected)
                {
                    nUpperBound = e.RowIndex;
                    nLowerBound = e.RowIndex;
                    nRightBound = e.ColumnIndex;
                    nLeftBound = e.ColumnIndex;
                    bSelected = true;
                }

                if (e.RowIndex < nLowerBound) nLowerBound = e.RowIndex;
                if (e.RowIndex > nUpperBound) nUpperBound = e.RowIndex;
                if (e.ColumnIndex < nLeftBound) nLeftBound = e.ColumnIndex;
                if (e.ColumnIndex > nRightBound) nRightBound = e.ColumnIndex;

            }
        }
        private void UpdateJobLabel(bool nClear)
        {
            if (nClear)
            {
                nJobStep1Count = 0;
                nJobStep2Count = 0;
                nJobStep3Count = 0;
                nJobStep4Count = 0;

            }
            nJobCount = nJobStep1Count + nJobStep2Count + nJobStep3Count + nJobStep4Count;
            Step1Label.Text = nJobStep1Count.ToString();
            Step2Label.Text = nJobStep2Count.ToString();
            Step3Label.Text = nJobStep3Count.ToString();
            Step4Label.Text = nJobStep4Count.ToString();
            TotalNumLabel.Text = nJobCount.ToString();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterComboBox_SelectedIndexChanged(null, null);
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String szFilter = "";
            String szJobFilter = "";
            String szFourStepFilter = "";

            if (FourStepFilterCheckbox.Checked)
                szFourStepFilter = "FourStepType > 0";

            if ((FilterComboBox.SelectedItem == null) || (JobFilterComboBox.SelectedItem == null))
                return;

            if (!AllFilterCheckBox.Checked)
                szFilter = "GroupType = '" + FilterComboBox.Text + "'";

            if ((szFilter != "") && (szFourStepFilter != ""))
            {
                szFilter = szFilter + " and " + szFourStepFilter;
            }
            else
            {
                szFilter = szFilter + szFourStepFilter;
            }

            switch (JobFilterComboBox.SelectedItem.ToString())
            {
                case "None":
                    break;
                case "Step1":
                    szJobFilter = "FourStepType1 > 0";
                    break;
                case "Step2":
                    szJobFilter = "FourStepType2 > 0";
                    break;
                case "Step3":
                    szFilter = "FourStepType3 > 0";
                    break;
                case "Step4":
                    szFilter = "FourStepType4 > 0";
                    break;
                case "All Jobs":
                    szJobFilter = "FourStepType1 > 0 OR FourStepType2 > 0 OR FourStepType3 > 0 OR FourStepType4 > 0";
                    break;
            }

            if ((szFilter != "") && (szJobFilter != ""))
            {
                szFilter = szFilter + " and " + szJobFilter;
            }
            else
            {
                szFilter = szFilter + szJobFilter;
            }

            if  ((szFilter != "")&&(filterTextBox.Text.Length > 0))
                szFilter = szFilter + " and LastName Like '" + filterTextBox.Text + "%'";
            else if (filterTextBox.Text.Length > 0)
                szFilter = "LastName Like '" + filterTextBox.Text + "%'";

            propServiceBindingSource.Filter = szFilter;
            ProtectStepCellDone();
        }

        private void AllFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FilterComboBox.Enabled = true;
            if (AllFilterCheckBox.Checked)
            {
                FilterComboBox.Enabled = false;
            }
            FilterComboBox_SelectedIndexChanged(null, null);
        }

        private void SaveFourStepJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFourStepJobButton.Enabled = false;

                SelectDateDialog datedlg = new SelectDateDialog("Create FourStep Job");
                datedlg.MessageText = "Create " + nJobCount.ToString() + " FourStep Jobs?";
                datedlg.IsScheduledDate = false;
                if (datedlg.ShowDialog() == DialogResult.OK)
                {
                    CreateJobs(datedlg.IsScheduledDate, datedlg.selecteddate);
                }
                SaveFourStepJobButton.Enabled = true;
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ServiceFourStepView");
            }

        }

        private void CreateJobs(bool IsScheduleDate, DateTime date)
        {
            string strPropID = "";
            int nTotalJob = nJobCount;

            //has to be in all mode
            if (!AllFilterCheckBox.Checked)
            {
                AllFilterCheckBox.Checked = true;
                FilterComboBox_SelectedIndexChanged(null, null);
            }
            if (filterTextBox.Text.Length > 0)
            {
                filterTextBox.Text = "";
                filterTextBox_TextChanged(null, null);
            }

            DateTime strDate = date;
            string strCost = "0";
            string strCostB = "0";
            string strCostC = "0";
            string strCostD = "0";
            string strRevenue = "0";
            string strMaterialCost = "0";
            string strContractCost = "0";
            string strFourStepCost = "0";
            string strInstruct = "";
            string strNotes = "";
            string strStatus = "Pending";
            MainForm pParent = (MainForm)this.ParentForm;
            pParent.enableMainButtons(false);
            string strFourStepMat = "0";

            int nCount = 0;
            int rowCount = serviceDataGridView.RowCount;
            //int rowCount = nUpperBound-nLowerBound;

            Cursor.Current = Cursors.WaitCursor;

            pParent.ProgressBarInit(0, rowCount, 1);
            for (int row = 0; row < rowCount; row++)
            {
                for (int j = nLeftBound; j <= nRightBound; j++)
                {

                    if ((this.serviceDataGridView.Rows[row].Cells[j].Value.ToString() == "True") &&
                        (this.serviceDataGridView.Rows[row].Cells[j].ReadOnly == false))
                    {
                        try
                        {
                            string serviceId = this.serviceDataGridView.Rows[row].Cells[10].Value.ToString();
                            System.Windows.Forms.MMS.Data.MMSDataSet.PropServiceDataTable myDataTable =
                                new System.Windows.Forms.MMS.Data.MMSDataSet.PropServiceDataTable();
                            propServiceTableAdapter.FillBy(myDataTable, Convert.ToInt32(serviceId));
                            DataRow dRow = myDataTable.Rows[0];
                            strFourStepMat = "0";

                            strPropID = this.serviceDataGridView.Rows[row].Cells[11].Value.ToString();
                            strPropID = dRow["PropertyID"].ToString();

                            string strType = "";

                            strType = "App";
                            strCost = dRow["FourStepCost"].ToString();
                            strContractCost = "0.00";
                            strFourStepCost = dRow["FourStepCost"].ToString();
                            //strInstruct = this.fourStepInstructTextBox.Text;
                            strInstruct = dRow["fourStepInstruct"].ToString();
                            strMaterialCost = dRow["FourStepCost"].ToString();
                            strFourStepMat = dRow["FourStepMat"].ToString();
                            strNotes = dRow["Notes"].ToString();

                            if (strCost == "") strCost = "0.00";
                            if (strContractCost == "") strContractCost = "0.00";
                            if (strFourStepMat == "") strFourStepMat = "0";
                            if (strFourStepCost == "") strFourStepCost = "0.00";
                            if (strMaterialCost == "") strMaterialCost = "0.00";

                            bool Step1Job = false;
                            bool Step2Job = false;
                            bool Step3Job = false;
                            bool Step4Job = false;

                            switch (j)
                            {
                                case 5: //Step 1
                                    Step1Job = true;
                                    break;
                                case 6: //Step 2
                                    Step2Job = true;
                                    break;
                                case 7: //Step 3
                                    Step3Job = true;
                                    break;
                                case 8: //Step 4
                                    Step4Job = true;
                                    break;
                            }

                            int id = 0;
                            if (IsScheduleDate)
                            {
                                id = Convert.ToInt32(customerJobTableAdapter.InsertQuery(strDate, strType,
                                    Convert.ToDecimal(strCost), Convert.ToDecimal(strContractCost),
                                    Convert.ToDecimal(strFourStepCost), strInstruct, Convert.ToInt32(strPropID),
                                    strStatus,
                                    Convert.ToDecimal(strCostB), Convert.ToDecimal(strCostC), Convert.ToDecimal(strCostD),
                                    Convert.ToDecimal(strRevenue), true, Convert.ToDecimal(strMaterialCost),
                                    (float) Convert.ToDouble(strFourStepMat), strNotes, Step1Job, Step2Job, Step3Job,
                                    Step4Job));

                                switch (j)
                                {
                                    case 5: //Step 1
                                        serviceTableAdapter.UpdateStep1Date(strDate, Convert.ToInt32(serviceId));
                                        break;
                                    case 6: //Step 2
                                        serviceTableAdapter.UpdateStep2Date(strDate, Convert.ToInt32(serviceId));
                                        break;
                                    case 7: //Step 3
                                        serviceTableAdapter.UpdateStep3Date(strDate, Convert.ToInt32(serviceId));
                                        break;
                                    case 8: //Step 4
                                        serviceTableAdapter.UpdateStep4Date(strDate, Convert.ToInt32(serviceId));
                                        break;
                                }
                            }
                            else
                            {
                                id = Convert.ToInt32(customerJobTableAdapter.InsertQuery(null, strType,
                                    Convert.ToDecimal(strCost), Convert.ToDecimal(strContractCost),
                                    Convert.ToDecimal(strFourStepCost), strInstruct, Convert.ToInt32(strPropID),
                                    strStatus,
                                    Convert.ToDecimal(strCostB), Convert.ToDecimal(strCostC), Convert.ToDecimal(strCostD),
                                    Convert.ToDecimal(strRevenue), true, Convert.ToDecimal(strMaterialCost),
                                    (float) Convert.ToDouble(strFourStepMat), strNotes, Step1Job, Step2Job, Step3Job,
                                    Step4Job));
                            }
                            nCount++;

                            //protected it
                            this.serviceDataGridView.Rows[row].Cells[j].ReadOnly = true;
                            this.serviceDataGridView.Rows[row].Cells[j].Style.ForeColor = Color.Green;
                            this.serviceDataGridView.Rows[row].Cells[j].Style.BackColor = Color.Yellow;
                        }
                        catch (Exception exe)
                        {
                            MMSUtility.LogFile(exe.Message, "Create4StepJobs", "Create4StepJobs Function", exe.LineNumber(), "ServiceFourStepView");
                        }
                    }
                }

                pParent.CheckServiceView();                
                pParent.ProgressBarUpdate();
                FourStepJobList.Clear();                

                //peformance once all the job is found, leave
                if (nCount >= nTotalJob)
                {
                    pParent.ProgressBarEnd();
                    RefreshView();
                    break;
                }
            }
            this.Validate();
            this.propServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

            if (nCount > 0)
            {
                string strMessage = nCount.ToString() + " Jobs have been created!";
                MessageBox.Show(strMessage, "Job Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MMSUtility.PlayAcceptSound();
            }
            pParent.enableMainButtons(true);
            pParent.RefreshScheduleView();
            bSelected = false;
            bDirty = false;

            Cursor.Current = Cursors.Default;
        }

        private void clearJobButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear All Selected?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //has to be in all mode
                
                if ((!AllFilterCheckBox.Checked)||(filterTextBox.Text.Length > 0))
                {
                    AllFilterCheckBox.Checked = true;
                    filterTextBox.Text = "";
                    FilterComboBox_SelectedIndexChanged(null, null);
                }
                FourStepJobList.Clear();
                ClearJobs();
                ProtectStepCellDone();
                MMSUtility.PlayAcceptSound();
                bSelected = false;
                bDirty = false;
            }
        }

        private void InitialClear()
        {
            serviceTableAdapter.ClearCheckboxQuery();
            this.propServiceTableAdapter.FillByFourStep(this.mMSDataSet.PropService);
            //this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);


            UpdateJobLabel(true);
            bSelected = false;
        }
        private void ClearJobs()
        {
            MainForm pParent = (MainForm)this.ParentForm;
            pParent.enableMainButtons(false);

            //if it is already done, make the cell readonly
            for (int row = 0; row < serviceDataGridView.RowCount; row++)
            {
                for (int i = 5; i <= 8; i++)
                {
                    if ((this.serviceDataGridView.Rows[row].Cells[i].ReadOnly == false)&&(this.serviceDataGridView.Rows[row].Cells[i].Value.ToString() == "True"))
                    {
                        this.serviceDataGridView.Rows[row].Cells[i].Value = false;
                    }
                }
            }
    
            serviceTableAdapter.ClearCheckboxQuery();
            if (bDirty)
            {
                this.propServiceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                bDirty = false;
            }
            this.propServiceTableAdapter.FillByFourStep(this.mMSDataSet.PropService);
            //this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);


            UpdateJobLabel(true);
            pParent.enableMainButtons(true);
            bSelected = false;

        }

        private void EnableControl(bool bEnable)
        {
            fourStepCostTextBox.ReadOnly = !bEnable;
            fourStepMatTextBox.ReadOnly = !bEnable;
            fourStepTypeCheckBox.Enabled = bEnable;

            if ((fourStepTypeCheckBox.Enabled) && (fourStepTypeCheckBox.Checked))
            {
                fourStepDate1DateTimePicker.Enabled = true;
                fourStepDate2DateTimePicker.Enabled = true;
                fourStepDate3DateTimePicker.Enabled = true;
                fourStepDate4DateTimePicker.Enabled = true;
                fourStepType1CheckBox.Enabled = true;
                fourStepType2CheckBox.Enabled = true;
                fourStepType3CheckBox.Enabled = true;
                fourStepType4CheckBox.Enabled = true;
            }
            else
            {
                fourStepDate1DateTimePicker.Enabled = false;
                fourStepDate2DateTimePicker.Enabled = false;
                fourStepDate3DateTimePicker.Enabled = false;
                fourStepDate4DateTimePicker.Enabled = false;
                fourStepType1CheckBox.Enabled = false;
                fourStepType2CheckBox.Enabled = false;
                fourStepType3CheckBox.Enabled = false;
                fourStepType4CheckBox.Enabled = false;
            }
          
            fourStepInstructTextBox.ReadOnly = !bEnable;
            notesTextBox.ReadOnly = !bEnable;

            propServiceBindingNavigator.Enabled = !bEnable;
            serviceDataGridView.Enabled = !bEnable;
            JobFilterComboBox.Enabled = !bEnable;
            FilterComboBox.Enabled = !bEnable;
            clearJobButton.Enabled = !bEnable;
            ResetFourStepButton.Enabled = bEnable;
            AllFilterCheckBox.Enabled = !bEnable;
            FourStepFilterCheckbox.Enabled = !bEnable;            
            filterTextBox.ReadOnly = bEnable;
            clearJobButton.Enabled = !bEnable;
            SaveFourStepJobButton.Enabled = !bEnable;
            //yCost4StepComboBox.Enabled = bEnable;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            if (editButton.Text == "Edit")
            {
                pParent.enableMainButtons(false);
                editButton.Text = "Save";
                cancelButton.Visible = true;
                EnableControl(true);
                editButton.BackColor = System.Drawing.Color.Salmon;
            }
            else  //save to db
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    editButton.Enabled = false;
                    cancelButton.Visible = false;
                    editButton.Text = "Edit";
                    this.Validate();
                    this.propServiceBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                    //Andy need to rebind if user cancels
                    EnableControl(false);
                    editButton.BackColor = System.Drawing.Color.Transparent;
                    pParent.enableMainButtons(true);
                    editButton.Enabled = true;
                    ProtectStepCellDone();

                    pParent.SetStatusLabelTimer(5, "Data Updated....");
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ServiceFourStepView");
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            editButton.Text = "Edit";
            //propServiceBindingNavigator.Refresh();
            //serviceDataGridView.Refresh();
            //editButton.Enabled = true;
            cancelButton.Visible = false;
            EnableControl(false);
            editButton.BackColor = System.Drawing.Color.Transparent;
            pParent.enableMainButtons(true);
            RefreshView();
        }

        private void FourStepFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            FilterComboBox.Enabled = true;
            if (AllFilterCheckBox.Checked)
            {
                FilterComboBox.Enabled = false;
            }
            FilterComboBox_SelectedIndexChanged(null, null);
        }

        private void ResetFourStepButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear FourStep Dates and Flags? This should only be done in the begining of each year!",
                "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                serviceTableAdapter.ResetFourStepService();
                RefreshView();
            }
        }

        private void serviceDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProtectStepCellDone();
        }

        private void serviceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            if (serviceDataGridView.SelectedRows.Count > 1)
            {
                editButton.Enabled = false;
            }
        }
    }
}
