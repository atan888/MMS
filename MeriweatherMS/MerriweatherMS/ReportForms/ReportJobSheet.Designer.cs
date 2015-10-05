namespace System.Windows.Forms.MMS
{
    partial class PrintSheetsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintSheetsDialog));
            this.CloseButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportListBox = new System.Windows.Forms.ListBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.custPropertyJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.custPropertyJobsTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter();
            this.vendorTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.VendorTableAdapter();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(1056, 557);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FilterComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ReportListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1124, 527);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Report Type:";
            // 
            // ReportListBox
            // 
            this.ReportListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportListBox.FormattingEnabled = true;
            this.ReportListBox.Items.AddRange(new object[] {
            "Instruction Sheet",
            "Revenue Sheet",
            "Contractor Pay Sheet"});
            this.ReportListBox.Location = new System.Drawing.Point(15, 88);
            this.ReportListBox.Name = "ReportListBox";
            this.ReportListBox.Size = new System.Drawing.Size(139, 420);
            this.ReportListBox.TabIndex = 5;
            this.ReportListBox.SelectedValueChanged += new System.EventHandler(this.ReportListBox_SelectedValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(953, 527);
            this.reportViewer1.TabIndex = 0;
            // 
            // custPropertyJobsBindingSource
            // 
            this.custPropertyJobsBindingSource.DataMember = "CustPropertyJobs";
            this.custPropertyJobsBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custPropertyJobsTableAdapter
            // 
            this.custPropertyJobsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.mMSDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sort by Route:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.CausesValidation = false;
            this.FilterComboBox.DataSource = this.routeListBindingSource;
            this.FilterComboBox.DisplayMember = "RouteName";
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(15, 29);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(138, 21);
            this.FilterComboBox.TabIndex = 66;
            this.FilterComboBox.ValueMember = "RouteName";
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataMember = "RouteList";
            this.routeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // routeListTableAdapter
            // 
            this.routeListTableAdapter.ClearBeforeFill = true;
            // 
            // PrintSheetsDialog
            // 
            this.AcceptButton = this.CloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(1148, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintSheetsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Mow List Dialog";
            this.Load += new System.EventHandler(this.PrintSheetsDialog_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CloseButton;
        private SplitContainer splitContainer1;
        private ListBox ReportListBox;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource custPropertyJobsBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter custPropertyJobsTableAdapter;
        private Label label2;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private BindingSource vendorBindingSource;
        private Label label1;
        private ComboBox FilterComboBox;
        private BindingSource routeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter routeListTableAdapter;
    }
}