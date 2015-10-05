namespace System.Windows.Forms.MMS
{
    partial class PrintLetterDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintLetterDialog));
            this.OKButton = new System.Windows.Forms.Button();
            this.customerTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.AllCountLabel = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtCSVFolderPath = new System.Windows.Forms.TextBox();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.btnOpenFldrBwsr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFormats = new System.Windows.Forms.ComboBox();
            this.txtCSVFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFileDlg = new System.Windows.Forms.Button();
            this.cbColNameHeader = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.dGridCSVdata = new System.Windows.Forms.DataGrid();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.customerTypeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.letterDataTableTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.LetterDataTableTableAdapter();
            this.fbdCSVFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogCSVFilePath = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCSVdata)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(515, 304);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(99, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "Close";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // customerTypeListBindingSource
            // 
            this.customerTypeListBindingSource.DataMember = "CustomerTypeList";
            this.customerTypeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFilePath);
            this.groupBox1.Controls.Add(this.AllCountLabel);
            this.groupBox1.Controls.Add(this.lblFolderPath);
            this.groupBox1.Controls.Add(this.txtCSVFolderPath);
            this.groupBox1.Controls.Add(this.txtDelimiter);
            this.groupBox1.Controls.Add(this.btnOpenFldrBwsr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFormats);
            this.groupBox1.Controls.Add(this.txtCSVFilePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOpenFileDlg);
            this.groupBox1.Controls.Add(this.cbColNameHeader);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.dGridCSVdata);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 286);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Customers: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "FORMAT: First Name, Last Name, Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilePath
            // 
            this.lblFilePath.Location = new System.Drawing.Point(12, 83);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(72, 20);
            this.lblFilePath.TabIndex = 12;
            this.lblFilePath.Text = "File Path:";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AllCountLabel
            // 
            this.AllCountLabel.AutoSize = true;
            this.AllCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCountLabel.Location = new System.Drawing.Point(133, 22);
            this.AllCountLabel.Name = "AllCountLabel";
            this.AllCountLabel.Size = new System.Drawing.Size(14, 13);
            this.AllCountLabel.TabIndex = 24;
            this.AllCountLabel.Text = "0";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.Location = new System.Drawing.Point(12, 59);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(72, 20);
            this.lblFolderPath.TabIndex = 11;
            this.lblFolderPath.Text = "Folder Path:";
            this.lblFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCSVFolderPath
            // 
            this.txtCSVFolderPath.BackColor = System.Drawing.SystemColors.Info;
            this.txtCSVFolderPath.Location = new System.Drawing.Point(92, 60);
            this.txtCSVFolderPath.Name = "txtCSVFolderPath";
            this.txtCSVFolderPath.ReadOnly = true;
            this.txtCSVFolderPath.Size = new System.Drawing.Size(179, 20);
            this.txtCSVFolderPath.TabIndex = 1;
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDelimiter.Enabled = false;
            this.txtDelimiter.Location = new System.Drawing.Point(271, 159);
            this.txtDelimiter.MaxLength = 1;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(24, 20);
            this.txtDelimiter.TabIndex = 10;
            // 
            // btnOpenFldrBwsr
            // 
            this.btnOpenFldrBwsr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFldrBwsr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFldrBwsr.Location = new System.Drawing.Point(277, 60);
            this.btnOpenFldrBwsr.Name = "btnOpenFldrBwsr";
            this.btnOpenFldrBwsr.Size = new System.Drawing.Size(24, 23);
            this.btnOpenFldrBwsr.TabIndex = 1;
            this.btnOpenFldrBwsr.Text = "...";
            this.btnOpenFldrBwsr.Click += new System.EventHandler(this.btnOpenFldrBwsr_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(207, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delimiter:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFormats
            // 
            this.cmbFormats.BackColor = System.Drawing.SystemColors.Info;
            this.cmbFormats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormats.Items.AddRange(new object[] {
            "CSV Delimited",
            "Tab Delimited",
            "Custom Delimited"});
            this.cmbFormats.Location = new System.Drawing.Point(71, 159);
            this.cmbFormats.Name = "cmbFormats";
            this.cmbFormats.Size = new System.Drawing.Size(121, 21);
            this.cmbFormats.TabIndex = 8;
            this.cmbFormats.SelectionChangeCommitted += new System.EventHandler(this.cmbFormats_SelectionChangeCommitted);
            // 
            // txtCSVFilePath
            // 
            this.txtCSVFilePath.BackColor = System.Drawing.SystemColors.Info;
            this.txtCSVFilePath.Location = new System.Drawing.Point(92, 84);
            this.txtCSVFilePath.Name = "txtCSVFilePath";
            this.txtCSVFilePath.ReadOnly = true;
            this.txtCSVFilePath.Size = new System.Drawing.Size(179, 20);
            this.txtCSVFilePath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Format:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpenFileDlg
            // 
            this.btnOpenFileDlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFileDlg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenFileDlg.Location = new System.Drawing.Point(277, 83);
            this.btnOpenFileDlg.Name = "btnOpenFileDlg";
            this.btnOpenFileDlg.Size = new System.Drawing.Size(24, 23);
            this.btnOpenFileDlg.TabIndex = 3;
            this.btnOpenFileDlg.Tag = "";
            this.btnOpenFileDlg.Text = "...";
            this.btnOpenFileDlg.Click += new System.EventHandler(this.btnOpenFileDlg_Click);
            // 
            // cbColNameHeader
            // 
            this.cbColNameHeader.Checked = true;
            this.cbColNameHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbColNameHeader.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbColNameHeader.Location = new System.Drawing.Point(15, 127);
            this.cbColNameHeader.Name = "cbColNameHeader";
            this.cbColNameHeader.Size = new System.Drawing.Size(240, 24);
            this.cbColNameHeader.TabIndex = 6;
            this.cbColNameHeader.Text = "Column Name Header";
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImport.Location = new System.Drawing.Point(21, 229);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(280, 41);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import CSV Data";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dGridCSVdata
            // 
            this.dGridCSVdata.AllowSorting = false;
            this.dGridCSVdata.AlternatingBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dGridCSVdata.CaptionText = "Imported Sorted CSV";
            this.dGridCSVdata.ColumnHeadersVisible = false;
            this.dGridCSVdata.DataMember = "";
            this.dGridCSVdata.HeaderBackColor = System.Drawing.Color.Black;
            this.dGridCSVdata.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGridCSVdata.Location = new System.Drawing.Point(325, 42);
            this.dGridCSVdata.Name = "dGridCSVdata";
            this.dGridCSVdata.ReadOnly = true;
            this.dGridCSVdata.Size = new System.Drawing.Size(263, 228);
            this.dGridCSVdata.TabIndex = 5;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // customerTypeListTableAdapter
            // 
            this.customerTypeListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BonusTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = null;
            this.tableAdapterManager.CustomerNewsletterTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = this.customerTypeListTableAdapter;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = null;
            this.tableAdapterManager.EmployeeBonusTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.JobStatusListTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropServiceTableAdapter = null;
            this.tableAdapterManager.RouteListTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfileTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // letterDataTableTableAdapter
            // 
            this.letterDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogCSVFilePath
            // 
            this.openFileDialogCSVFilePath.Filter = "CSV Files (*.csv)|*.csv|DAT Files (*.dat)|*.dat";
            this.openFileDialogCSVFilePath.Title = "Select the CSV file for importing";
            // 
            // PrintLetterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            this.ClientSize = new System.Drawing.Size(627, 337);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintLetterDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print Letter Dialog";
            this.Load += new System.EventHandler(this.PrintLetterDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridCSVdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button OKButton;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource customerTypeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter customerTypeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.LetterDataTableTableAdapter letterDataTableTableAdapter;
        private Label AllCountLabel;
        private Label lblFilePath;
        private Label lblFolderPath;
        private TextBox txtDelimiter;
        private Label label2;
        private ComboBox cmbFormats;
        private Label label3;
        private CheckBox cbColNameHeader;
        private DataGrid dGridCSVdata;
        private Button btnImport;
        private Button btnOpenFileDlg;
        private TextBox txtCSVFilePath;
        private Button btnOpenFldrBwsr;
        private TextBox txtCSVFolderPath;
        private FolderBrowserDialog fbdCSVFolder;
        private OpenFileDialog openFileDialogCSVFilePath;
        private Label label1;
        private Label label4;
    }
}