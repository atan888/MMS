using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.MMS;
using DGVPrinterHelper;
using Interop.QBFC11;
using System.Text.RegularExpressions;


namespace System.Windows.Forms.MMS.Views
{
    public partial class ScheduleView : BaseView
    {
        private int nSavedIndex = 0;
        private List<Item> QBitems1 = new List<Item>();
        private List<Item> QBitems2 = new List<Item>();
        private List<Item> QBitems3 = new List<Item>();
        private List<Item> QBitems4 = new List<Item>();
        //private bool bCostChange = false;

        public ScheduleView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            SplashScreen.SetStatus("Loading Schedule Module", false);
            this.titleStrip1.HeaderText.Text = "Schedule";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, System.Drawing.FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;

            if (!this.DesignMode)
            {
                this.customerJobTableAdapter.Fill(this.mMSDataSet.CustomerJob);
                this.custPropertyJobsTableAdapter.Fill(this.mMSDataSet.CustPropertyJobs);
                this.jobStatusListTableAdapter.Fill(this.mMSDataSet.JobStatusList);
                this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
                this.JobTypeFilterComboBox.SelectedIndex = 0;
            }

            //saveButton.Enabled = false;
            cancelButton.Hide();
            EnableControls(false);
            SetButtonsStatus();

            QBInvoiceButton.Enabled = false;
            if (MMSUtility.UserPref.QBIntegration)
            {
                GetQBItems();
                QBInvoiceButton.Enabled = true;
            }

        }

        public override void RefreshView()
        {
            int nIndex = 0;
            if (this.extendedDataGridView1.CurrentRow != null)
                nIndex = this.extendedDataGridView1.CurrentRow.Index;

            this.custPropertyJobsTableAdapter.Fill(this.mMSDataSet.CustPropertyJobs);
            if ((extendedDataGridView1.RowCount > 0) && (nIndex < extendedDataGridView1.RowCount))
            {
                this.extendedDataGridView1.CurrentCell = this.extendedDataGridView1.Rows[nIndex].Cells[4];
            }

            this.jobStatusListTableAdapter.Fill(this.mMSDataSet.JobStatusList);
            this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
            SetButtonsStatus();
            if (MMSUtility.UserPref.QBIntegration)
            {
                QBInvoiceButton.Enabled = true;
            }

        }

        private void PrintSheetsButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrintSheets();
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
            }
        }
     
        public override void PrintSheets()
        {
            int nCount = 0;
            this.custPropertyJobsTableAdapter.ClearSelectPrint();
            foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
            {
                nCount++;
                string jobID = dataGridViewRow.Cells[0].Value.ToString();
                this.custPropertyJobsTableAdapter.UpdateSelectPrint(true, Convert.ToInt32(jobID));
            }
            MainForm pParent = (MainForm)this.ParentForm;
            pParent.SetStatusLabelTimer(5, "Selected Count:" + nCount.ToString());

            PrintSheetsDialog dlg = new PrintSheetsDialog("Main");
            dlg.ShowDialog();
          
        }

        public override void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Sheduled Job Listing";
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
                printer.PrintNoDisplay(extendedDataGridView1);
            }
        }

        public override void PrintPreview()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Sheduled Job Listing";
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
                printer.PrintPreviewNoDisplay(extendedDataGridView1);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please check possible QB entry(s)!\nContinue to delete the Selected Job?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int nIndex = this.extendedDataGridView1.CurrentRow.Index;
                    foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                    {
                        string jobID = dataGridViewRow.Cells[0].Value.ToString();
                        //string jobID = this.extendedDataGridView1.SelectedCells[0].Value.ToString();

                        //clear crew for the jobid
                        crewNameTableAdapter.DeleteJobIDQuery(Convert.ToInt32(jobID));
                        //delete job
                        this.custPropertyJobsTableAdapter.DeleteJobQuery(Convert.ToInt32(jobID));
                    }

                    //RefreshView();  //Andy - must change to remove row only in the grid
                    this.custPropertyJobsTableAdapter.Fill(this.mMSDataSet.CustPropertyJobs);
                    if (this.extendedDataGridView1.RowCount == 0)
                        this.extendedDataGridView1.CurrentCell = null;
                    else if (this.extendedDataGridView1.RowCount == 1)
                        this.extendedDataGridView1.CurrentCell = this.extendedDataGridView1.Rows[0].Cells[4];
                    else if (nIndex >= this.extendedDataGridView1.RowCount - 1)
                        this.extendedDataGridView1.CurrentCell = this.extendedDataGridView1.Rows[nIndex - 1].Cells[4];
                    else
                        this.extendedDataGridView1.CurrentCell = this.extendedDataGridView1.Rows[nIndex + 1].Cells[4];

                    MMSUtility.PlayAcceptSound();
                    SetButtonsStatus();
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                }
            }
        }

        private void modifyWorkButton_Click(object sender, EventArgs e)
        {
            nSavedIndex = this.extendedDataGridView1.CurrentRow.Index;

            if (modifyWorkButton.Text == "Edit")
            {
                modifyWorkButton.Text = "Save";
                EnableControls(true);
                cancelButton.Show();
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    this.Validate();
                    this.custPropertyJobsBindingSource.EndEdit();
                    this.customerJobBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                    modifyWorkButton.Text = "Edit";
                    EnableControls(false);
                    cancelButton.Hide();
                    MainForm pParent = (MainForm) this.ParentForm;
                    pParent.SetStatusLabelTimer(5, "Data Updated....");
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                }
                Cursor.Current = Cursors.Default;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            custPropertyJobsTableAdapter.ClearBeforeFill = true;
            this.custPropertyJobsTableAdapter.Fill(this.mMSDataSet.CustPropertyJobs);

            if (this.extendedDataGridView1.RowCount > 0)
                this.extendedDataGridView1.CurrentCell = this.extendedDataGridView1.Rows[nSavedIndex].Cells[4];

            custPropertyJobsBindingNavigator.Refresh();
            extendedDataGridView1.Refresh();
            modifyWorkButton.Text = "Edit";
            EnableControls(false);
            cancelButton.Hide();
        }

        private void EnableControls(bool bEnable)
        {
            dateDateTimePicker.Enabled = bEnable;
            costTextBox.ReadOnly = !bEnable;
            costBTextBox.ReadOnly = !bEnable;
            costCTextBox.ReadOnly = !bEnable;
            costDTextBox.ReadOnly = !bEnable;
            manHoursTextBox.ReadOnly = !bEnable;
            revenueTextBox.ReadOnly = !bEnable;
            costContractorTextBox.ReadOnly = !bEnable;
            //costFourStepTextBox.ReadOnly = !bEnable;
            instructionsTextBox.ReadOnly = !bEnable;
            notesTextBox.ReadOnly = !bEnable;
            //complimentsTextBox.ReadOnly = !bEnable;
            //complaintsTextBox.ReadOnly = !bEnable;
            materialCostTextBox.ReadOnly = !bEnable;
            fourStepJobCheckBox.Enabled = bEnable;
            statusComboBox.Enabled = bEnable;
            typeComboBox.Enabled = bEnable;
            fourStepMatTextBox.ReadOnly = !bEnable;
            qBInvoiceIDTextBox.ReadOnly = !bEnable;

        }

        private void SetButtonsStatus()
        {
            if (extendedDataGridView1.RowCount > 0)
            {
                setJobStatusButton.Enabled = true;
                assignCrewButton.Enabled = true;
                deleteButton.Enabled = true;
                modifyWorkButton.Enabled = true;
                crewButton.Enabled = true;
                PrintSheetsButton.Enabled = true;

            }
            else
            {
                setJobStatusButton.Enabled = false;
                assignCrewButton.Enabled = false;
                deleteButton.Enabled = false;
                modifyWorkButton.Enabled = false;
                crewButton.Enabled = false;
                PrintSheetsButton.Enabled = false;
            }
        }

        private void extendedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowCount = extendedDataGridView1.RowCount;
            
            modifyWorkButton.Enabled = true;
            if (extendedDataGridView1.SelectedRows.Count > 1) modifyWorkButton.Enabled = false;

            //QBInvoiceButton.Enabled = false;
            if ((rowCount > 0) && (this.extendedDataGridView1.SelectedCells.Count > 0))
            {
                string jobID = this.extendedDataGridView1.SelectedCells[0].Value.ToString();
                crewNameTableAdapter.FillBy(this.mMSDataSet.CrewName, Convert.ToInt32(jobID));

                //TODO - strip $$ sign on revenue
                if ((revenueTextBox.Text != "") && (manHoursTextBox.Text != ""))
                {
                    string revenue = revenueTextBox.Text;
                    revenue = revenue.Substring(1);
                    double permanhours = Convert.ToDouble(revenue) / Convert.ToDouble(manHoursTextBox.Text);
                    PMH.Text = "$" + String.Format("{0:0.00}", permanhours); //permanhours.ToString();
                }

                //if (this.extendedDataGridView1.SelectedRows.Count == 1)
                    //QBInvoiceButton.Enabled = true;
            }

        }

        private void crewButton_Click(object sender, EventArgs e)
        {
            string selectedJobID = this.extendedDataGridView1.SelectedCells[0].Value.ToString();
            string jobID = "";

            if (this.extendedDataGridView1.SelectedCells.Count == 1)
                jobID = this.extendedDataGridView1.SelectedCells[0].Value.ToString();

            //if only one is selected, send it JobID to initialize
            AddCrewDialog dlg = new AddCrewDialog(jobID);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                    {
                        jobID = dataGridViewRow.Cells[0].Value.ToString();
                        if (jobID != "") dlg.UpdateCreateCrew(jobID);
                    }
                    //refresh the data as it has been changed by the dialog
                    crewNameTableAdapter.FillBy(this.mMSDataSet.CrewName, Convert.ToInt32(selectedJobID));
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                }
            }
        }

        //add crew via datagrid multi-select
        private void assignCrewButton_Click(object sender, EventArgs e)
        {
            bool bRefesh4Step = false;
            string jobID = "";
            string propID = "";
            if (extendedDataGridView1.SelectedRows.Count == 1)
            {
                jobID = extendedDataGridView1.SelectedCells[0].Value.ToString();
            }

            AddCrewDialog dlg = new AddCrewDialog(jobID);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                    {
                        jobID = dataGridViewRow.Cells[0].Value.ToString();
                        propID = dataGridViewRow.Cells[10].Value.ToString();
                        string szCrewKey = dlg.UpdateCreateCrew(jobID);

                        //get crewkey and update each job assigned
                        customerJobTableAdapter.UpdateCrewKey(szCrewKey, Convert.ToInt32(jobID));
                        if (dlg.AssignDate)
                        {
                            customerJobTableAdapter.UpdateJobDate(dlg.selecteddate, Convert.ToInt32(jobID));

                            if (dataGridViewRow.Cells[12].Value.ToString() == "True") //is it fourstep?
                            {
                                //add date to fourstep job
                                if (dataGridViewRow.Cells[24].Value.ToString() == "True") //step 4
                                {
                                    serviceTableAdapter.UpdateStep4DateProp(dlg.selecteddate, Convert.ToInt32(propID));
                                    bRefesh4Step = true;
                                }
                                else if (dataGridViewRow.Cells[23].Value.ToString() == "True") //step 3
                                {
                                    serviceTableAdapter.UpdateStep3DateProp(dlg.selecteddate, Convert.ToInt32(propID));
                                    bRefesh4Step = true;
                                }
                                else if (dataGridViewRow.Cells[22].Value.ToString() == "True") //step 2
                                {
                                    serviceTableAdapter.UpdateStep2DateProp(dlg.selecteddate, Convert.ToInt32(propID));
                                    bRefesh4Step = true;
                                }
                                else if (dataGridViewRow.Cells[21].Value.ToString() == "True") //step 1
                                {
                                    serviceTableAdapter.UpdateStep1DateProp(dlg.selecteddate, Convert.ToInt32(propID));
                                    bRefesh4Step = true;
                                }
                            }

                        }
                        //else
                        //    customerJobTableAdapter.UpdateJobDate(null, Convert.ToInt32(jobID));
                    }
                    crewNameTableAdapter.FillBy(this.mMSDataSet.CrewName, Convert.ToInt32(jobID));
                    if (bRefesh4Step)
                    {
                        MainForm pParent = (MainForm) this.ParentForm;
                        pParent.RefreshServiceFourStepView();
                    }
                    RefreshView();
                    MMSUtility.PlayAcceptSound();
                }
                catch (Exception exe)
                {
                    string message = "JobID =" + jobID + "- PropID" + propID;
                    MMSUtility.LogFile(exe.Message, message, ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                    //MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                }
            }
        }

        private void setJobStatusButton_Click(object sender, EventArgs e)
        {
            string szNewStatus = "Pending";
            string jobID = "0";

            int saveStatus = JobStatusFilterComboBox.SelectedIndex;
            try
            {
                UpdateJobStatusDialog dlg = new UpdateJobStatusDialog();
                if (extendedDataGridView1.RowCount > 0)
                {
                    //set default status for dialog
                    szNewStatus = this.extendedDataGridView1.Rows[0].Cells[9].Value.ToString();
                    dlg.SetStatus(szNewStatus);
                }

                //get the total cost to put up as a default
                double tCost = 0;
                double tMatCost = 0;
                foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                {
                    tCost += Convert.ToDouble(dataGridViewRow.Cells[17].Value.ToString());
                    tMatCost += Convert.ToDouble(dataGridViewRow.Cells[20].Value.ToString());
                }
                dlg.TotalCost = tCost.ToString();
                dlg.TotalMatCost = tMatCost.ToString();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    szNewStatus = dlg.GetStatus();

                    //take cost = totalcost/jobs total manhours=manhours/job, materialscost = materialcost/jobs
                    //add it to each job

                    int numJobs = extendedDataGridView1.SelectedRows.Count;
                    decimal revenue = (decimal) (dlg.GetTotalCost()/numJobs);
                    float manhours = (float) (dlg.GetManHours()/numJobs);
                    decimal materialcost = (decimal) (dlg.GetMaterialCost()/numJobs);

                    foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                    {

                        jobID = dataGridViewRow.Cells[0].Value.ToString();
                        this.custPropertyJobsTableAdapter.UpdateStatusQuery(szNewStatus, manhours, materialcost, revenue,
                            Convert.ToInt32(jobID));

                        if (szNewStatus == "Completed")
                        {
                            //string QBInvoiceID = "";
                            //string QBItemID = "";
                            //UpdateQBInvoice(theInvoice, theItem);
                            //this.custPropertyJobsTableAdapter.UpdateQBQuery(Convert.ToInt32(jobID), QBInvoiceID.ToString(), QBItemID.ToString());
                        }
                    }
                    //-Andy, something wrong with refresh, index out of range, probably becuase of filter

                    RefreshView();

                    JobStatusFilterComboBox.SelectedIndex = saveStatus;
                    JobTypeFilterComboBox_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
            }
        }

        private void JobTypeFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string szJobFilter = "";
            if (JobStatusFilterComboBox.SelectedItem == null) return;

            //job status
            szJobFilter = "Status = '" + JobStatusFilterComboBox.Text + "'";

            //job type
            if (JobTypeFilterComboBox.Text != "All")
                szJobFilter += "AND Type = '" + JobTypeFilterComboBox.Text + "'";

            //dates
            showAllDatesCheckBox.Enabled = true;
            todayFilterCheckBox.Enabled = true;
            fromDateTimePickerFilter.Enabled = true;
            toDateTimePickerFilter.Enabled = true;
            todayFilterCheckBox.Enabled = true;

            if (NoDateCheckBox.Checked)
            {
                todayFilterCheckBox.Enabled = false;
                fromDateTimePickerFilter.Enabled = false;
                toDateTimePickerFilter.Enabled = false;
                todayFilterCheckBox.Enabled = false;
                showAllDatesCheckBox.Enabled = false;

                szJobFilter += " AND Date is NULL";
            }
            else if (showAllDatesCheckBox.Checked == false)
            {
                todayFilterCheckBox.Enabled = true;
                fromDateTimePickerFilter.Enabled = true;
                toDateTimePickerFilter.Enabled = true;

                string dateFilter = GetDateFilterRange();
                if (dateFilter != "")
                    szJobFilter += " AND " + dateFilter;

                if (todayFilterCheckBox.Checked)
                {
                    fromDateTimePickerFilter.Enabled = false;
                    toDateTimePickerFilter.Enabled = false;
                }

            }
            else
            {
                todayFilterCheckBox.Enabled = false;
                fromDateTimePickerFilter.Enabled = false;
                toDateTimePickerFilter.Enabled = false;
            }

            /*
            //routes
            if (routeAllCheckBox.Checked != true)
            {
                routeFilterComboBox.Enabled = true;
                szJobFilter += " AND RouteName = '" + routeFilterComboBox.Text + "'";
                //routeFilter = "AND RouteName = 'No Route'";               
            }
            else
            {
                routeFilterComboBox.Enabled = false;
            }*/
            

            if (FourStepFilterCheckBox.Checked) 
            {
                szJobFilter += " AND FourStepJob = 'True'";

            }
            if (NotInvoiceCheckBox.Checked)
            {
                szJobFilter += " AND QBInvoiceID IS NULL";

            }

            //assign filter
            custPropertyJobsBindingSource.Filter = szJobFilter;
            SetButtonsStatus();
        }

        private string GetDateFilterRange()
        {
            string szFilterRange = "";

            if (todayFilterCheckBox.Checked)
            {
                DateTime fromDT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 1, 0);
                DateTime todTD = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59, 0);
                //szFilterRange = String.Format("Date >= #{0}#", fromDT);
                szFilterRange = String.Format("Date >= '#{0}#' AND Date < '#{1}#'", fromDT, todTD);
            }
            else
            {
                DateTime fromDT = new DateTime(fromDateTimePickerFilter.Value.Year, fromDateTimePickerFilter.Value.Month, fromDateTimePickerFilter.Value.Day, 0, 0, 1, 0);
                DateTime todTD = new DateTime(toDateTimePickerFilter.Value.Year, toDateTimePickerFilter.Value.Month, toDateTimePickerFilter.Value.Day, 23, 59, 59, 0);

                //szFilterRange = String.Format("Date >= '#{0}#' AND Date < '#{1}#'",
                //    fromDateTimePickerFilter.Value, toDateTimePickerFilter.Value);
                szFilterRange = String.Format("Date >= '#{0}#' AND Date < '#{1}#'", fromDT, todTD);

            }

            return szFilterRange;
        }

        private void fromDateTimePickerFilter_ValueChanged(object sender, EventArgs e)
        {
            custPropertyJobsBindingSource.Filter = GetDateFilterRange();
            SetButtonsStatus();

        }
        /*
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
                foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                {
                    propertyID = dataGridViewRow.Cells[13].Value.ToString();
                    if (routeTableAdapter1.GetRouteExist(szRouteName, Convert.ToInt32(propertyID)) == 0)
                        routeTableAdapter1.Insert(Convert.ToInt32(propertyID), nOrderNum, szRouteName, szNotes);
                }
                MainForm pParent = (MainForm)this.ParentForm;
                pParent.RefreshRouteView();
            }
        }*/

        //////////I//////////////////////////////////////////////////////////////////////      
        private void QBInvoiceButton_Click(object sender, EventArgs e)
        {
            int saveStatus = JobStatusFilterComboBox.SelectedIndex;
            MainForm pParent = (MainForm)this.ParentForm;
            double qbCost1 = 0;
            string szList = "";

            try
            {
                if (this.extendedDataGridView1.SelectedCells.Count > 0)
                {
                    string jobID = this.extendedDataGridView1.SelectedCells[0].Value.ToString();
                    string date = this.extendedDataGridView1.SelectedCells[1].Value.ToString();

                    string szCustomerName = lastNameTextBox.Text + ", " + firstNameTextBox.Text;
                    if (firstNameTextBox.Text == "") //for company name, no last name
                    {
                        szCustomerName = lastNameTextBox.Text;
                    }

                    //string szInvoiceQuickbookID = qBInvoiceIDTextBox.Text;

                    if (this.extendedDataGridView1.SelectedRows.Count == 1)
                    {
                        if (date == "")
                        {
                            MessageBox.Show("Job has no date!");
                            return;
                        }
                        DateTime jobDate1 = DateTime.Parse(date);

                        QBInvoiceDialog dlg = new QBInvoiceDialog(szCustomerName, Convert.ToInt32(jobID), QBitems1,
                            QBitems2, QBitems3, QBitems4);
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            if (dlg.bNewInvoiceCreated)
                                pParent.SetStatusLabelTimer(5, "QB New Invoice Created....");
                            else
                                pParent.SetStatusLabelTimer(5, "QB Invoice is Updated....");

                            //use itemid to record jobtype for reminders
                            customerJobTableAdapter.UpdateQBItemCode(dlg.GetSelectedItem, Convert.ToInt32(jobID));
                            customerJobTableAdapter.UpdateQBDescriptionA(dlg.GetSelectedDescription, Convert.ToInt32(jobID));

                        }
                    }
                    else if (this.extendedDataGridView1.SelectedRows.Count > 1)
                    {

                        QBBatchInvoiceDialog dlg = new QBBatchInvoiceDialog(QBitems1);
                        //fill selected list
                        foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                        {
                            if (dataGridViewRow.Cells[17].Value.ToString() != "")
                            {
                                decimal dCost = Convert.ToDecimal(dataGridViewRow.Cells[17].Value.ToString());
                                szList = "Invoice = " + dCost.ToString("C");
                                szList = szList + " --  " + dataGridViewRow.Cells[2].Value.ToString() + ", " +
                                         dataGridViewRow.Cells[3].Value.ToString();
                                szList = szList + " --  " + dataGridViewRow.Cells[6].Value.ToString(); //ADDRESS
                                dlg.AddToListBox(szList);
                            }
                        }

                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            pParent.ProgressBarInit(0, this.extendedDataGridView1.SelectedRows.Count, 1);
                            Cursor.Current = Cursors.WaitCursor;
                            foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                            {
                                jobID = dataGridViewRow.Cells[0].Value.ToString();
                                date = this.extendedDataGridView1.SelectedCells[1].Value.ToString();
                                if (date != "")
                                {

                                    DateTime jobDate1 = DateTime.Parse(date);
                                    szCustomerName = dataGridViewRow.Cells[2].Value.ToString() + ", " + dataGridViewRow.Cells[3].Value.ToString();
                                    //for company name with no first name
                                    if (dataGridViewRow.Cells[3].Value.ToString().Length == 0)
                                    {
                                        szCustomerName = dataGridViewRow.Cells[2].Value.ToString();
                                    }

                                    string QBInvoiceID = dataGridViewRow.Cells[13].Value.ToString();
                                    pParent.SetStatusLabel("QB Invoicing - " + szCustomerName);
                                    pParent.ProgressBarUpdate();

                                    string cost = dataGridViewRow.Cells[17].Value.ToString();
                                    if ((date != null) && (dataGridViewRow.Cells[17].Value.ToString() != ""))
                                    {
                                        qbCost1 = 0;
                                        qbCost1 = Convert.ToDouble(dataGridViewRow.Cells[17].Value.ToString());
                                        var invoiceItem1 = new InvoiceItem()
                                        {
                                            Amount = qbCost1,
                                            QuickBooksID = dataGridViewRow.Cells[13].Value.ToString(),
                                            Date = DateTime.Parse(dataGridViewRow.Cells[1].Value.ToString()),
                                            Description = dlg.DescText1,
                                            Quantity = 1,
                                        };

                                        //append address to description
                                        if (dlg.AppendAddress)
                                        {
                                            invoiceItem1.Description = dlg.DescText1 + " - (" +
                                                                       dataGridViewRow.Cells[6].Value.ToString() + ")";
                                        }

                                        string ItemA_ID = dataGridViewRow.Cells[14].Value.ToString();
                                        QBInvoiceID = dlg.AddModQBInvoice(szCustomerName, QBInvoiceID, invoiceItem1,
                                            jobDate1, ItemA_ID);
                                        if (QBInvoiceID != "")
                                        {
                                            customerJobTableAdapter.UpdateQBData((decimal) qbCost1, 0, 0,
                                                QBInvoiceID, invoiceItem1.QuickBooksID, null, null,
                                                Convert.ToInt32(jobID));

                                            //use itemid to record jobtype for reminders
                                            customerJobTableAdapter.UpdateQBItemCode(dlg.GetSelectedItem, Convert.ToInt32(jobID));
                                            customerJobTableAdapter.UpdateQBDescriptionA(dlg.DescText1, Convert.ToInt32(jobID));                                            

                                        }
                                        System.Threading.Thread.Sleep(1000);



                                    }
                                }

                            }

                            Cursor.Current = Cursors.Default;
                        }
                    }
                    RefreshView();
                    JobStatusFilterComboBox.SelectedIndex = saveStatus;
                    JobTypeFilterComboBox_SelectedIndexChanged(null, null);
                    pParent.SetStatusLabelTimer(5, "QB Updated....");
                }
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
            }
        }
         
        public bool GetQBItems()
        {
            bool sessionBegun = false;
            bool connectionOpen = false;
            QBSessionManager sessionManager = null;

            try
            {
                //Create the session Manager object
                sessionManager = new QBSessionManager();

                //Create the message set request object to hold our request
                IMsgSetRequest requestMsgSet = sessionManager.CreateMsgSetRequest("US", 2, 0);
                requestMsgSet.Attributes.OnError = ENRqOnError.roeContinue;

                sessionManager.OpenConnection(MMSUtility.QBAppID, MMSUtility.QBAppName);
                connectionOpen = true;
                sessionManager.BeginSession("", ENOpenMode.omDontCare);
                sessionBegun = true;

                //Send the request and get the response from QuickBooks
                IItemQuery itemQueryRq = requestMsgSet.AppendItemQueryRq();
                IMsgSetResponse responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                IResponse response = responseMsgSet.ResponseList.GetAt(0);
                IORItemRetList itemRetList = (IORItemRetList)response.Detail;

                if (itemRetList != null)
                {
                    for (int i = 0; i < itemRetList.Count; i++)
                    {

                        IORItemRet itemRet = itemRetList.GetAt(i);
                        if (itemRet.ItemServiceRet != null)
                        {
                            IItemServiceRet itemServiceRet = itemRet.ItemServiceRet;
                            var item = new Item
                            {
                                Name = itemServiceRet.Name.GetValue(),
                                //Description = itemServiceRet.ORSalesPurchase.SalesOrPurchase.Desc.GetValue(),
                                Rate = itemServiceRet.ORSalesPurchase.SalesOrPurchase.ORPrice.Price.GetValue(),
                                ItemType = ItemType.Service,
                                QuickBooksID = itemServiceRet.ListID.GetValue(),
                                EditSequence = itemServiceRet.EditSequence.GetValue()
                            };
                            QBitems1.Add(item);
                            QBitems2.Add(item);
                            QBitems3.Add(item);
                            QBitems4.Add(item);
                        }
                    }
                }           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
            finally
            {
                //End the session and close the connection to QuickBooks
                if (sessionBegun)
                {
                    sessionManager.EndSession();
                }
                if (connectionOpen)
                {
                    sessionManager.CloseConnection();
                }
            }
            return true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearDateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear Dates on Selected Jobs?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow dataGridViewRow in extendedDataGridView1.SelectedRows)
                    {
                        string jobID = dataGridViewRow.Cells[0].Value.ToString();
                        customerJobTableAdapter.UpdateJobDate(null, Convert.ToInt32(jobID));
                    }
                    RefreshView();
                }
                catch (Exception exe)
                {
                    MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ScheduleView");
                }
            }
        }

    }
 }
