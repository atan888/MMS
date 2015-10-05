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

namespace System.Windows.Forms.MMS.Views
{
    public partial class ServiceView : BaseView
    {
        private int nJobCount = 0;
        private int nMowJobCount = 0;
        private int nLeafJobCount = 0;
        private int nGutterJobCount = 0;
        private int nAppJobCount = 0;
        private int nPruneJobCount = 0;
        private int nMulchJobCount = 0;
        private int nOtherJobCount = 0;
        private bool bSelected = false;
        private int nUpperBound = 0;
        private int nLowerBound = 0;
        private int nLeftBound = 9;
        private int nRightBound = 15;
        private bool bDirty = false; //has been clicked
        private string saveGroupType = "";
        private int nSavedIndex = 0;

        public ServiceView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Service";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
            JobFilterComboBox.SelectedIndex= 0;
            //FilterComboBox.SelectedIndex = 0;
            FilterComboBox.SelectedIndex = 0;
            EnableControl(false);
            cancelButton.Visible = false;
            FilterComboBox.Enabled = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);
                this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            }
            //ClearJobs(); // causing mainform issues
            UpdateJobLabel(true);
            nUpperBound = this.serviceDataGridView.RowCount;
            FourStepFilterCheckbox.Checked = false;
            FourStepFilterCheckbox_CheckedChanged(null, null);
        }

        public override void RefreshView()
        {
            int nIndex = 0;
            if (this.serviceDataGridView.CurrentRow != null)
               nIndex = this.serviceDataGridView.CurrentRow.Index;

            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            if (serviceDataGridView.RowCount > 0)
            {
                this.serviceDataGridView.CurrentCell = this.serviceDataGridView.Rows[nIndex].Cells[0];
            }
            //this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);
            InitialClear();

        }

        public void CheckView()
        {            
            //method to check if flag is dirty, because the user is in a differt
            //tab (4stepservice) and they might be changing the same table adapter,
            //if so, have to refresh view.
            if (bDirty)
            {
                RefreshView();
            }
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
            {
                String szTemp = FilterComboBox.Text;
                //if (szTemp == "<blank>") szTemp = "";
                szFilter = "GroupType = '" + szTemp + "'";
            }

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
                case "Mow":
                    szJobFilter = "MowType > 0";
                    break;
                case "Leaf":
                    szJobFilter = "LeafType > 0";
                    break;
                case "Gutter":
                    szFilter = "GutterType > 0";
                    break;
                case "Application":
                    szFilter = "ApplicationType > 0";
                    break;
                case "Pruning":
                    szFilter = "PruningType > 0";
                    break;
                case "Mulching":
                    szFilter = "MulchingType > 0";
                    break;
                 case "Other":
                    szJobFilter = "OtherType > 0"; 
                    break;
                case "All Jobs":
                    szJobFilter = "MowType > 0 OR LeafType > 0 OR GutterType > 0 OR ApplicationType > 0 OR PruningType > 0 or MulchingType > 0 OR OtherType > 0";
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

            if ((szFilter != "") && (filterTextBox.Text.Length > 0))
                szFilter = szFilter + " and LastName Like '" + filterTextBox.Text + "%'";
            else if (filterTextBox.Text.Length > 0)
                szFilter = "LastName Like '" + filterTextBox.Text + "%'";

            propServiceBindingSource.Filter = szFilter;
        }

        private void EnableControl(bool bEnable)
        {
            costTextBox.ReadOnly = !bEnable;
            costBTextBox.ReadOnly = !bEnable;
            costCTextBox.ReadOnly = !bEnable;
            costAppTextBox.ReadOnly = !bEnable;
            costPruningTextBox.ReadOnly = !bEnable;
            costMulchingTextBox.ReadOnly = !bEnable;
            costOtherTextBox.ReadOnly  = !bEnable;
            contractorCostTextBox.ReadOnly = !bEnable;
            cCostBTextBox.ReadOnly = !bEnable; ;
            cCostCTextBox.ReadOnly = !bEnable;
            cCostAppTextBox.ReadOnly = !bEnable;
            cCostPruningTextBox.ReadOnly = !bEnable;
            cCostMulchingTextBox.ReadOnly = !bEnable;
            cCostOtherTextBox.ReadOnly = !bEnable;
            AllFilterCheckBox.Enabled = !bEnable;
            FourStepFilterCheckbox.Enabled = !bEnable;
            RouteButton.Enabled = !bEnable;
            filterTextBox.ReadOnly = bEnable;
            groupTypeComboBox.Enabled = bEnable;
            yCostAppComboBox.Enabled = bEnable;
            yCostBComboBox.Enabled = bEnable;
            yCostCComboBox.Enabled = bEnable;
            yCostComboBox.Enabled = bEnable;
            yCostMulchingComboBox.Enabled = bEnable;
            yCostOtherComboBox.Enabled = bEnable;
            yCostPruningComboBox.Enabled = bEnable;

            frequencyTextBox.ReadOnly = !bEnable;
            springServicesTextBox.ReadOnly = !bEnable;
            summerServicesTextBox.ReadOnly = !bEnable;
            fallServicesTextBox.ReadOnly = !bEnable;
            winterServicesTextBox.ReadOnly = !bEnable;
            fourStepTypeCheckBox.Enabled = bEnable;
           
            propMowTextBox.ReadOnly = !bEnable;
            propFourStepTextBox.ReadOnly = !bEnable;
            propSeedTextBox.ReadOnly = !bEnable;
            propFertilizeTextBox.ReadOnly = !bEnable;
            propFourStepTextBox.ReadOnly = !bEnable;
            propLimeTextBox.ReadOnly = !bEnable;
            propAerationTextBox.ReadOnly = !bEnable;
            appInstructTextBox.ReadOnly = !bEnable;
            gutterInstructTextBox.ReadOnly = !bEnable;
            specInstructTextBox.ReadOnly = !bEnable;
            leafInstructTextBox.ReadOnly = !bEnable; 
            pruneInstructTextBox1.ReadOnly = !bEnable;
            mulchInstructTextBox.ReadOnly = !bEnable;
            otherInstructTextBox.ReadOnly = !bEnable;
            notesTextBox.ReadOnly = !bEnable;            
            
            propServiceBindingNavigator.Enabled = !bEnable;
            serviceDataGridView.Enabled = !bEnable;
            JobFilterComboBox.Enabled = !bEnable;

            FilterComboBox.Enabled = !bEnable;
            if (AllFilterCheckBox.Enabled)                
                FourStepFilterCheckbox_CheckedChanged(null, null);

            clearJobButton.Enabled = !bEnable;
            SaveJobButton.Enabled =  !bEnable;
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
                saveGroupType = groupTypeComboBox.Text;

                if (this.serviceDataGridView.CurrentRow == null)
                    nSavedIndex = 0; 
                else
                    nSavedIndex = this.serviceDataGridView.CurrentRow.Index;
            }
            else  //save to db
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    //save grouptype separately in Property table                    
                    //DataGridViewRow dataGridViewRow = serviceDataGridView.SelectedRows[0];
                    //string propID = dataGridViewRow.Cells[17].Value.ToString();
                    //propertyTableAdapter.UpdateGroupType(groupTypeComboBox.Text, Convert.ToInt32(propID)); 
                    int nPropID = Convert.ToInt32(propertyIDTextBox.Text);
                    propertyTableAdapter.UpdateGroupType(groupTypeComboBox.Text, nPropID);   

                    editButton.Enabled = false;
                    cancelButton.Visible = false;
                    editButton.Text = "Edit";                    
                    this.Validate();                    
                    this.propServiceBindingSource.EndEdit();      
                    this.propertyBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mMSDataSet);                                                                                                           

                    //Andy need to rebind if user cancels
                    EnableControl(false);
                    editButton.BackColor = System.Drawing.Color.Transparent;
                    pParent.enableMainButtons(true);
                    editButton.Enabled = true;
                    //RefreshView();

                    pParent.SetStatusLabelTimer(5, "Data Updated....");
                }
                catch (DBConcurrencyException exe)
                {
                    string customErrorMessage;
                    customErrorMessage = "Concurrency violation\n";
                    customErrorMessage += exe.Row[0].ToString();

                    MMSUtility.LogFile(exe.Message, customErrorMessage, ((Control)sender).Name, exe.LineNumber(), "ServiceView");
                }
                Cursor.Current = Cursors.Default;
            }
        }        


        private void cancelButton_Click(object sender, EventArgs e)
        {
            propServiceTableAdapter.ClearBeforeFill = true;
            this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);

            MainForm pParent = (MainForm)this.ParentForm;
            editButton.Text = "Edit";
            propServiceBindingNavigator.Refresh();
            groupTypeComboBox.Text = saveGroupType;

            serviceDataGridView.Refresh();
            //editButton.Enabled = true;
            cancelButton.Visible = false;
            EnableControl(false);
            editButton.BackColor = System.Drawing.Color.Transparent;
            pParent.enableMainButtons(true);

            if (serviceDataGridView.RowCount > 0)
            {
                this.serviceDataGridView.CurrentCell = this.serviceDataGridView.Rows[nSavedIndex].Cells[0];
            }
        }

        private void SaveJobButton_Click(object sender, EventArgs e)
        {
            SaveFourStepJobButton.Enabled = false;
            SaveJobButton.Enabled = false;

            SelectDateDialog datedlg = new SelectDateDialog("Create Jobs");
            datedlg.MessageText = "Create " + nJobCount.ToString() + " Jobs?";
            datedlg.IsScheduledDate = false;
            if (datedlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CreateJobs(datedlg.IsScheduledDate, datedlg.selecteddate, false);
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ServiceView");
                }

            }
            SaveJobButton.Enabled = true;
            SaveFourStepJobButton.Enabled = true;
        }

        private void SaveFourStepJobButton_Click(object sender, EventArgs e)
        {
            SaveFourStepJobButton.Enabled = false;
            SaveJobButton.Enabled = false;

            SelectDateDialog datedlg = new SelectDateDialog("Create FourStep Job");
            datedlg.MessageText = "Create " + nJobCount.ToString() + " FourStep Jobs?";
            datedlg.IsScheduledDate = false;
            if (datedlg.ShowDialog() == DialogResult.OK)
            {
                CreateJobs(datedlg.IsScheduledDate, datedlg.selecteddate, true);
            }
            SaveJobButton.Enabled = true;
            SaveFourStepJobButton.Enabled = true;
        }        

        private void CreateJobs(bool IsScheduleDate, DateTime date, bool bIsFourStep)
        {
            string strPropID = "";
            int nTotalJob = nJobCount;

            //SelectDateDialog datedlg = new SelectDateDialog("Schedule Job");
            //if (datedlg.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}

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
            bool bFourStepJob = false;
            string strFourStepMat = "0";

            int nCount = 0;
            int rowCount = serviceDataGridView.RowCount;
            //int rowCount = nUpperBound-nLowerBound;

            Cursor.Current = Cursors.WaitCursor;

            pParent.ProgressBarInit(0, rowCount, 1);
            for (int row = 0; row < rowCount; row++)
            //for (int row = nLowerBound; row <= nUpperBound; row++)
            {
                //for (int j = 9; j <= 15; j++)
                for (int j = nLeftBound; j <= nRightBound; j++)
                {                                       
                    if (this.serviceDataGridView.Rows[row].Cells[j].Value.ToString() == "True")
                    {
                        try
                        {
                            string serviceId = this.serviceDataGridView.Rows[row].Cells[18].Value.ToString();
                            System.Windows.Forms.MMS.Data.MMSDataSet.PropServiceDataTable myDataTable =
                                new System.Windows.Forms.MMS.Data.MMSDataSet.PropServiceDataTable();
                            propServiceTableAdapter.FillBy(myDataTable, Convert.ToInt32(serviceId));
                            DataRow dRow = myDataTable.Rows[0];
                            strFourStepMat = "0";

                            strPropID = this.serviceDataGridView.Rows[row].Cells[17].Value.ToString();
                            strPropID = dRow["PropertyID"].ToString();

                            string strType = "";

                            switch (j)
                            {
                                case 9:
                                    strType = "Mow";
                                    strCost = dRow["Cost"].ToString();
                                    strContractCost = dRow["ContractorCost"].ToString();
                                    strInstruct = dRow["specInstruct"].ToString(); //used for MOW
                                    //strInstruct = this.specInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                                case 10:
                                    strType = "Leaf";
                                    strCost = dRow["CostB"].ToString();
                                    strContractCost = dRow["CCostB"].ToString();
                                    strInstruct = dRow["leafInstruct"].ToString();
                                    //strInstruct = this.leafInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                                case 11:
                                    strType = "Gutter";
                                    strCost = dRow["CostC"].ToString();
                                    strContractCost = dRow["CCostC"].ToString();
                                    strInstruct = dRow["gutterInstruct"].ToString();
                                    //strInstruct = this.gutterInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                                case 12:
                                    strType = "App";
                                    strCost = dRow["CostApp"].ToString();
                                    strContractCost = dRow["CCostApp"].ToString();
                                    strInstruct = dRow["appInstruct"].ToString();
                                    //strInstruct = this.appInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                                case 13:
                                    strType = "Prune";
                                    strCost = dRow["CostPruning"].ToString();
                                    strContractCost = dRow["CCostPruning"].ToString();
                                    strInstruct = dRow["pruneInstruct"].ToString();
                                    //strInstruct = this.pruneInstructTextBox1.Text;                                
                                    break;
                                case 14:
                                    strType = "Mulch";
                                    strCost = dRow["CostMulching"].ToString();
                                    strContractCost = dRow["CCostMulching"].ToString();
                                    strInstruct = dRow["mulchInstruct"].ToString();
                                    //strInstruct = this.mulchInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                                case 15:
                                    strType = "Other";
                                    strCost = dRow["CostOther"].ToString();
                                    strContractCost = dRow["CCostOther"].ToString();
                                    strInstruct = dRow["otherInstruct"].ToString();
                                    //strInstruct = this.otherInstructTextBox.Text;
                                    strNotes = dRow["Notes"].ToString();
                                    break;
                            }
                            if (bIsFourStep)
                            {
                                strCost = dRow["FourStepCost"].ToString();
                                strContractCost = "0.00";
                                strFourStepCost = dRow["FourStepCost"].ToString();
                                //strInstruct = this.fourStepInstructTextBox.Text;
                                strInstruct = dRow["fourStepInstruct"].ToString();
                                bFourStepJob = true;
                                strMaterialCost = dRow["FourStepCost"].ToString();
                                strFourStepMat = dRow["FourStepMat"].ToString();
                                strNotes = dRow["Notes"].ToString();
                            }

                            if (strCost == "") strCost = "0.00";
                            if (strContractCost == "") strContractCost = "0.00";
                            if (strFourStepMat == "") strFourStepMat = "0";
                            if (strFourStepCost == "") strFourStepCost = "0.00";
                            if (strMaterialCost == "") strMaterialCost = "0.00";

                            int id = 0;
                            if (IsScheduleDate)
                            {
                                id = Convert.ToInt32(customerJobTableAdapter.InsertQuery(strDate, strType,
                                    Convert.ToDecimal(strCost), Convert.ToDecimal(strContractCost),
                                    Convert.ToDecimal(strFourStepCost), strInstruct, Convert.ToInt32(strPropID),
                                    strStatus,
                                    Convert.ToDecimal(strCostB), Convert.ToDecimal(strCostC), Convert.ToDecimal(strCostD),
                                    Convert.ToDecimal(strRevenue), bFourStepJob, Convert.ToDecimal(strMaterialCost),
                                    (float) Convert.ToDouble(strFourStepMat), strNotes, false, false, false, false));
                            }
                            else
                            {
                                id = Convert.ToInt32(customerJobTableAdapter.InsertQuery(null, strType,
                                    Convert.ToDecimal(strCost), Convert.ToDecimal(strContractCost),
                                    Convert.ToDecimal(strFourStepCost), strInstruct, Convert.ToInt32(strPropID),
                                    strStatus,
                                    Convert.ToDecimal(strCostB), Convert.ToDecimal(strCostC), Convert.ToDecimal(strCostD),
                                    Convert.ToDecimal(strRevenue), bFourStepJob, Convert.ToDecimal(strMaterialCost),
                                    (float) Convert.ToDouble(strFourStepMat), strNotes, false, false, false, false));

                            }
                            nCount++;

                            //clear it
                            this.serviceDataGridView.Rows[row].Cells[j].Value = "False";
                        }
                        catch (Exception exe)
                        {
                            MMSUtility.LogFile(exe.Message, "CreateJobs", "CreateJobs Function", exe.LineNumber(), "ServiceView");
                        }
                    }
                }
                pParent.ProgressBarUpdate();

                //peformance once all the job is found, leave
                if (nCount >= nTotalJob)
                {                    
                    pParent.ProgressBarEnd();
                    break; 
                }
            }
            
            if (nCount > 0)
            {
                string strMessage = nCount.ToString() + " Jobs have been created!";
                MessageBox.Show(strMessage, "Job Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MMSUtility.PlayAcceptSound();                
            }

            this.Validate();
            this.propServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);


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

                ClearJobs();
                MMSUtility.PlayAcceptSound();
                bSelected = false;
                bDirty = false;
            }
        }
        private void InitialClear()
        {
            /*
            int rowCount = serviceDataGridView.RowCount;
            for (int row = 0; row < rowCount; row++)
            {
                this.serviceDataGridView.Rows[row].Cells[9].Value = "false";  //MowType
                this.serviceDataGridView.Rows[row].Cells[10].Value = "false"; //leaf
                this.serviceDataGridView.Rows[row].Cells[11].Value = "false"; //gutter
                this.serviceDataGridView.Rows[row].Cells[12].Value = "false"; //app
                this.serviceDataGridView.Rows[row].Cells[13].Value = "false"; //prune
                this.serviceDataGridView.Rows[row].Cells[14].Value = "false"; //mulch
                this.serviceDataGridView.Rows[row].Cells[15].Value = "false"; //Other
            
            }
             */

            serviceTableAdapter.ClearCheckboxQuery();
            //this.propServiceBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.mMSDataSet);
            this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);

            UpdateJobLabel(true);
            bSelected = false;
        }

        private void ClearJobs()
        {
            MainForm pParent = (MainForm)this.ParentForm;            
            pParent.enableMainButtons(false);
            /*
             int rowCount = serviceDataGridView.RowCount;
             pParent.ProgressBarInit(0, rowCount,1);
             for (int row = 0; row < rowCount; row++)
             {
                 if ((bool)this.serviceDataGridView[9,row].Value == true)
                     this.serviceDataGridView.Rows[row].Cells[9].Value = "false";  //MowType
                 if ((bool)this.serviceDataGridView[10, row].Value == true)                
                     this.serviceDataGridView.Rows[row].Cells[10].Value = "false";  //leaf
                 if ((bool)this.serviceDataGridView[11, row].Value == true)                
                     this.serviceDataGridView.Rows[row].Cells[11].Value = "false";  //gutter
                 if ((bool)this.serviceDataGridView[12, row].Value == true)                
                     this.serviceDataGridView.Rows[row].Cells[12].Value = "false";  //apps
                 if ((bool)this.serviceDataGridView[13, row].Value == true)
                     this.serviceDataGridView.Rows[row].Cells[13].Value = "false";  //prune
                 if ((bool)this.serviceDataGridView[14, row].Value == true)
                     this.serviceDataGridView.Rows[row].Cells[14].Value = "false";  //mulch
                 if ((bool)this.serviceDataGridView[15, row].Value == true)
                     this.serviceDataGridView.Rows[row].Cells[15].Value = "false";  //other
                 pParent.ProgressBarUpdate();
             }
              */
            serviceTableAdapter.ClearCheckboxQuery();
            if (bDirty)
            {
                this.propServiceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                bDirty = false;
            }
            this.propServiceTableAdapter.Fill(this.mMSDataSet.PropService);

            UpdateJobLabel(true);
            pParent.enableMainButtons(true);
            bSelected = false;

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

        private void serviceDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (e.ColumnIndex == 9) //Mow
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nMowJobCount++;
                }
                else
                {
                    nMowJobCount--;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 10) //Leaf 
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nLeafJobCount++;
                }
                else
                {
                    nLeafJobCount--;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 11) //Gutter
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nGutterJobCount++;
                }
                else
                {
                    nGutterJobCount--;
                }
                UpdateJobLabel(false);
            }

            if (e.ColumnIndex == 12) //Application
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nAppJobCount++;
                }
                else
                {
                    nAppJobCount--;
                }
                UpdateJobLabel(false);
            }
            if (e.ColumnIndex == 13) //Pruning
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nPruneJobCount++;
                }
                else
                {
                    nPruneJobCount--;
                }
                UpdateJobLabel(false);
            }

            if (e.ColumnIndex == 14) //Mulching
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nMulchJobCount++;
                }
                else
                {
                    nMulchJobCount--;
                }
                UpdateJobLabel(false);
            }

            if (e.ColumnIndex == 15) //Other
            {
                if ((bool)this.serviceDataGridView[e.ColumnIndex, e.RowIndex].Value == true)
                {
                    nOtherJobCount++;
                }
                else
                {
                    nOtherJobCount--;
                }
                UpdateJobLabel(false);
            }

            //for performance
            if ((e.ColumnIndex >= 9) && (e.ColumnIndex <= 15))
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
                nJobCount = 0;
                nMowJobCount = 0;
                nLeafJobCount = 0;
                nGutterJobCount = 0;
                nAppJobCount = 0;
                nPruneJobCount = 0;
                nMulchJobCount = 0;
                nOtherJobCount = 0;
            }
            nJobCount = nMowJobCount + nLeafJobCount + nGutterJobCount + nAppJobCount + nPruneJobCount + nMulchJobCount + nOtherJobCount;
            MowNumLabel.Text = nMowJobCount.ToString();
            LeafNumLabel.Text = nLeafJobCount.ToString();
            GutterNumLabel.Text = nGutterJobCount.ToString();
            AppNumLabel.Text = nAppJobCount.ToString();
            PruneNumLabel.Text = nPruneJobCount.ToString();
            MulchNumLabel.Text = nMulchJobCount.ToString();
            OtherNumLabel.Text = nOtherJobCount.ToString();                        
            TotalNumLabel.Text = nJobCount.ToString();
        }
        public override void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Service Type Listing";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Meriweather Management System";
            printer.FooterSpacing = 15;
          
            // use saved settings
            if (null != MMSUtility.myPrinterSettings)
                printer.printDocument.PrinterSettings = MMSUtility.myPrinterSettings;

            if (null != MMSUtility.myPageSettings)
                printer.printDocument.DefaultPageSettings = MMSUtility.myPageSettings;

            if (DialogResult.OK == printer.DisplayPrintDialog())  // replace DisplayPrintDialog()
            // with your own print dialog
            {
                // save users' settings 
                MMSUtility.myPrinterSettings = printer.PrintSettings;
                MMSUtility.myPageSettings = printer.PageSettings;

                // print without displaying the printdialog
                printer.PrintNoDisplay(serviceDataGridView);
            }           
        }

        public override void PrintPreview()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Service Type Listing";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Meriweather Management System";
            printer.FooterSpacing = 15;

            // use saved settings
            if (null != MMSUtility.myPrinterSettings)
                printer.printDocument.PrinterSettings = MMSUtility.myPrinterSettings;

            if (null != MMSUtility.myPageSettings)
                printer.printDocument.DefaultPageSettings = MMSUtility.myPageSettings;

            if (DialogResult.OK == printer.DisplayPrintDialog())  // replace DisplayPrintDialog()
            // with your own print dialog
            {
                // save users' settings 
                MMSUtility.myPrinterSettings = printer.PrintSettings;
                MMSUtility.myPageSettings = printer.PageSettings;

                // print without displaying the printdialog
                printer.PrintPreviewNoDisplay(serviceDataGridView);
            }            
        }

        private void FourStepFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            FilterComboBox.Enabled = true;
            if (AllFilterCheckBox.Checked) {
                FilterComboBox.Enabled = false;
            }
            FilterComboBox_SelectedIndexChanged(null, null);
        }

        private void RouteButton_Click(object sender, EventArgs e)
        {
            string propertyID = "";
            int nOrderNum = 0;
            string szRouteName = "";
            string szNotes = "";

            AssignRouteDialog dlg = new AssignRouteDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                szRouteName = dlg.GetRouteText();
                foreach (DataGridViewRow dataGridViewRow in serviceDataGridView.SelectedRows)
                {
                    propertyID = dataGridViewRow.Cells[17].Value.ToString();
                    if (routeTableAdapter1.GetRouteExist(szRouteName, Convert.ToInt32(propertyID)) == 0)
                        routeTableAdapter1.Insert(Convert.ToInt32(propertyID), nOrderNum, szRouteName, szNotes);                
                }
                MainForm pParent = (MainForm)this.ParentForm;
                pParent.RefreshRouteView();
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterComboBox_SelectedIndexChanged(null, null);
            /*
            string szFilter = "";
            if (filterTextBox.Text.Length > 0) 
                szFilter = "LastName Like '" + filterTextBox.Text + "%'";
             
            propServiceBindingSource.Filter = szFilter;*/
        }

        private void fourStepTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (fourStepTypeCheckBox.Checked)
            {
                fourStepDate1DateTimePicker.Enabled = true;
                fourStepDate2DateTimePicker.Enabled = true;
                fourStepDate3DateTimePicker.Enabled = true;
                fourStepDate4DateTimePicker.Enabled = true;
            }
            else
            {
                fourStepDate1DateTimePicker.Enabled = false;
                fourStepDate2DateTimePicker.Enabled = false;
                fourStepDate3DateTimePicker.Enabled = false;
                fourStepDate4DateTimePicker.Enabled = false;
            }*/
 
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
