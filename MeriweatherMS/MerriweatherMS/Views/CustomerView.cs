using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using Interop.QBFC11;
using System.Windows.Forms.MMS.Forms;

namespace System.Windows.Forms.MMS
{

    public partial class CustomerView : BaseView
    {

        private int bCancelMode = 0; //0 - clean, 1 - add cust, 2 - edit cust, 3 - add prop, 4 - edit prop
        private int nSavedIndex = 0;
        
        public CustomerView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                SplashScreen.SetStatus("Loading Customer Module", false);
                this.customerTableAdapter.Fill(this.mMSDataSet.Customer);
                this.propertyTableAdapter.Fill(this.mMSDataSet.Property);
                this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            }
            this.titleStrip1.HeaderText.Text = "Customers";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, System.Drawing.FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;

            toolStripButton1.Visible = false;
            toolStripButton2.Visible = false;
            propertyBindingNavigatorSaveItem.Visible = false;
            customerDataGridView1.ReadOnly = true;
            propertyDataGridView.ReadOnly = true;

            //set filter to show active ones
            //custFilterComboBox.SelectedIndex = 0;
            customerBindingSource.Filter = "Active > 0";
            customerFilterComboBox.SelectedIndex = 0;
            //propertyBindingSource.Filter = "Active > 0 and GroupType = 'Current'";
            propertyBindingSource.Filter = "Active > 0";

            //cancelButton.Hide();
            EnableControls(false);
        }

        public override void RefreshView()
        {
            int nIndex = 0;
            if (this.customerDataGridView1.CurrentRow != null)
                nIndex = this.customerDataGridView1.CurrentRow.Index;

            this.customerTableAdapter.Fill(this.mMSDataSet.Customer);
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            this.propertyTableAdapter.Fill(this.mMSDataSet.Property);

            if (this.customerDataGridView1.RowCount < 0)
                this.customerDataGridView1.CurrentCell = this.customerDataGridView1.Rows[nIndex].Cells[1];

            custFilterComboBox_SelectedIndexChanged(null, null);
        }

        private void addCustButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            if (addCustButton.Text == "Add")
            {
                clearFilter();

                if (this.customerDataGridView1.CurrentRow != null)
                    nSavedIndex = this.customerDataGridView1.CurrentRow.Index;

                EnableControls(true);
                editCustButton.Enabled = false;
                addCustButton.Text = "Save";
                bCancelMode = 1;

                //customerDataGridView1.ReadOnly = false;
                customerDataGridView1.Enabled = false;
                enablePropertyGrid(false);
                filterTextBox.Enabled = false;
                //custFilterComboBox.Enabled = false;
                //customerBindingNavigator.Enabled = false;

                customerBindingSource.AddNew();
                addCustButton.BackColor = System.Drawing.Color.Salmon;
                pParent.enableMainButtons(false);
            }
            else  //save
            {
                if (lastNameTextBox.Text.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    if (this.customerDataGridView1.CurrentRow != null)
                        nSavedIndex = this.customerDataGridView1.CurrentRow.Index;

                    editCustButton.Enabled = true;
                    addCustButton.Text = "Add";

                    this.Validate();
                    this.customerBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                    EnableControls(false);
                    addCustButton.BackColor = System.Drawing.Color.Transparent;
                    MMSUtility.PlayAcceptSound();

                    filterTextBox.Enabled = true;
                    pParent.enableMainButtons(true);
                    //customerDataGridView1.ReadOnly = true;
                    customerDataGridView1.Enabled = true;
                    customerBindingNavigator.Enabled = true;
                    filterTextBox.Enabled = true;
                    enablePropertyGrid(true);
                    bCancelMode = 0;

                    int index = this.customerDataGridView1.CurrentRow.Index;
                    this.customerDataGridView1.Rows[index].Cells[10].Value = "Current";
                    try
                    {
                        //Add property
                        if (addFirstProperty(index))
                        {
                            pParent.SetStatusLabelTimer(5, "Customer and initial property Added....");

                        }
                        else
                        {
                            MessageBox.Show("First Customer Property addition failed!");
                        }
                    }
                    catch (Exception exe)
                    {
                        MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "CustomerView");
                    }

                    //add to QB       
                    if (MMSUtility.UserPref.QBIntegration)
                    {
                        Customer theCustomer = new Customer();
                        theCustomer.FirstName = firstNameTextBox.Text;
                        theCustomer.LastName = lastNameTextBox.Text;
                        theCustomer.Address = addressTextBox.Text;
                        theCustomer.City = cityTextBox.Text;
                        theCustomer.State = stateTextBox.Text;
                        theCustomer.Zip = zipTextBox.Text;
                        theCustomer.Phone = phone1TextBox.Text;
                        theCustomer.Email = emailTextBox.Text;
                        theCustomer.Company = businessNameTextBox.Text;
                        theCustomer.Active = activeCheckBox.Checked;
                        theCustomer.Name = theCustomer.LastName + ", " + theCustomer.FirstName;
                        if (theCustomer.FirstName == "") theCustomer.Name = theCustomer.LastName;
                        try
                        {
                            QBAddCustomer(theCustomer);
                        }
                        catch (Exception exe)
                        {
                            MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "CustomerView");
                        }

                        pParent.SetStatusLabelTimer(5, "QB Updated....");
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Please fill last name field");
                }
            }
            
        }

        private void editCustButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            nSavedIndex = this.customerDataGridView1.CurrentRow.Index;

            if (editCustButton.Text == "Edit")
            {
                EnableControls(true);
                editCustButton.Text = "Save";
                addCustButton.Enabled = false;
                bCancelMode = 2;
                editCustButton.BackColor = System.Drawing.Color.Salmon;
                pParent.enableMainButtons(false);
                tabPage2.Enabled = false;


            }
            else  //save
            {

                Cursor.Current = Cursors.WaitCursor;

                lastNameTextBox.Text = lastNameTextBox.Text.Trim();
                firstNameTextBox.Text = firstNameTextBox.Text.Trim();

                addCustButton.Enabled = true;
                editCustButton.Text = "Edit";
                tabPage2.Enabled = true;                
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);

                EnableControls(false);
                MMSUtility.PlayAcceptSound();
                editCustButton.BackColor = System.Drawing.Color.Transparent;
                pParent.enableMainButtons(true);
                bCancelMode = 0;

                if (MMSUtility.UserPref.QBIntegration)
                {
                    Customer theCustomer = new Customer();
                    theCustomer.FirstName = firstNameTextBox.Text;
                    theCustomer.LastName = lastNameTextBox.Text;
                    if (theCustomer.FirstName.Length > 0)
                        theCustomer.Name = theCustomer.LastName + ", " + theCustomer.FirstName;
                    else
                        theCustomer.Name = theCustomer.LastName;

                    pParent.SetStatusLabelTimer(5, "Customer Updated....");

                    if (QBGetCustomerRecord(theCustomer))
                    {
                        //update info
                        theCustomer.Address = addressTextBox.Text;
                        theCustomer.City = cityTextBox.Text;
                        theCustomer.State = stateTextBox.Text;
                        theCustomer.Zip = zipTextBox.Text;
                        theCustomer.Phone = phone1TextBox.Text;
                        theCustomer.Email = emailTextBox.Text;
                        theCustomer.Company = businessNameTextBox.Text;
                        theCustomer.Active = activeCheckBox.Checked;

                        QBUpdateCustomerRecord(theCustomer);
                        pParent.SetStatusLabelTimer(5, "QB Updated....");
                    }
                    else
                    {
                        string ErroMsg = theCustomer.Name + " - not Found in QuickBooks!!\nPlease Check or press Yes to add to QB";
                        if (MessageBox.Show(ErroMsg, "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            theCustomer.Address = addressTextBox.Text;
                            theCustomer.City = cityTextBox.Text;
                            theCustomer.State = stateTextBox.Text;
                            theCustomer.Zip = zipTextBox.Text;
                            theCustomer.Phone = phone1TextBox.Text;
                            theCustomer.Email = emailTextBox.Text;
                            theCustomer.Company = businessNameTextBox.Text;
                            theCustomer.Active = activeCheckBox.Checked;

                            QBAddCustomer(theCustomer);
                            pParent.SetStatusLabelTimer(5, "QB Updated....");
                      } 
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (bCancelMode == 1) //ADD MODE
            {
                customerBindingSource.EndEdit();
                customerBindingSource.RemoveCurrent();
                this.customerTableAdapter.Fill(this.mMSDataSet.Customer);
            }
            else // edit mode
            {
                customerTableAdapter.ClearBeforeFill = true;
                this.customerTableAdapter.Fill(this.mMSDataSet.Customer);
            }

            customerBindingNavigator.Refresh();
            customerDataGridView1.Refresh();
            editCustButton.Enabled = true;
            addCustButton.Enabled = true;
            editCustButton.Text = "Edit";
            addCustButton.Text = "Add";
            EnableControls(false);
            MainForm pParent = (MainForm)this.ParentForm;
            pParent.enableMainButtons(true);
            addCustButton.BackColor = System.Drawing.Color.Transparent;
            editCustButton.BackColor = System.Drawing.Color.Transparent;
            bCancelMode = 0;
            tabPage1.Enabled = true;
            customerDataGridView1.Enabled = true;
            filterTextBox.Enabled = true;
            enablePropertyGrid(true);

            if (this.customerDataGridView1.RowCount > 0)
                this.customerDataGridView1.CurrentCell = this.customerDataGridView1.Rows[nSavedIndex].Cells[4];


        }

        private void EnableControls(bool bEnable)
        {
            lastNameTextBox.Enabled = bEnable;
            firstNameTextBox.Enabled = bEnable;
            businessNameTextBox.Enabled = bEnable;
            accountNumberTextBox.Enabled = bEnable;            
            addressTextBox.Enabled = bEnable;
            cityTextBox.Enabled = bEnable;
            stateTextBox.Enabled = bEnable;
            zipTextBox.Enabled = bEnable;
            phone1TextBox.Enabled = bEnable;
            phone2TextBox.Enabled = bEnable;
            emailTextBox.Enabled = bEnable;
            activeCheckBox.Enabled = bEnable;
            customerDataGridView1.Enabled = !bEnable;
            filterTextBox.ReadOnly = bEnable;
            customerFilterComboBox.Enabled = !bEnable;

            archiveCustButton.Enabled = !bEnable;
            customerBindingNavigator.Enabled = !bEnable;
            showArchiveCheckBox.Enabled = !bEnable;
            //customerDataGridView1.ReadOnly = bEnable;
            cancelButton.Enabled = bEnable;
        }

        private void archiveCustButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to archive?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int index = this.customerDataGridView1.CurrentRow.Index;
                if (this.customerDataGridView1.RowCount == 1)
                {
                    this.customerDataGridView1.Rows[index].Cells[11].Value = false;
                    this.customerDataGridView1.CurrentCell = null;
                }
                else if (index >= this.customerDataGridView1.RowCount - 1)
                {

                    this.customerDataGridView1.CurrentCell = this.customerDataGridView1.Rows[index - 1].Cells[0];
                    this.customerDataGridView1.Rows[index].Cells[11].Value = false;
                }
                else
                {
                    this.customerDataGridView1.CurrentCell = this.customerDataGridView1.Rows[index + 1].Cells[0];
                    this.customerDataGridView1.Rows[index].Cells[11].Value = false;
                }
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(this.mMSDataSet);
                MMSUtility.PlayAcceptSound();
            }         
        }

        private void addPropButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            if (addPropButton.Text == "Add")
            {
                if (this.propertyDataGridView.CurrentRow != null)
                    nSavedIndex = this.propertyDataGridView.CurrentRow.Index;

                editPropButton.Enabled = false;
                addPropButton.Text = "Save";
                cancelPropButton.Enabled = true; //cancel button
                bCancelMode = 3;
                propertyDataGridView.ReadOnly = false;
                propertyBindingSource.AddNew();
                enableCustomerGrid(false);
                customerFilterComboBox.Enabled = false;
                propertyBindingNavigator.Enabled = false;
                pParent.enableMainButtons(false);
                addPropButton.BackColor = System.Drawing.Color.Salmon;
            }
            else  //save
            {
                int index = this.propertyDataGridView.RowCount - 1; 

                if (propertyDataGridView.Rows[index].Cells[1].Value.ToString().Length > 0) {

                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        if (this.propertyDataGridView.CurrentRow != null)
                            nSavedIndex = this.propertyDataGridView.CurrentRow.Index;

                        editPropButton.Enabled = true;
                        addPropButton.Text = "Add";
                        cancelPropButton.Enabled = false; //cancel button
                        this.Validate();
                        this.propertyBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                        propertyDataGridView.ReadOnly = true;
                        MMSUtility.PlayAcceptSound();
                        enableCustomerGrid(true);
                        customerFilterComboBox.Enabled = true;
                        propertyBindingNavigator.Enabled = true;
                        bCancelMode = 0;
                        pParent.enableMainButtons(true);
                        addPropButton.BackColor = System.Drawing.Color.Transparent;

                        //int index = this.propertyDataGridView.CurrentRow.Index;
                        int propid = Convert.ToInt32(propertyDataGridView.Rows[index].Cells[0].Value);
                        if (serviceTableAdapter.GetServiceExist(propid) == 0)
                            serviceTableAdapter.InsertService(propid, DateTime.Now.ToString());

                        pParent.RefreshServiceView();
                        pParent.RefreshServiceFourStepView();
                        Cursor.Current = Cursors.Default;
                        pParent.SetStatusLabelTimer(5, "Property Added....");
                    }
                    catch (Exception exe)
                    {
                        MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "CustomerView");
                    }
                }
            }
        }

        private bool addFirstProperty(int index)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            bool ret = false;            

            //int index = this.customerDataGridView1.CurrentRow.Index;
            int nCustID = Convert.ToInt32(this.customerDataGridView1.Rows[index].Cells[12].Value.ToString());
            if (nCustID > 0)
            {
                string szDesc = "Property1";
                string szAddress = addressTextBox.Text;
                string szCity = cityTextBox.Text;
                string szState = stateTextBox.Text;
                string szZip = zipTextBox.Text;
                string szPh = phone1TextBox.Text;
                string szSubDiv = "";
                bool bActive = true;
                string szAcctNum = accountNumberTextBox.Text;
                string szGroupType = "InFrequent";
                string szGutterRegion = "";
                int status = propertyTableAdapter.InsertQuery(nCustID, szDesc, szAddress, szCity, szState, szZip, szPh, szSubDiv, bActive, szAcctNum, szGroupType, szGutterRegion);
                if (status == 1)
                {
                    pParent.SetStatusLabelTimer(5, "First Property Added....");
                }
                else
                {
                    pParent.SetStatusLabelTimer(5, "First Property Add Failed!....");
                    MMSUtility.LogFile("Property status failed!", "InsertQuery", "Function addFirstProperty", 455, "CustomerView");
                }

                this.propertyTableAdapter.Fill(this.mMSDataSet.Property);
                propertyDataGridView.Refresh();
                System.Threading.Thread.Sleep(500);

                //insert into service table              
                int propid = Convert.ToInt32(propertyDataGridView.Rows[0].Cells[0].Value);   ///Andy this is failing at times!

                if (serviceTableAdapter.GetServiceExist(propid) == 0)
                {
                    if (serviceTableAdapter.InsertService(propid, DateTime.Now.ToString()) == 1)
                        pParent.SetStatusLabelTimer(5, "First Property Service Added....");
                    ret = true;
                }
                else
                {
                    pParent.SetStatusLabelTimer(5, "First Property Add Failed!....");
                    MMSUtility.LogFile("Property status failed!", "GetServiceExist", "Function addFirstProperty", 472, "CustomerView");
                    ret = false;
                }
             
                pParent.RefreshServiceView();
                pParent.RefreshServiceFourStepView();

                return ret;
            }
            else
            {
                pParent.SetStatusLabelTimer(5, "First Property Add Failed!....");
                MMSUtility.LogFile("Property status failed!", "string", "Function addFirstProperty-nCustID <= 0", 484, "CustomerView");
                return ret;
            }
 
        }

        private void editPropButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            if (this.propertyDataGridView.CurrentRow == null)
                nSavedIndex = 0;
            else
                nSavedIndex = this.propertyDataGridView.CurrentRow.Index;

            if (editPropButton.Text == "Edit")
            {
                //delCustButton.Enabled = false;
                addPropButton.Enabled = false;
                editPropButton.Text = "Save";
                cancelPropButton.Enabled = true;  //cancel button
                bCancelMode = 4;
                propertyDataGridView.ReadOnly = false;
                enableCustomerGrid(false);
                customerFilterComboBox.Enabled = false;
                filterTextBox.Enabled = false;
                showArchiveCheckBox.Enabled = false;
                tabPage1.Enabled = false;
                pParent.enableMainButtons(false);                
                editPropButton.BackColor = System.Drawing.Color.Salmon;

            }
            else  //save
            {
                Cursor.Current = Cursors.WaitCursor;

                cancelPropButton.Enabled = true;
                addPropButton.Enabled = true;
                editPropButton.Text = "Edit";
                cancelPropButton.Enabled = false;  //cancel button                
                this.Validate();
                this.propertyDataGridView.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                propertyDataGridView.ReadOnly = true;
                MMSUtility.PlayAcceptSound();
                enableCustomerGrid(true);
                tabPage1.Enabled = true;
                filterTextBox.Enabled = true;
                showArchiveCheckBox.Enabled = true;
                customerFilterComboBox.Enabled = true;
                bCancelMode = 0;
                pParent.enableMainButtons(true);                
                editPropButton.BackColor = System.Drawing.Color.Transparent;
                pParent.RefreshServiceView();
                pParent.RefreshServiceFourStepView();
                pParent.SetStatusLabelTimer(5, "Property Updated....");

                Cursor.Current = Cursors.Default;


            }
        }

        private void cancelPropButton_Click(object sender, EventArgs e)
        {
            if (cancelPropButton.Text == "Cancel")
            {
                if (bCancelMode == 3)  //in add mode
                {
                    propertyBindingSource.EndEdit();
                    propertyBindingSource.RemoveCurrent();
                }
                else if (bCancelMode == 4)  //in edit mode, refill datagrid
                {
                    propertyTableAdapter.ClearBeforeFill = true;
                    this.propertyTableAdapter.Fill(this.mMSDataSet.Property);
                }

                if (this.propertyDataGridView.RowCount > 0)
                    this.propertyDataGridView.CurrentCell = this.propertyDataGridView.Rows[nSavedIndex].Cells[0]; //set to address

                propertyBindingNavigator.Refresh();
                propertyDataGridView.Refresh();
                editPropButton.Enabled = true;
                addPropButton.Enabled = true;
                addPropButton.Text = "Add";
                editPropButton.Text = "Edit";
                propertyDataGridView.ReadOnly = true;
                enableCustomerGrid(true);
                customerFilterComboBox.Enabled = true;
                propertyBindingNavigator.Enabled = true;
                tabPage1.Enabled = true;
                filterTextBox.Enabled = true;
                showArchiveCheckBox.Enabled = true;
                customerFilterComboBox.Enabled = true;
                bCancelMode = 0;
            }
            cancelPropButton.Enabled = false;  //cancel button 
            MainForm pParent = (MainForm)this.ParentForm;
            pParent.enableMainButtons(true);
            addPropButton.BackColor = System.Drawing.Color.Transparent;
            editPropButton.BackColor = System.Drawing.Color.Transparent;
        }

        private void custFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (customerFilterComboBox.SelectedItem.ToString())
            {
                case "Active":
                    customerBindingSource.Filter = "Active > 0";
                    break;
                case "Archived":
                    customerBindingSource.Filter = "Active < 1";
                    break;
                case "All":
                    customerBindingSource.Filter = "";
                    break;
            }

            
        }

        private void enableCustomerGrid(bool bEnable)
        {
            customerDataGridView1.Enabled = bEnable;
            editCustButton.Enabled = bEnable;
            addCustButton.Enabled = bEnable;
            archiveCustButton.Enabled = bEnable;
            customerBindingNavigator.Enabled = bEnable;
        }
        private void enablePropertyGrid(bool bEnable)
        {
            propertyDataGridView.Enabled = bEnable;
            editPropButton.Enabled = bEnable;
            addPropButton.Enabled = bEnable;
            cancelPropButton.Enabled = bEnable;
            customerFilterComboBox.Enabled = bEnable;
            propertyBindingNavigator.Enabled = bEnable;
        }

        private void customerDataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //check if the current cell is dirty.    
            if (customerDataGridView1.IsCurrentCellDirty)
            {
                int nval = 0;
                //check for the column name and do a double.TryParse        
                if (((customerDataGridView1.Columns[e.ColumnIndex].Name == "Zip") ||
                    (customerDataGridView1.Columns[e.ColumnIndex].Name == "Phone1") ||
                    (customerDataGridView1.Columns[e.ColumnIndex].Name == "Phone2"))
                    && (!int.TryParse(e.FormattedValue.ToString(), out nval)))
                {
                    //not a double value. Tell the user.                
                    customerDataGridView1[e.ColumnIndex, e.RowIndex].Value = 0;
                    MessageBox.Show("Please enter numeric values");
                    e.Cancel = true;
                }
            }

        }

        private void customerDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //    int RowIndex = e.RowIndex;
            //    int columnIndex = e.ColumnIndex;

            //    if (e.ColumnIndex > 5)&&(e.ColumnIndex <8))
            //    {
            //        bool validation = true;
            //        if (customerDataGridView1.Rows[RowIndex].Cells[columnIndex].Value != null && customerDataGridView1.Rows[RowIndex].Cells[columnIndex].Value.ToString().Trim() != "")
            //        {
            //            string DataToValidate = customerDataGridView1.Rows[RowIndex].Cells[columnIndex].Value.ToString()
            //            foreach (char c in DataToValidate)
            //            {
            //                if (!char.IsDigit(c))
            //                {
            //                    validation = false;
            //                    break;
            //                }
            //            }
            //            if (validation == false)
            //            {
            //                customerDataGridView1.Rows[RowIndex].Cells[columnIndex].ErrorText = "You Can Only Enter Number here ";
            //                customerDataGridView1.Rows[RowIndex].Cells[columnIndex].Value = "";
            //            }
            //        }
            //    }
        }

        private void propertyDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //check if the current cell is dirty.    
            if (propertyDataGridView.IsCurrentCellDirty)
            {
                int nval = 0;
                //check for the column name and do a double.TryParse        
                if (((propertyDataGridView.Columns[e.ColumnIndex].Name == "Zip") ||
                    (propertyDataGridView.Columns[e.ColumnIndex].Name == "Phone1"))
                    && (!int.TryParse(e.FormattedValue.ToString(), out nval)))
                {
                    //not a double value. Tell the user.                
                    propertyDataGridView[e.ColumnIndex, e.RowIndex].Value = 0;
                    MessageBox.Show("Please enter numeric values");
                    e.Cancel = true;
                }
            }

        }

        public override void PageSetup()
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();

                PageSetupDialog1.Document = printer.printDocument;
                if (null != MMSUtility.myPageSettings)
                    PageSetupDialog1.PageSettings = MMSUtility.myPageSettings;

                if (PageSetupDialog1.ShowDialog() == DialogResult.OK)
                {
                    MMSUtility.myPageSettings = PageSetupDialog1.PageSettings;
                }
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, "", "PageSetup", exe.LineNumber(), "CustomerView");
                MessageBox.Show(exe.Message.ToString(), "Error");
            }
        }

        public override void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Customer Listing";
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
                printer.PrintNoDisplay(customerDataGridView1);
            }
        }

        public override void PrintPreview()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Customer Listing";
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
                printer.PrintPreviewNoDisplay(customerDataGridView1);
            }
        }

        private void assignTypeButton_Click(object sender, EventArgs e)
        {
            string szNewType = "";
            string custID = "";

            AssignCustomerTypeDialog dlg = new AssignCustomerTypeDialog();

            if (customerDataGridView1.RowCount > 0)
            {
                //set default status for dialog
                int index = this.customerDataGridView1.CurrentRow.Index;
                szNewType = this.customerDataGridView1.Rows[index].Cells[10].Value.ToString();
                dlg.SetType(szNewType);
            }

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                szNewType = dlg.GetAssignType();
                foreach (DataGridViewRow dataGridViewRow in customerDataGridView1.SelectedRows)
                {
                    custID = dataGridViewRow.Cells[12].Value.ToString();
                    this.customerTableAdapter.UpdateGroupType(szNewType, Convert.ToInt32(custID));
                }
                RefreshView();
            }
        }

        private void showArchiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showArchiveCheckBox.Checked)
                propertyBindingSource.Filter = "";
            else
                propertyBindingSource.Filter = "Active > 0";
        }

        private void clearFilter()
        {
            filterTextBox.Text = "";
            filterTextBox_TextChanged(null, null);
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            string szFilter = "";
            switch (customerFilterComboBox.SelectedItem.ToString())
            {
                case "Active":
                    szFilter = "Active > 0 AND ";
                    break;
                case "Archived":
                    szFilter = "Active < 1 AND ";
                    break;
                case "All":
                    szFilter = "";
                    break;
            }

            szFilter = szFilter + "LastName Like '" + filterTextBox.Text + "%'";
            customerBindingSource.Filter = szFilter;            

        }

        private void QBAddCustomer(Customer theCustomer)
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

                ICustomerAdd customerAddRq = requestMsgSet.AppendCustomerAddRq();
                customerAddRq.Name.SetValue(theCustomer.Name);
                customerAddRq.FirstName.SetValue(theCustomer.FirstName);
                customerAddRq.LastName.SetValue(theCustomer.LastName);

                string szName = theCustomer.FirstName + " " + theCustomer.LastName;
                customerAddRq.BillAddress.Addr1.SetValue(szName);
                customerAddRq.BillAddress.Addr2.SetValue(theCustomer.Address);
                customerAddRq.BillAddress.City.SetValue(theCustomer.City);
                customerAddRq.BillAddress.State.SetValue(theCustomer.State);
                customerAddRq.BillAddress.PostalCode.SetValue(theCustomer.Zip);
                customerAddRq.Phone.SetValue(theCustomer.Phone);
                customerAddRq.Email.SetValue(theCustomer.Email);
                customerAddRq.CompanyName.SetValue(theCustomer.Company);
                customerAddRq.IsActive.SetValue(theCustomer.Active);
                customerAddRq.TermsRef.FullName.SetValue(theCustomer.Terms);

                //Send the request and get the response from QuickBooks
                IMsgSetResponse responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                IResponse response = responseMsgSet.ResponseList.GetAt(0);
                ICustomerRet customerRet = (ICustomerRet)response.Detail;
                theCustomer.QuickBooksID = customerRet.ListID.GetValue();
            }
            catch (Exception exe)
            {
                string theName = theCustomer.LastName + "," + theCustomer.FirstName
                    + "," + theCustomer.Address + ",C:" + theCustomer.City + ",S:" + theCustomer.State + "'Z:" + theCustomer.Zip
                    + ",P" + theCustomer.Phone + ",E" + theCustomer.Email + ",A" + theCustomer.Active + ",T" + theCustomer.Terms;
                MMSUtility.LogFile(exe.Message, theName, "QBAddCustomer", exe.LineNumber(), "CustomerView");
                MessageBox.Show(exe.Message, "Error");
                
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
        }

        private bool QBGetCustomerRecord(Customer theCustomer)
        {
            bool sessionBegun = false;
            bool connectionOpen = false;
            QBSessionManager sessionManager = null;
            bool nFound = false;

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

                //find the customer info
                ICustomerQuery search = requestMsgSet.AppendCustomerQueryRq();
                search.ORCustomerListQuery.CustomerListFilter.ORNameFilter.NameFilter.MatchCriterion.SetValue(ENMatchCriterion.mcStartsWith);
                search.ORCustomerListQuery.CustomerListFilter.ORNameFilter.NameFilter.Name.SetValue(theCustomer.Name);

                IMsgSetResponse responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                IResponse response = responseMsgSet.ResponseList.GetAt(0);
                ICustomerRetList customerRetList = (ICustomerRetList)response.Detail;
                if (customerRetList != null)
                {
                    ICustomerRet customerRet = customerRetList.GetAt(0);
                    if (customerRet.ListID != null) theCustomer.QuickBooksID = customerRet.ListID.GetValue();
                    if (customerRet.EditSequence != null) theCustomer.EditSequence = customerRet.EditSequence.GetValue();
                    if (customerRet.FirstName != null) theCustomer.FirstName = customerRet.FirstName.GetValue();
                    if (customerRet.LastName != null) theCustomer.LastName = customerRet.LastName.GetValue();
                    if (customerRet.BillAddress != null)
                    {
                        if (customerRet.BillAddress.Addr1 != null) theCustomer.Address = customerRet.BillAddress.Addr1.GetValue();
                        if (customerRet.BillAddress.City != null) theCustomer.City = customerRet.BillAddress.City.GetValue();
                        if (customerRet.BillAddress.State != null) theCustomer.State = customerRet.BillAddress.State.GetValue();
                        if (customerRet.BillAddress.PostalCode != null) theCustomer.Zip = customerRet.BillAddress.PostalCode.GetValue();
                    }
                    if (customerRet.Phone != null) theCustomer.Phone = customerRet.Phone.GetValue();
                    if (customerRet.Email != null) theCustomer.Email = customerRet.Email.GetValue();
                    if (customerRet.CompanyName != null) theCustomer.Company = customerRet.CompanyName.GetValue();
                    if (customerRet.IsActive != null) theCustomer.Active = customerRet.IsActive.GetValue();
                    if (customerRet.TermsRef != null) theCustomer.Terms = customerRet.TermsRef.FullName.GetValue();
                    nFound = true;
                }
                else
                {
                    nFound = false;
                }
            }
            catch (Exception exe)
            {
                string thename = theCustomer.FirstName + " " + theCustomer.LastName;
                MMSUtility.LogFile(exe.Message, thename, "QBGetCustomerRecord", exe.LineNumber(), "CustomerView");
                MessageBox.Show(exe.Message, "Error");             
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
            return nFound;
        }
        
        private void QBUpdateCustomerRecord(Customer theCustomer)
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

                //modify the info
                ICustomerMod customerModRq = requestMsgSet.AppendCustomerModRq();
                //if (theCustomer.FirstName.Length > 0) 
                customerModRq.Name.SetValue(theCustomer.Name);
                //if (theCustomer.FirstName.Length > 0) 
                customerModRq.FirstName.SetValue(theCustomer.FirstName);
                //if (theCustomer.LastName.Length > 0) 
                customerModRq.LastName.SetValue(theCustomer.LastName);
                //if (theCustomer.Address.Length > 0) 
                string szName = theCustomer.FirstName + " " + theCustomer.LastName;
                customerModRq.BillAddress.Addr1.SetValue(szName);
                customerModRq.BillAddress.Addr2.SetValue(theCustomer.Address);
                //if (theCustomer.City.Length > 0) 
                customerModRq.BillAddress.City.SetValue(theCustomer.City);
                //if (theCustomer.State.Length > 0) 
                customerModRq.BillAddress.State.SetValue(theCustomer.State);
                //if (theCustomer.Zip.Length > 0) 
                customerModRq.BillAddress.PostalCode.SetValue(theCustomer.Zip);
                //if (theCustomer.Phone.Length > 0) 
                customerModRq.Phone.SetValue(theCustomer.Phone);
                //if (theCustomer.Email.Length > 0) 
                customerModRq.Email.SetValue(theCustomer.Email);
                //if (theCustomer.Company.Length > 0) 
                customerModRq.CompanyName.SetValue(theCustomer.Company);
                //if (theCustomer.Terms.Length > 0) customerModRq.TermsRef.FullName.SetValue(theCustomer.Terms);
                customerModRq.ListID.SetValue(theCustomer.QuickBooksID);
                customerModRq.EditSequence.SetValue(theCustomer.EditSequence);
                //customerModRq.IsActive.SetValue(true);                
                 
                //Send the request to QuickBooks
                IMsgSetResponse responsMsgSet = sessionManager.DoRequests(requestMsgSet);
            }
            catch (Exception exe)
            {
                MMSUtility.LogFile(exe.Message, "", "QBUpdateCustomerRecord", exe.LineNumber(), "CustomerView");
                MessageBox.Show(exe.Message, "Error: Failed to Update");
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
        }

        private void customerDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            editCustButton.Enabled = true;
            if (customerDataGridView1.SelectedRows.Count > 1)
            {
                editCustButton.Enabled = false;
            }

        }
    }
}
