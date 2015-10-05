using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace System.Windows.Forms.MMS.Views
{
    public partial class EmployeeView : BaseView
    {
        private int bCancelMode = 0; //0 - edit, 1 - add
        private int nSavedIndex = 0; 

        public EmployeeView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Employees";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;

        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                SplashScreen.SetStatus("Loading Employee Module", false);
                this.employeeTableAdapter.Fill(this.mMSDataSet.Employee);
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                employeeBindingNavigatorSaveItem.Visible = false;
            }
            ActiveCheckBox.Checked = true;
            EnableControl(false);
        }

        public override void RefreshView()
        {
            this.employeeTableAdapter.Fill(this.mMSDataSet.Employee);
            ActiveCheckBox_CheckedChanged(null, null);

        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            if (addButton.Text == "Add")
            {
                if (this.employeeDataGridView.CurrentRow != null)
                    nSavedIndex = this.employeeDataGridView.CurrentRow.Index;

                EnableControl(true);
                editButton.Enabled = false;
                addButton.Text = "Save";
                archiveButton.Text = "Cancel";
                bCancelMode = 1;
                employeeDataGridView.Enabled = false;
                employeeBindingNavigator.Enabled = false;
                employeeBindingSource.AddNew();
                addButton.BackColor = System.Drawing.Color.Salmon;
                pParent.enableMainButtons(false);
            }
            else
            {
                if (lastNameTextBox.Text.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {                       
                        if (this.employeeDataGridView.CurrentRow != null)
                            nSavedIndex = this.employeeDataGridView.CurrentRow.Index;

                        editButton.Enabled = true;
                        addButton.Text = "Add";
                        archiveButton.Text = "Archive";
                        this.Validate();
                        this.employeeBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                        EnableControl(false);
                        MMSUtility.PlayAcceptSound();
                        addButton.BackColor = System.Drawing.Color.Transparent;
                        pParent.enableMainButtons(true);
                        employeeDataGridView.Enabled = true;
                        employeeBindingNavigator.Enabled = true;
                        bCancelMode = 0;

                        pParent.SetStatusLabelTimer(5, "Employee Added....");
                     
                    }
                    catch (Exception exe)
                    {
                        MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "EmployeeView");
                    }
                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Please fill in the last name field");
                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            nSavedIndex = this.employeeDataGridView.CurrentRow.Index;

            if (editButton.Text == "Edit")
            {
                EnableControl(true);
                addButton.Enabled = false;
                editButton.Text = "Save";
                archiveButton.Text = "Cancel";
                bCancelMode = 2;
                editButton.BackColor = System.Drawing.Color.Salmon;
                pParent.enableMainButtons(false);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                archiveButton.Enabled = true;
                addButton.Enabled = true;
                editButton.Text = "Edit";
                archiveButton.Text = "Archive";
                this.Validate();
                this.employeeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                //Andy need to rebind if user cancels
                EnableControl(false);
                MMSUtility.PlayAcceptSound();
                editButton.BackColor = System.Drawing.Color.Transparent;
                pParent.enableMainButtons(true);
                bCancelMode = 0;
                pParent.SetStatusLabelTimer(5, "Employee Updated....");

                Cursor.Current = Cursors.Default;

            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            if (archiveButton.Text == "Cancel")
            {
                if (bCancelMode == 1)  //in add mode
                {
                    employeeBindingSource.EndEdit();
                    employeeBindingSource.RemoveCurrent();
                }
                else if (bCancelMode == 2) //in edit mode, refill datagrid
                {
                    employeeTableAdapter.ClearBeforeFill = true;
                    this.employeeTableAdapter.Fill(this.mMSDataSet.Employee);

                }

                if (this.employeeDataGridView.RowCount > 0)
                    this.employeeDataGridView.CurrentCell = this.employeeDataGridView.Rows[nSavedIndex].Cells[1];                    

                employeeBindingNavigator.Refresh();
                employeeDataGridView.Refresh();
                editButton.Enabled = true;
                addButton.Enabled = true;
                archiveButton.Text = "Archive";
                addButton.Text = "Add";
                editButton.Text = "Edit";
                EnableControl(false);
                MainForm pParent = (MainForm)this.ParentForm;
                pParent.enableMainButtons(true);
                addButton.BackColor = System.Drawing.Color.Transparent;
                editButton.BackColor = System.Drawing.Color.Transparent;
                employeeDataGridView.Enabled = true;
                employeeBindingNavigator.Enabled = true;
                bCancelMode = 0;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to archive?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int index = this.employeeDataGridView.CurrentRow.Index;
                    if (this.employeeDataGridView.RowCount == 1)
                    {
                        this.employeeDataGridView.Rows[index].Cells[9].Value = false;
                        this.employeeDataGridView.CurrentCell = null;
                    }
                    else if (index >= this.employeeDataGridView.RowCount - 1)
                    {

                        this.employeeDataGridView.CurrentCell = this.employeeDataGridView.Rows[index - 1].Cells[1];
                        this.employeeDataGridView.Rows[index].Cells[9].Value = false;
                    }
                    else
                    {
                        this.employeeDataGridView.CurrentCell = this.employeeDataGridView.Rows[index + 1].Cells[1];
                        this.employeeDataGridView.Rows[index].Cells[9].Value = false;                        
                    }


                    //bindingNavigatorDeleteItem_Click(null, null);
                    //employeeBindingSource.RemoveCurrent();
                    employeeBindingSource.EndEdit();
                    employeeTableAdapter.Update(this.mMSDataSet);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }
        private void EnableControl(bool bEnable)
        {
            //employeeIDTextBox.ReadOnly = true;
            firstNameTextBox.ReadOnly = !bEnable;
            lastNameTextBox.ReadOnly = !bEnable;

            addressTextBox.ReadOnly = !bEnable;
            cityTextBox.ReadOnly = !bEnable;
            stateTextBox.ReadOnly = !bEnable;
            zipTextBox.ReadOnly = !bEnable;
            phone1TextBox.ReadOnly = !bEnable;
            phone2TextBox.ReadOnly = !bEnable;
            notesTextBox.ReadOnly = !bEnable;
            contractorCheckBox.Enabled = bEnable;
            activeCheckB.Enabled = bEnable;
        }

        private void ActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string szFilter = "Contractor < 1 and ";
            if (contractorCheckBox.Checked)
            {
                szFilter = "Contractor > 0 and ";
            }

            if (ActiveCheckBox.Checked)
            {
                szFilter += "Active > 0";
                //employeeBindingSource.Filter = "Active > 0";
                employeeBindingSource.Filter = szFilter;
                archiveButton.Enabled = true;
            }
            else
            {
                szFilter += "Active < 1";
                //employeeBindingSource.Filter = "Active < 1";
                employeeBindingSource.Filter = szFilter;
                archiveButton.Enabled = false;
            }

        }

        private void ContractorFilter_CheckedChanged(object sender, EventArgs e)
        {
            string szFilter = "Active < 1 and ";
            if (ActiveCheckBox.Checked)
            {
                szFilter = "Active > 0 and ";
            }

            if (ContractorFilter.Checked)
                szFilter += "Contractor > 0";
            else
                szFilter += "Contractor < 1";
            employeeBindingSource.Filter = szFilter;
                //employeeBindingSource.Filter = "Contractor > 0";            
                //employeeBindingSource.Filter = "Contractor < 1";
        }

        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(zipTextBox.Text);
                //if (numberEntered < 1 || numberEntered > 10)
                //{
                //    e.Cancel = true;
                //    MessageBox.Show("You have to enter a number between 1 and 10");
                //}
            }
            catch (FormatException)
            {
                e.Cancel = true;
                MessageBox.Show("You need to enter an integer");
            }

        }
        public override void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Employee Listing";
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
                printer.PrintNoDisplay(employeeDataGridView);
            }
        }

        public override void PrintPreview()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Employee Listing";
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
                printer.PrintPreviewNoDisplay(employeeDataGridView);
            }
        }

        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            if (employeeDataGridView.SelectedRows.Count > 1)
            {
                editButton.Enabled = false;
            }        
        }

    }
}
