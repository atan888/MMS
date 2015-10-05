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
    public partial class VendorView : BaseView
    {
        private int bCancelMode = 0; //0 - edit, 1 - add
        private int nSavedIndex = 0;

        public VendorView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Vendor";
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
                SplashScreen.SetStatus("Loading Vendor Module", false);                
                this.vendorTableAdapter.Fill(this.mMSDataSet.Vendor);
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
                vendorBindingNavigatorSaveItem.Visible = false;

                vendorFilterComboBox.SelectedIndex = 0;
                vendorBindingSource.Filter = "Active > 0";

                System.Threading.Thread.Sleep(300);
                SplashScreen.SetStatus("Load Complete...Starting MMS", false);                

            }
            EnableControl(false);
        }
        
        public override void RefreshView()
        {
            this.vendorTableAdapter.Fill(this.mMSDataSet.Vendor);
            vendorFilterComboBox_SelectedIndexChanged(null, null);
        }
        
        private void EnableControl(bool bEnable)
        {
            //vendorIDTextBox.ReadOnly = true;
            vendorNameTextBox.ReadOnly = !bEnable;
            contactNameTextBox.ReadOnly = !bEnable;
            addressTextBox.ReadOnly = !bEnable;
            cityTextBox.ReadOnly = !bEnable;
            stateTextBox.ReadOnly = !bEnable;
            zipTextBox.ReadOnly = !bEnable;
            phoneNumberTextBox.ReadOnly = !bEnable;
            faxNumberTextBox.ReadOnly = !bEnable;
            emailTextBox.ReadOnly = !bEnable;
            websiteTextBox.ReadOnly = !bEnable;
            notesTextBox.ReadOnly = !bEnable;
            //vendorDataGridView.Enabled = !bEnable;
            vendorFilterComboBox.Enabled = !bEnable;
            //vendorBindingNavigator.Enabled = !bEnable;
            activeCheckB.Enabled = bEnable;
        }
       
        private void addButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            if (addButton.Text == "Add")
            {
                if (this.vendorDataGridView.CurrentRow != null)
                    nSavedIndex = this.vendorDataGridView.CurrentRow.Index;

                EnableControl(true);
                editButton.Enabled = false;
                addButton.Text = "Save";
                archiveButton.Text = "Cancel";
                bCancelMode = 1;
                vendorBindingSource.AddNew();
                addButton.BackColor = System.Drawing.Color.Salmon;
                pParent.enableMainButtons(false);
                vendorDataGridView.Enabled = false;

            }
            else //save
            {
                if (vendorNameTextBox.Text.Length > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    if (this.vendorDataGridView.CurrentRow != null)
                        nSavedIndex = this.vendorDataGridView.CurrentRow.Index;

                    editButton.Enabled = true;
                    addButton.Text = "Add";
                    //archiveButton.Text = "Archive";
                    this.Validate();
                    this.vendorBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.mMSDataSet);
                    EnableControl(false);
                    MMSUtility.PlayAcceptSound();
                    addButton.BackColor = System.Drawing.Color.Transparent;
                    pParent.enableMainButtons(true);
                    vendorDataGridView.Enabled = true;
                    vendorBindingNavigator.Enabled = true;
                    bCancelMode = 0;
                    pParent.SetStatusLabelTimer(5, "Vendor Added....");

                    Cursor.Current = Cursors.Default;

                }
                else
                {
                    MessageBox.Show("Please fill last name field");
                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            nSavedIndex = this.vendorDataGridView.CurrentRow.Index;

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
                this.vendorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMSDataSet);
//Andy need to rebind if user cancels
                EnableControl(false);
                MMSUtility.PlayAcceptSound();
                editButton.BackColor = System.Drawing.Color.Transparent;
                pParent.enableMainButtons(true);
                bCancelMode = 0;

                pParent.SetStatusLabelTimer(5, "Vendor Updated....");
                Cursor.Current = Cursors.Default;

            }

        }
        private void archiveButton_Click(object sender, EventArgs e)
        {           
            if (archiveButton.Text == "Cancel")
            {
                if (bCancelMode == 1)  //in add mode
                {
                    vendorBindingSource.EndEdit();
                    vendorBindingSource.RemoveCurrent();
                }
                else if (bCancelMode == 2) //in edit mode, refill datagrid
                {
                    vendorTableAdapter.ClearBeforeFill = true;
                    this.vendorTableAdapter.Fill(this.mMSDataSet.Vendor);

                }

                if (this.vendorDataGridView.RowCount > 0)
                    this.vendorDataGridView.CurrentCell = this.vendorDataGridView.Rows[nSavedIndex].Cells[1];

                vendorDataGridView.Enabled = true;
                vendorBindingNavigator.Refresh();
                vendorDataGridView.Refresh();
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
                vendorDataGridView.Enabled = true;
                vendorBindingNavigator.Enabled = true;
                bCancelMode = 0;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to archive?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {

                    int index = this.vendorDataGridView.CurrentRow.Index;
                    if (this.vendorDataGridView.RowCount == 1)
                    {
                        this.vendorDataGridView.Rows[index].Cells[10].Value = false;
                        this.vendorDataGridView.CurrentCell = null;
                    }
                    else if (index >= this.vendorDataGridView.RowCount - 1)
                    {

                        this.vendorDataGridView.CurrentCell = this.vendorDataGridView.Rows[index - 1].Cells[1];
                        this.vendorDataGridView.Rows[index].Cells[10].Value = false;
                    }
                    else
                    {
                        this.vendorDataGridView.CurrentCell = this.vendorDataGridView.Rows[index + 1].Cells[1];
                        this.vendorDataGridView.Rows[index].Cells[10].Value = false;
                    }

                    //bindingNavigatorDeleteItem_Click(null, null);
                    //vendorBindingSource.RemoveCurrent();
                    vendorBindingSource.EndEdit();
                    vendorTableAdapter.Update(this.mMSDataSet);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }

        private void vendorFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (vendorFilterComboBox.SelectedItem.ToString())
            {
                case "Active":
                    vendorBindingSource.Filter = "Active > 0";
                    archiveButton.Enabled = true;
                    break;
                case "Archived":
                    vendorBindingSource.Filter = "Active < 1";
                    archiveButton.Enabled = false;
                    break;
                case "All":
                    vendorBindingSource.Filter = "";                    
                    break;
            }           
        }
        public override void Print()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Vendor Listing";
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
                printer.PrintNoDisplay(vendorDataGridView);
            }
        }

        public override void PrintPreview()
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Meriweather Mowing Service";
            printer.SubTitle = "Vendor Listing";
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
                printer.PrintPreviewNoDisplay(vendorDataGridView); 
            }
        }
    }
}
