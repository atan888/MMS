namespace System.Windows.Forms.MMS
{
    partial class PreferencesDialog
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
            System.Windows.Forms.Label importPathLabel;
            System.Windows.Forms.Label reportURLLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordSaveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.testButton = new System.Windows.Forms.Button();
            this.reportURLTextBox = new System.Windows.Forms.TextBox();
            this.userProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.browsButton2 = new System.Windows.Forms.Button();
            this.importPathTextBox = new System.Windows.Forms.TextBox();
            this.templatePathTextBox = new System.Windows.Forms.TextBox();
            this.enableSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.generalSaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.passwordTabPage = new System.Windows.Forms.TabPage();
            this.customerTypeListTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.customerTypeListListBox = new System.Windows.Forms.ListBox();
            this.customerTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobSatusTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.jobStatusTextBox = new System.Windows.Forms.TextBox();
            this.addJobStatusButton = new System.Windows.Forms.Button();
            this.deleteJobStatusButton = new System.Windows.Forms.Button();
            this.jobStatusListListBox = new System.Windows.Forms.ListBox();
            this.jobStatusListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.routeTabPage = new System.Windows.Forms.TabPage();
            this.routeListListBox = new System.Windows.Forms.ListBox();
            this.routeListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.routeTextBox = new System.Windows.Forms.TextBox();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.deleteRouteButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QBSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.QBAccountTextBox = new System.Windows.Forms.TextBox();
            this.QBInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.EnableQBCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobStatusListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTypeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.jobStatusListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter();
            this.routeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter();
            this.userProfileTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.UserProfileTableAdapter();
            importPathLabel = new System.Windows.Forms.Label();
            reportURLLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            this.passwordTabPage.SuspendLayout();
            this.customerTypeListTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).BeginInit();
            this.jobSatusTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource1)).BeginInit();
            this.routeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importPathLabel
            // 
            importPathLabel.AutoSize = true;
            importPathLabel.Location = new System.Drawing.Point(17, 70);
            importPathLabel.Name = "importPathLabel";
            importPathLabel.Size = new System.Drawing.Size(83, 13);
            importPathLabel.TabIndex = 10;
            importPathLabel.Text = "Import File Path:";
            // 
            // reportURLLabel
            // 
            reportURLLabel.AutoSize = true;
            reportURLLabel.Location = new System.Drawing.Point(17, 124);
            reportURLLabel.Name = "reportURLLabel";
            reportURLLabel.Size = new System.Drawing.Size(67, 13);
            reportURLLabel.TabIndex = 12;
            reportURLLabel.Text = "Report URL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.passwordSaveButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 230);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Login:";
            // 
            // passwordSaveButton
            // 
            this.passwordSaveButton.Location = new System.Drawing.Point(282, 187);
            this.passwordSaveButton.Name = "passwordSaveButton";
            this.passwordSaveButton.Size = new System.Drawing.Size(75, 23);
            this.passwordSaveButton.TabIndex = 7;
            this.passwordSaveButton.Text = "Save";
            this.passwordSaveButton.UseVisualStyleBackColor = true;
            this.passwordSaveButton.Click += new System.EventHandler(this.passwordSaveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.generalTabPage);
            this.tabControl1.Controls.Add(this.passwordTabPage);
            this.tabControl1.Controls.Add(this.customerTypeListTabPage);
            this.tabControl1.Controls.Add(this.jobSatusTabPage);
            this.tabControl1.Controls.Add(this.routeTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 268);
            this.tabControl1.TabIndex = 8;
            // 
            // generalTabPage
            // 
            this.generalTabPage.AutoScroll = true;
            this.generalTabPage.Controls.Add(this.testButton);
            this.generalTabPage.Controls.Add(reportURLLabel);
            this.generalTabPage.Controls.Add(this.reportURLTextBox);
            this.generalTabPage.Controls.Add(this.browsButton2);
            this.generalTabPage.Controls.Add(importPathLabel);
            this.generalTabPage.Controls.Add(this.importPathTextBox);
            this.generalTabPage.Controls.Add(this.templatePathTextBox);
            this.generalTabPage.Controls.Add(this.enableSoundCheckBox);
            this.generalTabPage.Controls.Add(this.generalSaveButton);
            this.generalTabPage.Controls.Add(this.label4);
            this.generalTabPage.Controls.Add(this.browseButton);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(398, 242);
            this.generalTabPage.TabIndex = 4;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(334, 138);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(25, 23);
            this.testButton.TabIndex = 14;
            this.testButton.Text = "...";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // reportURLTextBox
            // 
            this.reportURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "ReportURL", true));
            this.reportURLTextBox.Location = new System.Drawing.Point(20, 140);
            this.reportURLTextBox.Name = "reportURLTextBox";
            this.reportURLTextBox.Size = new System.Drawing.Size(308, 20);
            this.reportURLTextBox.TabIndex = 13;
            this.reportURLTextBox.TextChanged += new System.EventHandler(this.templatePathTextBox_TextChanged);
            // 
            // userProfileBindingSource
            // 
            this.userProfileBindingSource.DataMember = "UserProfile";
            this.userProfileBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // browsButton2
            // 
            this.browsButton2.Location = new System.Drawing.Point(334, 83);
            this.browsButton2.Name = "browsButton2";
            this.browsButton2.Size = new System.Drawing.Size(25, 23);
            this.browsButton2.TabIndex = 12;
            this.browsButton2.Text = "...";
            this.browsButton2.UseVisualStyleBackColor = true;
            this.browsButton2.Click += new System.EventHandler(this.browsButton2_Click);
            // 
            // importPathTextBox
            // 
            this.importPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "ImportPath", true));
            this.importPathTextBox.Location = new System.Drawing.Point(20, 86);
            this.importPathTextBox.Name = "importPathTextBox";
            this.importPathTextBox.Size = new System.Drawing.Size(308, 20);
            this.importPathTextBox.TabIndex = 11;
            this.importPathTextBox.TextChanged += new System.EventHandler(this.templatePathTextBox_TextChanged);
            // 
            // templatePathTextBox
            // 
            this.templatePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "TemplatePath", true));
            this.templatePathTextBox.Location = new System.Drawing.Point(20, 36);
            this.templatePathTextBox.Name = "templatePathTextBox";
            this.templatePathTextBox.Size = new System.Drawing.Size(308, 20);
            this.templatePathTextBox.TabIndex = 10;
            this.templatePathTextBox.TextChanged += new System.EventHandler(this.templatePathTextBox_TextChanged);
            // 
            // enableSoundCheckBox
            // 
            this.enableSoundCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userProfileBindingSource, "EnableSound", true));
            this.enableSoundCheckBox.Location = new System.Drawing.Point(20, 184);
            this.enableSoundCheckBox.Name = "enableSoundCheckBox";
            this.enableSoundCheckBox.Size = new System.Drawing.Size(104, 24);
            this.enableSoundCheckBox.TabIndex = 9;
            this.enableSoundCheckBox.Text = "Enable Sound";
            this.enableSoundCheckBox.UseVisualStyleBackColor = true;
            this.enableSoundCheckBox.TextChanged += new System.EventHandler(this.templatePathTextBox_TextChanged);
            this.enableSoundCheckBox.CheckedChanged += new System.EventHandler(this.templatePathTextBox_TextChanged);
            // 
            // generalSaveButton
            // 
            this.generalSaveButton.Location = new System.Drawing.Point(284, 198);
            this.generalSaveButton.Name = "generalSaveButton";
            this.generalSaveButton.Size = new System.Drawing.Size(75, 23);
            this.generalSaveButton.TabIndex = 8;
            this.generalSaveButton.Text = "Save";
            this.generalSaveButton.UseVisualStyleBackColor = true;
            this.generalSaveButton.Click += new System.EventHandler(this.generalSaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Letter Template Location:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(334, 33);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 23);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // passwordTabPage
            // 
            this.passwordTabPage.Controls.Add(this.groupBox1);
            this.passwordTabPage.Location = new System.Drawing.Point(4, 22);
            this.passwordTabPage.Name = "passwordTabPage";
            this.passwordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTabPage.Size = new System.Drawing.Size(398, 242);
            this.passwordTabPage.TabIndex = 0;
            this.passwordTabPage.Text = "Password";
            this.passwordTabPage.UseVisualStyleBackColor = true;
            // 
            // customerTypeListTabPage
            // 
            this.customerTypeListTabPage.AutoScroll = true;
            this.customerTypeListTabPage.Controls.Add(this.groupBox2);
            this.customerTypeListTabPage.Controls.Add(this.DeleteButton);
            this.customerTypeListTabPage.Controls.Add(this.customerTypeListListBox);
            this.customerTypeListTabPage.Location = new System.Drawing.Point(4, 22);
            this.customerTypeListTabPage.Name = "customerTypeListTabPage";
            this.customerTypeListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerTypeListTabPage.Size = new System.Drawing.Size(398, 242);
            this.customerTypeListTabPage.TabIndex = 1;
            this.customerTypeListTabPage.Text = "Customer Type";
            this.customerTypeListTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addTextBox);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Location = new System.Drawing.Point(204, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 80);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add To List";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(11, 19);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(115, 20);
            this.addTextBox.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(11, 45);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(215, 192);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // customerTypeListListBox
            // 
            this.customerTypeListListBox.DataSource = this.customerTypeListBindingSource;
            this.customerTypeListListBox.DisplayMember = "CustomerType";
            this.customerTypeListListBox.FormattingEnabled = true;
            this.customerTypeListListBox.Location = new System.Drawing.Point(24, 16);
            this.customerTypeListListBox.Name = "customerTypeListListBox";
            this.customerTypeListListBox.Size = new System.Drawing.Size(165, 199);
            this.customerTypeListListBox.TabIndex = 10;
            this.customerTypeListListBox.ValueMember = "CustomerTypeID";
            // 
            // customerTypeListBindingSource
            // 
            this.customerTypeListBindingSource.DataMember = "CustomerTypeList";
            this.customerTypeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // jobSatusTabPage
            // 
            this.jobSatusTabPage.AutoScroll = true;
            this.jobSatusTabPage.Controls.Add(this.groupBox3);
            this.jobSatusTabPage.Controls.Add(this.deleteJobStatusButton);
            this.jobSatusTabPage.Controls.Add(this.jobStatusListListBox);
            this.jobSatusTabPage.Location = new System.Drawing.Point(4, 22);
            this.jobSatusTabPage.Name = "jobSatusTabPage";
            this.jobSatusTabPage.Size = new System.Drawing.Size(398, 242);
            this.jobSatusTabPage.TabIndex = 2;
            this.jobSatusTabPage.Text = "Job Status";
            this.jobSatusTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.jobStatusTextBox);
            this.groupBox3.Controls.Add(this.addJobStatusButton);
            this.groupBox3.Location = new System.Drawing.Point(204, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 80);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add To List";
            // 
            // jobStatusTextBox
            // 
            this.jobStatusTextBox.Location = new System.Drawing.Point(11, 19);
            this.jobStatusTextBox.Name = "jobStatusTextBox";
            this.jobStatusTextBox.Size = new System.Drawing.Size(115, 20);
            this.jobStatusTextBox.TabIndex = 13;
            // 
            // addJobStatusButton
            // 
            this.addJobStatusButton.Location = new System.Drawing.Point(11, 45);
            this.addJobStatusButton.Name = "addJobStatusButton";
            this.addJobStatusButton.Size = new System.Drawing.Size(75, 23);
            this.addJobStatusButton.TabIndex = 11;
            this.addJobStatusButton.Text = "Add";
            this.addJobStatusButton.UseVisualStyleBackColor = true;
            this.addJobStatusButton.Click += new System.EventHandler(this.addJobStatusButton_Click);
            // 
            // deleteJobStatusButton
            // 
            this.deleteJobStatusButton.Location = new System.Drawing.Point(215, 192);
            this.deleteJobStatusButton.Name = "deleteJobStatusButton";
            this.deleteJobStatusButton.Size = new System.Drawing.Size(75, 23);
            this.deleteJobStatusButton.TabIndex = 15;
            this.deleteJobStatusButton.Text = "Delete";
            this.deleteJobStatusButton.UseVisualStyleBackColor = true;
            this.deleteJobStatusButton.Click += new System.EventHandler(this.deleteJobStatusButton_Click);
            // 
            // jobStatusListListBox
            // 
            this.jobStatusListListBox.DataSource = this.jobStatusListBindingSource1;
            this.jobStatusListListBox.DisplayMember = "JobStatus";
            this.jobStatusListListBox.FormattingEnabled = true;
            this.jobStatusListListBox.Location = new System.Drawing.Point(24, 16);
            this.jobStatusListListBox.Name = "jobStatusListListBox";
            this.jobStatusListListBox.Size = new System.Drawing.Size(165, 199);
            this.jobStatusListListBox.TabIndex = 0;
            this.jobStatusListListBox.ValueMember = "JobStatusID";
            // 
            // jobStatusListBindingSource1
            // 
            this.jobStatusListBindingSource1.DataMember = "JobStatusList";
            this.jobStatusListBindingSource1.DataSource = this.mMSDataSet;
            // 
            // routeTabPage
            // 
            this.routeTabPage.AutoScroll = true;
            this.routeTabPage.Controls.Add(this.routeListListBox);
            this.routeTabPage.Controls.Add(this.groupBox4);
            this.routeTabPage.Controls.Add(this.deleteRouteButton);
            this.routeTabPage.Location = new System.Drawing.Point(4, 22);
            this.routeTabPage.Name = "routeTabPage";
            this.routeTabPage.Size = new System.Drawing.Size(398, 242);
            this.routeTabPage.TabIndex = 3;
            this.routeTabPage.Text = "Route";
            this.routeTabPage.UseVisualStyleBackColor = true;
            // 
            // routeListListBox
            // 
            this.routeListListBox.DataSource = this.routeListBindingSource1;
            this.routeListListBox.DisplayMember = "RouteName";
            this.routeListListBox.FormattingEnabled = true;
            this.routeListListBox.Location = new System.Drawing.Point(24, 16);
            this.routeListListBox.Name = "routeListListBox";
            this.routeListListBox.Size = new System.Drawing.Size(165, 199);
            this.routeListListBox.TabIndex = 18;
            this.routeListListBox.ValueMember = "RouteNameID";
            // 
            // routeListBindingSource1
            // 
            this.routeListBindingSource1.DataMember = "RouteList";
            this.routeListBindingSource1.DataSource = this.mMSDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.routeTextBox);
            this.groupBox4.Controls.Add(this.addRouteButton);
            this.groupBox4.Location = new System.Drawing.Point(205, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 80);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add To List";
            // 
            // routeTextBox
            // 
            this.routeTextBox.Location = new System.Drawing.Point(11, 19);
            this.routeTextBox.Name = "routeTextBox";
            this.routeTextBox.Size = new System.Drawing.Size(115, 20);
            this.routeTextBox.TabIndex = 13;
            // 
            // addRouteButton
            // 
            this.addRouteButton.Location = new System.Drawing.Point(11, 45);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(75, 23);
            this.addRouteButton.TabIndex = 11;
            this.addRouteButton.Text = "Add";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // deleteRouteButton
            // 
            this.deleteRouteButton.Location = new System.Drawing.Point(216, 193);
            this.deleteRouteButton.Name = "deleteRouteButton";
            this.deleteRouteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRouteButton.TabIndex = 17;
            this.deleteRouteButton.Text = "Delete";
            this.deleteRouteButton.UseVisualStyleBackColor = true;
            this.deleteRouteButton.Click += new System.EventHandler(this.deleteRouteButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.QBSave);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.QBAccountTextBox);
            this.tabPage1.Controls.Add(this.QBInvoiceDate);
            this.tabPage1.Controls.Add(this.EnableQBCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(398, 242);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "QuickBooks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QBSave
            // 
            this.QBSave.Location = new System.Drawing.Point(290, 192);
            this.QBSave.Name = "QBSave";
            this.QBSave.Size = new System.Drawing.Size(75, 23);
            this.QBSave.TabIndex = 9;
            this.QBSave.Text = "Save";
            this.QBSave.UseVisualStyleBackColor = true;
            this.QBSave.Click += new System.EventHandler(this.generalSaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Item Account:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Invoice Date:";
            // 
            // QBAccountTextBox
            // 
            this.QBAccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userProfileBindingSource, "QBAccount", true));
            this.QBAccountTextBox.Location = new System.Drawing.Point(98, 100);
            this.QBAccountTextBox.Name = "QBAccountTextBox";
            this.QBAccountTextBox.Size = new System.Drawing.Size(202, 20);
            this.QBAccountTextBox.TabIndex = 2;
            this.QBAccountTextBox.Visible = false;
            // 
            // QBInvoiceDate
            // 
            this.QBInvoiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userProfileBindingSource, "QBInvoiceDate", true));
            this.QBInvoiceDate.Location = new System.Drawing.Point(98, 60);
            this.QBInvoiceDate.Name = "QBInvoiceDate";
            this.QBInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.QBInvoiceDate.TabIndex = 1;
            // 
            // EnableQBCheckBox
            // 
            this.EnableQBCheckBox.AutoSize = true;
            this.EnableQBCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.userProfileBindingSource, "QBIntegration", true));
            this.EnableQBCheckBox.Location = new System.Drawing.Point(21, 19);
            this.EnableQBCheckBox.Name = "EnableQBCheckBox";
            this.EnableQBCheckBox.Size = new System.Drawing.Size(130, 17);
            this.EnableQBCheckBox.TabIndex = 0;
            this.EnableQBCheckBox.Text = "Enable QB Integration";
            this.EnableQBCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(339, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataMember = "RouteList";
            this.routeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // jobStatusListBindingSource
            // 
            this.jobStatusListBindingSource.DataMember = "JobStatusList";
            this.jobStatusListBindingSource.DataSource = this.mMSDataSet;
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
            this.tableAdapterManager.JobStatusListTableAdapter = this.jobStatusListTableAdapter;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropServiceTableAdapter = null;
            this.tableAdapterManager.RouteListTableAdapter = this.routeListTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfileTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // jobStatusListTableAdapter
            // 
            this.jobStatusListTableAdapter.ClearBeforeFill = true;
            // 
            // routeListTableAdapter
            // 
            this.routeListTableAdapter.ClearBeforeFill = true;
            // 
            // userProfileTableAdapter
            // 
            this.userProfileTableAdapter.ClearBeforeFill = true;
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PreferencesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            this.passwordTabPage.ResumeLayout(false);
            this.customerTypeListTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).EndInit();
            this.jobSatusTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource1)).EndInit();
            this.routeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Button passwordSaveButton;
        private TabControl tabControl1;
        private TabPage passwordTabPage;
        private TabPage customerTypeListTabPage;
        private Button button1;
        private TabPage jobSatusTabPage;
        private TabPage generalTabPage;
        private TabPage routeTabPage;
        private Label label4;
        private Button browseButton;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource customerTypeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter customerTypeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter jobStatusListTableAdapter;
        private BindingSource jobStatusListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter routeListTableAdapter;
        private BindingSource routeListBindingSource;
        private ListBox customerTypeListListBox;
        private TextBox addTextBox;
        private Button DeleteButton;
        private Button AddButton;
        private GroupBox groupBox2;
        private ListBox jobStatusListListBox;
        private BindingSource jobStatusListBindingSource1;
        private GroupBox groupBox3;
        private TextBox jobStatusTextBox;
        private Button addJobStatusButton;
        private Button deleteJobStatusButton;
        private TextBox textBox4;
        private Button button2;
        private GroupBox groupBox4;
        private TextBox routeTextBox;
        private Button addRouteButton;
        private Button deleteRouteButton;
        private ListBox routeListListBox;
        private BindingSource routeListBindingSource1;
        private Button generalSaveButton;
        private BindingSource userProfileBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.UserProfileTableAdapter userProfileTableAdapter;
        private CheckBox enableSoundCheckBox;
        private TextBox templatePathTextBox;
        private TextBox importPathTextBox;
        private Button browsButton2;
        private TabPage tabPage1;
        private CheckBox EnableQBCheckBox;
        private DateTimePicker QBInvoiceDate;
        private Label label6;
        private Label label5;
        private TextBox QBAccountTextBox;
        private Button QBSave;
        private TextBox reportURLTextBox;
        private Button testButton;

    }
}