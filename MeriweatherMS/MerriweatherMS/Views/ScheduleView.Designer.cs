namespace System.Windows.Forms.MMS.Views
{
    partial class ScheduleView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label instructionsLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label subdivisionLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label manHoursLabel;
            System.Windows.Forms.Label costFourStepLabel;
            System.Windows.Forms.Label costContractorLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label costBLabel;
            System.Windows.Forms.Label materialCostLabel;
            System.Windows.Forms.Label revenueLabel;
            System.Windows.Forms.Label qBInvoiceIDLabel;
            System.Windows.Forms.Label costCLabel;
            System.Windows.Forms.Label fourStepMatLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleView));
            System.Windows.Forms.Label costDLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearDateButton = new System.Windows.Forms.Button();
            this.NoDateCheckBox = new System.Windows.Forms.CheckBox();
            this.NotInvoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.FourStepFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.PrintSheetsButton = new System.Windows.Forms.Button();
            this.QBInvoiceButton = new System.Windows.Forms.Button();
            this.fromDateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JobTypeFilterComboBox = new System.Windows.Forms.ComboBox();
            this.showAllDatesCheckBox = new System.Windows.Forms.CheckBox();
            this.todayFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toDateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.JobStatusFilterComboBox = new System.Windows.Forms.ComboBox();
            this.jobStatusListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.assignCrewButton = new System.Windows.Forms.Button();
            this.setJobStatusButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.extendedDataGridView1 = new DataGridViewControls.ExtendedDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subdivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrewKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourStepJob = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QBInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QBItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QBItemIDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QBItemIDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GutterRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourStepMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourStepJob1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepJob2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepJob3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepJob4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.custPropertyJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custPropertyJobsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.crewNameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.detailsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.subdivisionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.costTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fourStepMatTextBox = new System.Windows.Forms.TextBox();
            this.fourStepJobCheckBox = new System.Windows.Forms.CheckBox();
            this.costCTextBox = new System.Windows.Forms.TextBox();
            this.qBInvoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PMH = new System.Windows.Forms.TextBox();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.materialCostTextBox = new System.Windows.Forms.TextBox();
            this.costBTextBox = new System.Windows.Forms.TextBox();
            this.manHoursTextBox = new System.Windows.Forms.TextBox();
            this.costFourStepTextBox = new System.Windows.Forms.TextBox();
            this.costContractorTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.instructTabPage = new System.Windows.Forms.TabPage();
            this.instructionsTextBox = new System.Windows.Forms.TextBox();
            this.notesTabPage = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.modifyWorkButton = new System.Windows.Forms.Button();
            this.customerJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleStrip1 = new System.Windows.Forms.MMS.TitleStrip();
            this.custPropertyJobsTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.crewNameTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CrewNameTableAdapter();
            this.customerJobTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter();
            this.jobStatusListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter();
            this.routeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter();
            this.routeTableAdapter1 = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter();
            this.customerNewletterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNewsletterTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerNewsletterTableAdapter();
            this.serviceTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.ServiceTableAdapter();
            this.costDTextBox = new System.Windows.Forms.TextBox();
            instructionsLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            subdivisionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            manHoursLabel = new System.Windows.Forms.Label();
            costFourStepLabel = new System.Windows.Forms.Label();
            costContractorLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            costBLabel = new System.Windows.Forms.Label();
            materialCostLabel = new System.Windows.Forms.Label();
            revenueLabel = new System.Windows.Forms.Label();
            qBInvoiceIDLabel = new System.Windows.Forms.Label();
            costCLabel = new System.Windows.Forms.Label();
            fourStepMatLabel = new System.Windows.Forms.Label();
            costDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingNavigator)).BeginInit();
            this.custPropertyJobsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crewNameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewNameBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.detailsTabPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.costTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.instructTabPage.SuspendLayout();
            this.notesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNewletterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.Location = new System.Drawing.Point(371, 142);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new System.Drawing.Size(63, 13);
            instructionsLabel.TabIndex = 29;
            instructionsLabel.Text = "Instructions:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 44);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(60, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(14, 18);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(59, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(20, 22);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(41, 48);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(33, 74);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State:";
            // 
            // subdivisionLabel
            // 
            subdivisionLabel.AutoSize = true;
            subdivisionLabel.Location = new System.Drawing.Point(4, 100);
            subdivisionLabel.Name = "subdivisionLabel";
            subdivisionLabel.Size = new System.Drawing.Size(64, 13);
            subdivisionLabel.TabIndex = 10;
            subdivisionLabel.Text = "Subdivision:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(41, 75);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 18;
            dateLabel.Text = "Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(34, 127);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 49;
            statusLabel.Text = "Status:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(20, 101);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(52, 13);
            typeLabel.TabIndex = 50;
            typeLabel.Text = "Job Type:";
            // 
            // manHoursLabel
            // 
            manHoursLabel.AutoSize = true;
            manHoursLabel.Location = new System.Drawing.Point(39, 21);
            manHoursLabel.Name = "manHoursLabel";
            manHoursLabel.Size = new System.Drawing.Size(37, 13);
            manHoursLabel.TabIndex = 52;
            manHoursLabel.Text = "Hours:";
            // 
            // costFourStepLabel
            // 
            costFourStepLabel.AutoSize = true;
            costFourStepLabel.Location = new System.Drawing.Point(398, 58);
            costFourStepLabel.Name = "costFourStepLabel";
            costFourStepLabel.Size = new System.Drawing.Size(52, 13);
            costFourStepLabel.TabIndex = 50;
            costFourStepLabel.Text = "4ST Cost:";
            // 
            // costContractorLabel
            // 
            costContractorLabel.AutoSize = true;
            costContractorLabel.Location = new System.Drawing.Point(0, 124);
            costContractorLabel.Name = "costContractorLabel";
            costContractorLabel.Size = new System.Drawing.Size(82, 13);
            costContractorLabel.TabIndex = 48;
            costContractorLabel.Text = "Cost Contractor:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(228, 47);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(41, 13);
            costLabel.TabIndex = 46;
            costLabel.Text = "Cost A:";
            // 
            // costBLabel
            // 
            costBLabel.AutoSize = true;
            costBLabel.Location = new System.Drawing.Point(228, 73);
            costBLabel.Name = "costBLabel";
            costBLabel.Size = new System.Drawing.Size(41, 13);
            costBLabel.TabIndex = 53;
            costBLabel.Text = "Cost B:";
            // 
            // materialCostLabel
            // 
            materialCostLabel.AutoSize = true;
            materialCostLabel.Location = new System.Drawing.Point(7, 100);
            materialCostLabel.Name = "materialCostLabel";
            materialCostLabel.Size = new System.Drawing.Size(71, 13);
            materialCostLabel.TabIndex = 55;
            materialCostLabel.Text = "Material Cost:";
            // 
            // revenueLabel
            // 
            revenueLabel.AutoSize = true;
            revenueLabel.Location = new System.Drawing.Point(23, 47);
            revenueLabel.Name = "revenueLabel";
            revenueLabel.Size = new System.Drawing.Size(53, 13);
            revenueLabel.TabIndex = 56;
            revenueLabel.Text = "Revenue:";
            // 
            // qBInvoiceIDLabel
            // 
            qBInvoiceIDLabel.AutoSize = true;
            qBInvoiceIDLabel.Location = new System.Drawing.Point(199, 17);
            qBInvoiceIDLabel.Name = "qBInvoiceIDLabel";
            qBInvoiceIDLabel.Size = new System.Drawing.Size(70, 13);
            qBInvoiceIDLabel.TabIndex = 66;
            qBInvoiceIDLabel.Text = "QBInvoiceID:";
            // 
            // costCLabel
            // 
            costCLabel.AutoSize = true;
            costCLabel.Location = new System.Drawing.Point(224, 100);
            costCLabel.Name = "costCLabel";
            costCLabel.Size = new System.Drawing.Size(41, 13);
            costCLabel.TabIndex = 67;
            costCLabel.Text = "Cost C:";
            // 
            // fourStepMatLabel
            // 
            fourStepMatLabel.AutoSize = true;
            fourStepMatLabel.Location = new System.Drawing.Point(398, 104);
            fourStepMatLabel.Name = "fourStepMatLabel";
            fourStepMatLabel.Size = new System.Drawing.Size(77, 13);
            fourStepMatLabel.TabIndex = 69;
            fourStepMatLabel.Text = "Four Step Mat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ClearDateButton);
            this.groupBox1.Controls.Add(this.NoDateCheckBox);
            this.groupBox1.Controls.Add(this.NotInvoiceCheckBox);
            this.groupBox1.Controls.Add(this.FourStepFilterCheckBox);
            this.groupBox1.Controls.Add(this.PrintSheetsButton);
            this.groupBox1.Controls.Add(this.QBInvoiceButton);
            this.groupBox1.Controls.Add(this.fromDateTimePickerFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.JobTypeFilterComboBox);
            this.groupBox1.Controls.Add(this.showAllDatesCheckBox);
            this.groupBox1.Controls.Add(this.todayFilterCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.toDateTimePickerFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.JobStatusFilterComboBox);
            this.groupBox1.Controls.Add(this.assignCrewButton);
            this.groupBox1.Controls.Add(this.setJobStatusButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.extendedDataGridView1);
            this.groupBox1.Controls.Add(this.custPropertyJobsBindingNavigator);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.groupBox1.Location = new System.Drawing.Point(14, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduled Work";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ClearDateButton
            // 
            this.ClearDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearDateButton.Location = new System.Drawing.Point(444, 324);
            this.ClearDateButton.Name = "ClearDateButton";
            this.ClearDateButton.Size = new System.Drawing.Size(75, 23);
            this.ClearDateButton.TabIndex = 63;
            this.ClearDateButton.Text = "Clear Date";
            this.ClearDateButton.UseVisualStyleBackColor = true;
            this.ClearDateButton.Click += new System.EventHandler(this.ClearDateButton_Click);
            // 
            // NoDateCheckBox
            // 
            this.NoDateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoDateCheckBox.AutoSize = true;
            this.NoDateCheckBox.Location = new System.Drawing.Point(481, 48);
            this.NoDateCheckBox.Name = "NoDateCheckBox";
            this.NoDateCheckBox.Size = new System.Drawing.Size(100, 17);
            this.NoDateCheckBox.TabIndex = 62;
            this.NoDateCheckBox.Text = "Show No Dates";
            this.NoDateCheckBox.UseVisualStyleBackColor = true;
            this.NoDateCheckBox.CheckedChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // NotInvoiceCheckBox
            // 
            this.NotInvoiceCheckBox.AutoSize = true;
            this.NotInvoiceCheckBox.Location = new System.Drawing.Point(218, 40);
            this.NotInvoiceCheckBox.Name = "NotInvoiceCheckBox";
            this.NotInvoiceCheckBox.Size = new System.Drawing.Size(85, 17);
            this.NotInvoiceCheckBox.TabIndex = 61;
            this.NotInvoiceCheckBox.Text = "Not Invoiced";
            this.NotInvoiceCheckBox.UseVisualStyleBackColor = true;
            this.NotInvoiceCheckBox.CheckedChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // FourStepFilterCheckBox
            // 
            this.FourStepFilterCheckBox.AutoSize = true;
            this.FourStepFilterCheckBox.Location = new System.Drawing.Point(218, 17);
            this.FourStepFilterCheckBox.Name = "FourStepFilterCheckBox";
            this.FourStepFilterCheckBox.Size = new System.Drawing.Size(100, 17);
            this.FourStepFilterCheckBox.TabIndex = 60;
            this.FourStepFilterCheckBox.Text = "4StepJobs Only";
            this.FourStepFilterCheckBox.UseVisualStyleBackColor = true;
            this.FourStepFilterCheckBox.CheckedChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // PrintSheetsButton
            // 
            this.PrintSheetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintSheetsButton.Location = new System.Drawing.Point(93, 324);
            this.PrintSheetsButton.Name = "PrintSheetsButton";
            this.PrintSheetsButton.Size = new System.Drawing.Size(75, 23);
            this.PrintSheetsButton.TabIndex = 59;
            this.PrintSheetsButton.Text = "Sheets";
            this.PrintSheetsButton.UseVisualStyleBackColor = true;
            this.PrintSheetsButton.Click += new System.EventHandler(this.PrintSheetsButton_Click);
            // 
            // QBInvoiceButton
            // 
            this.QBInvoiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QBInvoiceButton.Location = new System.Drawing.Point(255, 324);
            this.QBInvoiceButton.Name = "QBInvoiceButton";
            this.QBInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.QBInvoiceButton.TabIndex = 58;
            this.QBInvoiceButton.Text = "QB Invoice";
            this.QBInvoiceButton.UseVisualStyleBackColor = true;
            this.QBInvoiceButton.Click += new System.EventHandler(this.QBInvoiceButton_Click);
            // 
            // fromDateTimePickerFilter
            // 
            this.fromDateTimePickerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateTimePickerFilter.Location = new System.Drawing.Point(632, 16);
            this.fromDateTimePickerFilter.Name = "fromDateTimePickerFilter";
            this.fromDateTimePickerFilter.Size = new System.Drawing.Size(200, 18);
            this.fromDateTimePickerFilter.TabIndex = 46;
            this.fromDateTimePickerFilter.ValueChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Type:";
            // 
            // JobTypeFilterComboBox
            // 
            this.JobTypeFilterComboBox.FormattingEnabled = true;
            this.JobTypeFilterComboBox.Items.AddRange(new object[] {
            "All",
            "Mow",
            "Leaf",
            "Gutter",
            "Other"});
            this.JobTypeFilterComboBox.Location = new System.Drawing.Point(52, 40);
            this.JobTypeFilterComboBox.Name = "JobTypeFilterComboBox";
            this.JobTypeFilterComboBox.Size = new System.Drawing.Size(130, 21);
            this.JobTypeFilterComboBox.TabIndex = 53;
            this.JobTypeFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // showAllDatesCheckBox
            // 
            this.showAllDatesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllDatesCheckBox.AutoSize = true;
            this.showAllDatesCheckBox.Location = new System.Drawing.Point(481, 30);
            this.showAllDatesCheckBox.Name = "showAllDatesCheckBox";
            this.showAllDatesCheckBox.Size = new System.Drawing.Size(98, 17);
            this.showAllDatesCheckBox.TabIndex = 52;
            this.showAllDatesCheckBox.Text = "Show All Dates";
            this.showAllDatesCheckBox.UseVisualStyleBackColor = true;
            this.showAllDatesCheckBox.CheckedChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // todayFilterCheckBox
            // 
            this.todayFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.todayFilterCheckBox.AutoSize = true;
            this.todayFilterCheckBox.Location = new System.Drawing.Point(481, 13);
            this.todayFilterCheckBox.Name = "todayFilterCheckBox";
            this.todayFilterCheckBox.Size = new System.Drawing.Size(54, 17);
            this.todayFilterCheckBox.TabIndex = 50;
            this.todayFilterCheckBox.Text = "Today";
            this.todayFilterCheckBox.UseVisualStyleBackColor = true;
            this.todayFilterCheckBox.CheckedChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "To:";
            // 
            // toDateTimePickerFilter
            // 
            this.toDateTimePickerFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDateTimePickerFilter.Location = new System.Drawing.Point(632, 43);
            this.toDateTimePickerFilter.Name = "toDateTimePickerFilter";
            this.toDateTimePickerFilter.Size = new System.Drawing.Size(200, 18);
            this.toDateTimePickerFilter.TabIndex = 47;
            this.toDateTimePickerFilter.ValueChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Status:";
            // 
            // JobStatusFilterComboBox
            // 
            this.JobStatusFilterComboBox.DataSource = this.jobStatusListBindingSource;
            this.JobStatusFilterComboBox.DisplayMember = "JobStatus";
            this.JobStatusFilterComboBox.FormattingEnabled = true;
            this.JobStatusFilterComboBox.Location = new System.Drawing.Point(52, 16);
            this.JobStatusFilterComboBox.Name = "JobStatusFilterComboBox";
            this.JobStatusFilterComboBox.Size = new System.Drawing.Size(130, 21);
            this.JobStatusFilterComboBox.TabIndex = 44;
            this.JobStatusFilterComboBox.ValueMember = "JobStatus";
            this.JobStatusFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.JobTypeFilterComboBox_SelectedIndexChanged);
            // 
            // jobStatusListBindingSource
            // 
            this.jobStatusListBindingSource.DataMember = "JobStatusList";
            this.jobStatusListBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignCrewButton
            // 
            this.assignCrewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assignCrewButton.Location = new System.Drawing.Point(12, 324);
            this.assignCrewButton.Name = "assignCrewButton";
            this.assignCrewButton.Size = new System.Drawing.Size(75, 23);
            this.assignCrewButton.TabIndex = 43;
            this.assignCrewButton.Text = "Assign Crew";
            this.assignCrewButton.UseVisualStyleBackColor = true;
            this.assignCrewButton.Click += new System.EventHandler(this.assignCrewButton_Click);
            // 
            // setJobStatusButton
            // 
            this.setJobStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setJobStatusButton.Location = new System.Drawing.Point(174, 324);
            this.setJobStatusButton.Name = "setJobStatusButton";
            this.setJobStatusButton.Size = new System.Drawing.Size(75, 23);
            this.setJobStatusButton.TabIndex = 42;
            this.setJobStatusButton.Text = "Set Status";
            this.setJobStatusButton.UseVisualStyleBackColor = true;
            this.setJobStatusButton.Click += new System.EventHandler(this.setJobStatusButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(529, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 39;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // extendedDataGridView1
            // 
            this.extendedDataGridView1.AllowUserToAddRows = false;
            this.extendedDataGridView1.AllowUserToDeleteRows = false;
            this.extendedDataGridView1.AllowUserToResizeRows = false;
            this.extendedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.extendedDataGridView1.AutoGenerateColumns = false;
            this.extendedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.extendedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Date,
            this.LastName,
            this.FirstName,
            this.Type,
            this.Description,
            this.Address,
            this.City,
            this.Subdivision,
            this.Status,
            this.PropertyID,
            this.CrewKey,
            this.FourStepJob,
            this.QBInvoiceID,
            this.QBItemID,
            this.QBItemIDB,
            this.QBItemIDC,
            this.Cost,
            this.GutterRegion,
            this.Notes,
            this.FourStepMat,
            this.FourStepJob1,
            this.FourStepJob2,
            this.FourStepJob3,
            this.FourStepJob4});
            this.extendedDataGridView1.DataSource = this.custPropertyJobsBindingSource;
            this.extendedDataGridView1.Location = new System.Drawing.Point(52, 70);
            this.extendedDataGridView1.Name = "extendedDataGridView1";
            this.extendedDataGridView1.ReadOnly = true;
            this.extendedDataGridView1.RowTemplate.Height = 24;
            this.extendedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.extendedDataGridView1.Size = new System.Drawing.Size(800, 252);
            this.extendedDataGridView1.TabIndex = 38;
            this.extendedDataGridView1.SelectionChanged += new System.EventHandler(this.extendedDataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerJobID";
            this.Column1.HeaderText = "JobID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 75;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 75;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 25;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Subdivision
            // 
            this.Subdivision.DataPropertyName = "Subdivision";
            this.Subdivision.HeaderText = "Subdivision";
            this.Subdivision.Name = "Subdivision";
            this.Subdivision.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 75;
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            this.PropertyID.Visible = false;
            // 
            // CrewKey
            // 
            this.CrewKey.DataPropertyName = "CrewKey";
            this.CrewKey.HeaderText = "CKey";
            this.CrewKey.Name = "CrewKey";
            this.CrewKey.ReadOnly = true;
            this.CrewKey.Width = 80;
            // 
            // FourStepJob
            // 
            this.FourStepJob.DataPropertyName = "FourStepJob";
            this.FourStepJob.HeaderText = "FourStep";
            this.FourStepJob.Name = "FourStepJob";
            this.FourStepJob.ReadOnly = true;
            this.FourStepJob.Width = 60;
            // 
            // QBInvoiceID
            // 
            this.QBInvoiceID.DataPropertyName = "QBInvoiceID";
            this.QBInvoiceID.HeaderText = "QBInvoiceID";
            this.QBInvoiceID.Name = "QBInvoiceID";
            this.QBInvoiceID.ReadOnly = true;
            // 
            // QBItemID
            // 
            this.QBItemID.DataPropertyName = "QBItemID";
            this.QBItemID.HeaderText = "QBItemID";
            this.QBItemID.Name = "QBItemID";
            this.QBItemID.ReadOnly = true;
            this.QBItemID.Visible = false;
            // 
            // QBItemIDB
            // 
            this.QBItemIDB.DataPropertyName = "QBItemIDB";
            this.QBItemIDB.HeaderText = "QBItemIDB";
            this.QBItemIDB.Name = "QBItemIDB";
            this.QBItemIDB.ReadOnly = true;
            this.QBItemIDB.Visible = false;
            // 
            // QBItemIDC
            // 
            this.QBItemIDC.DataPropertyName = "QBItemIDC";
            this.QBItemIDC.HeaderText = "QBItemIDC";
            this.QBItemIDC.Name = "QBItemIDC";
            this.QBItemIDC.ReadOnly = true;
            this.QBItemIDC.Visible = false;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Visible = false;
            // 
            // GutterRegion
            // 
            this.GutterRegion.DataPropertyName = "GutterRegion";
            this.GutterRegion.HeaderText = "Region";
            this.GutterRegion.Name = "GutterRegion";
            this.GutterRegion.ReadOnly = true;
            this.GutterRegion.Width = 60;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 25;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // FourStepMat
            // 
            this.FourStepMat.DataPropertyName = "MaterialCost";
            this.FourStepMat.HeaderText = "FourStepMat";
            this.FourStepMat.Name = "FourStepMat";
            this.FourStepMat.ReadOnly = true;
            this.FourStepMat.Visible = false;
            // 
            // FourStepJob1
            // 
            this.FourStepJob1.DataPropertyName = "FourStepJob1";
            this.FourStepJob1.HeaderText = "FourStepJob1";
            this.FourStepJob1.Name = "FourStepJob1";
            this.FourStepJob1.ReadOnly = true;
            this.FourStepJob1.Visible = false;
            // 
            // FourStepJob2
            // 
            this.FourStepJob2.DataPropertyName = "FourStepJob2";
            this.FourStepJob2.HeaderText = "FourStepJob2";
            this.FourStepJob2.Name = "FourStepJob2";
            this.FourStepJob2.ReadOnly = true;
            this.FourStepJob2.Visible = false;
            // 
            // FourStepJob3
            // 
            this.FourStepJob3.DataPropertyName = "FourStepJob3";
            this.FourStepJob3.HeaderText = "FourStepJob3";
            this.FourStepJob3.Name = "FourStepJob3";
            this.FourStepJob3.ReadOnly = true;
            this.FourStepJob3.Visible = false;
            // 
            // FourStepJob4
            // 
            this.FourStepJob4.DataPropertyName = "FourStepJob4";
            this.FourStepJob4.HeaderText = "FourStepJob4";
            this.FourStepJob4.Name = "FourStepJob4";
            this.FourStepJob4.ReadOnly = true;
            this.FourStepJob4.Visible = false;
            // 
            // custPropertyJobsBindingSource
            // 
            this.custPropertyJobsBindingSource.DataMember = "CustPropertyJobs";
            this.custPropertyJobsBindingSource.DataSource = this.mMSDataSet;
            // 
            // custPropertyJobsBindingNavigator
            // 
            this.custPropertyJobsBindingNavigator.AddNewItem = null;
            this.custPropertyJobsBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.custPropertyJobsBindingNavigator.BindingSource = this.custPropertyJobsBindingSource;
            this.custPropertyJobsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.custPropertyJobsBindingNavigator.DeleteItem = null;
            this.custPropertyJobsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.custPropertyJobsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.custPropertyJobsBindingNavigator.Location = new System.Drawing.Point(623, 322);
            this.custPropertyJobsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.custPropertyJobsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.custPropertyJobsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.custPropertyJobsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.custPropertyJobsBindingNavigator.Name = "custPropertyJobsBindingNavigator";
            this.custPropertyJobsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.custPropertyJobsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.custPropertyJobsBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.custPropertyJobsBindingNavigator.TabIndex = 37;
            this.custPropertyJobsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataMember = "RouteList";
            this.routeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.crewButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.modifyWorkButton);
            this.groupBox2.Controls.Add(instructionsLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.groupBox2.Location = new System.Drawing.Point(14, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 245);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Detail";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.crewNameDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(594, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 225);
            this.groupBox5.TabIndex = 47;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crew";
            // 
            // crewNameDataGridView
            // 
            this.crewNameDataGridView.AllowUserToAddRows = false;
            this.crewNameDataGridView.AllowUserToDeleteRows = false;
            this.crewNameDataGridView.AllowUserToOrderColumns = true;
            this.crewNameDataGridView.AllowUserToResizeRows = false;
            this.crewNameDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.crewNameDataGridView.AutoGenerateColumns = false;
            this.crewNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.crewNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.EmployeeId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.crewNameDataGridView.DataSource = this.crewNameBindingSource;
            this.crewNameDataGridView.Location = new System.Drawing.Point(11, 16);
            this.crewNameDataGridView.MultiSelect = false;
            this.crewNameDataGridView.Name = "crewNameDataGridView";
            this.crewNameDataGridView.ReadOnly = true;
            this.crewNameDataGridView.RowHeadersVisible = false;
            this.crewNameDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crewNameDataGridView.Size = new System.Drawing.Size(225, 196);
            this.crewNameDataGridView.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerJobID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerJobID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn1.FillWeight = 49.23858F;
            this.dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // crewNameBindingSource
            // 
            this.crewNameBindingSource.DataMember = "CrewName";
            this.crewNameBindingSource.DataSource = this.mMSDataSet;
            // 
            // crewButton
            // 
            this.crewButton.Location = new System.Drawing.Point(11, 216);
            this.crewButton.Name = "crewButton";
            this.crewButton.Size = new System.Drawing.Size(119, 23);
            this.crewButton.TabIndex = 43;
            this.crewButton.Text = "Modify Crew...";
            this.crewButton.UseVisualStyleBackColor = true;
            this.crewButton.Visible = false;
            this.crewButton.Click += new System.EventHandler(this.crewButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(401, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.detailsTabPage);
            this.tabControl1.Controls.Add(this.costTabPage);
            this.tabControl1.Controls.Add(this.instructTabPage);
            this.tabControl1.Controls.Add(this.notesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(11, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 191);
            this.tabControl1.TabIndex = 45;
            // 
            // detailsTabPage
            // 
            this.detailsTabPage.AutoScroll = true;
            this.detailsTabPage.Controls.Add(this.groupBox6);
            this.detailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.detailsTabPage.Name = "detailsTabPage";
            this.detailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.detailsTabPage.Size = new System.Drawing.Size(569, 165);
            this.detailsTabPage.TabIndex = 0;
            this.detailsTabPage.Text = "Details";
            this.detailsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(typeLabel);
            this.groupBox6.Controls.Add(this.typeComboBox);
            this.groupBox6.Controls.Add(statusLabel);
            this.groupBox6.Controls.Add(this.statusComboBox);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(dateLabel);
            this.groupBox6.Controls.Add(this.dateDateTimePicker);
            this.groupBox6.Controls.Add(firstNameLabel);
            this.groupBox6.Controls.Add(this.firstNameTextBox);
            this.groupBox6.Controls.Add(lastNameLabel);
            this.groupBox6.Controls.Add(this.lastNameTextBox);
            this.groupBox6.Location = new System.Drawing.Point(6, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(563, 164);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Mow",
            "Leaf",
            "Gutter",
            "App",
            "Prune",
            "Mulch",
            "Other"});
            this.typeComboBox.Location = new System.Drawing.Point(80, 97);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(183, 21);
            this.typeComboBox.TabIndex = 51;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Deferred",
            "Abandoned",
            "Completed"});
            this.statusComboBox.Location = new System.Drawing.Point(80, 124);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(183, 21);
            this.statusComboBox.TabIndex = 50;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addressTextBox);
            this.groupBox4.Controls.Add(addressLabel);
            this.groupBox4.Controls.Add(this.cityTextBox);
            this.groupBox4.Controls.Add(cityLabel);
            this.groupBox4.Controls.Add(this.stateTextBox);
            this.groupBox4.Controls.Add(stateLabel);
            this.groupBox4.Controls.Add(this.subdivisionTextBox);
            this.groupBox4.Controls.Add(subdivisionLabel);
            this.groupBox4.Location = new System.Drawing.Point(269, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 125);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Property ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(74, 19);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(166, 18);
            this.addressTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(74, 45);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(166, 18);
            this.cityTextBox.TabIndex = 7;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(74, 71);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(54, 18);
            this.stateTextBox.TabIndex = 9;
            // 
            // subdivisionTextBox
            // 
            this.subdivisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Subdivision", true));
            this.subdivisionTextBox.Location = new System.Drawing.Point(74, 97);
            this.subdivisionTextBox.Name = "subdivisionTextBox";
            this.subdivisionTextBox.ReadOnly = true;
            this.subdivisionTextBox.Size = new System.Drawing.Size(166, 18);
            this.subdivisionTextBox.TabIndex = 11;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.custPropertyJobsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(80, 71);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(183, 18);
            this.dateDateTimePicker.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(80, 15);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(117, 18);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(80, 41);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(117, 18);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // costTabPage
            // 
            this.costTabPage.AutoScroll = true;
            this.costTabPage.Controls.Add(this.groupBox3);
            this.costTabPage.Location = new System.Drawing.Point(4, 22);
            this.costTabPage.Name = "costTabPage";
            this.costTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.costTabPage.Size = new System.Drawing.Size(569, 165);
            this.costTabPage.TabIndex = 4;
            this.costTabPage.Text = "Cost";
            this.costTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(costDLabel);
            this.groupBox3.Controls.Add(this.costDTextBox);
            this.groupBox3.Controls.Add(fourStepMatLabel);
            this.groupBox3.Controls.Add(this.fourStepMatTextBox);
            this.groupBox3.Controls.Add(this.fourStepJobCheckBox);
            this.groupBox3.Controls.Add(costCLabel);
            this.groupBox3.Controls.Add(this.costCTextBox);
            this.groupBox3.Controls.Add(qBInvoiceIDLabel);
            this.groupBox3.Controls.Add(this.qBInvoiceIDTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.PMH);
            this.groupBox3.Controls.Add(revenueLabel);
            this.groupBox3.Controls.Add(this.revenueTextBox);
            this.groupBox3.Controls.Add(materialCostLabel);
            this.groupBox3.Controls.Add(this.materialCostTextBox);
            this.groupBox3.Controls.Add(costBLabel);
            this.groupBox3.Controls.Add(this.costBTextBox);
            this.groupBox3.Controls.Add(manHoursLabel);
            this.groupBox3.Controls.Add(this.manHoursTextBox);
            this.groupBox3.Controls.Add(costFourStepLabel);
            this.groupBox3.Controls.Add(this.costFourStepTextBox);
            this.groupBox3.Controls.Add(costContractorLabel);
            this.groupBox3.Controls.Add(this.costContractorTextBox);
            this.groupBox3.Controls.Add(this.costTextBox);
            this.groupBox3.Controls.Add(costLabel);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 159);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // fourStepMatTextBox
            // 
            this.fourStepMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "FourStepMat", true));
            this.fourStepMatTextBox.Location = new System.Drawing.Point(401, 123);
            this.fourStepMatTextBox.Name = "fourStepMatTextBox";
            this.fourStepMatTextBox.ReadOnly = true;
            this.fourStepMatTextBox.Size = new System.Drawing.Size(100, 18);
            this.fourStepMatTextBox.TabIndex = 70;
            // 
            // fourStepJobCheckBox
            // 
            this.fourStepJobCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.custPropertyJobsBindingSource, "FourStepJob", true));
            this.fourStepJobCheckBox.Location = new System.Drawing.Point(397, 16);
            this.fourStepJobCheckBox.Name = "fourStepJobCheckBox";
            this.fourStepJobCheckBox.Size = new System.Drawing.Size(104, 24);
            this.fourStepJobCheckBox.TabIndex = 69;
            this.fourStepJobCheckBox.Text = "Four Step Job";
            this.fourStepJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // costCTextBox
            // 
            this.costCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "CostC", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costCTextBox.Location = new System.Drawing.Point(276, 97);
            this.costCTextBox.Name = "costCTextBox";
            this.costCTextBox.ReadOnly = true;
            this.costCTextBox.Size = new System.Drawing.Size(97, 18);
            this.costCTextBox.TabIndex = 68;
            // 
            // qBInvoiceIDTextBox
            // 
            this.qBInvoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "QBInvoiceID", true));
            this.qBInvoiceIDTextBox.Location = new System.Drawing.Point(276, 14);
            this.qBInvoiceIDTextBox.Name = "qBInvoiceIDTextBox";
            this.qBInvoiceIDTextBox.ReadOnly = true;
            this.qBInvoiceIDTextBox.Size = new System.Drawing.Size(97, 18);
            this.qBInvoiceIDTextBox.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "PMH:";
            // 
            // PMH
            // 
            this.PMH.Location = new System.Drawing.Point(83, 71);
            this.PMH.Name = "PMH";
            this.PMH.ReadOnly = true;
            this.PMH.Size = new System.Drawing.Size(95, 18);
            this.PMH.TabIndex = 58;
            // 
            // revenueTextBox
            // 
            this.revenueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Revenue", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.revenueTextBox.Location = new System.Drawing.Point(83, 44);
            this.revenueTextBox.Name = "revenueTextBox";
            this.revenueTextBox.Size = new System.Drawing.Size(95, 18);
            this.revenueTextBox.TabIndex = 57;
            // 
            // materialCostTextBox
            // 
            this.materialCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "MaterialCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.materialCostTextBox.Location = new System.Drawing.Point(84, 97);
            this.materialCostTextBox.Name = "materialCostTextBox";
            this.materialCostTextBox.Size = new System.Drawing.Size(95, 18);
            this.materialCostTextBox.TabIndex = 56;
            // 
            // costBTextBox
            // 
            this.costBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "CostB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costBTextBox.Location = new System.Drawing.Point(276, 70);
            this.costBTextBox.Name = "costBTextBox";
            this.costBTextBox.ReadOnly = true;
            this.costBTextBox.Size = new System.Drawing.Size(97, 18);
            this.costBTextBox.TabIndex = 54;
            // 
            // manHoursTextBox
            // 
            this.manHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "ManHours", true));
            this.manHoursTextBox.Location = new System.Drawing.Point(83, 20);
            this.manHoursTextBox.Name = "manHoursTextBox";
            this.manHoursTextBox.Size = new System.Drawing.Size(95, 18);
            this.manHoursTextBox.TabIndex = 53;
            // 
            // costFourStepTextBox
            // 
            this.costFourStepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "CostFourStep", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costFourStepTextBox.Location = new System.Drawing.Point(401, 74);
            this.costFourStepTextBox.Name = "costFourStepTextBox";
            this.costFourStepTextBox.ReadOnly = true;
            this.costFourStepTextBox.Size = new System.Drawing.Size(100, 18);
            this.costFourStepTextBox.TabIndex = 51;
            // 
            // costContractorTextBox
            // 
            this.costContractorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "CostContractor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costContractorTextBox.Location = new System.Drawing.Point(83, 123);
            this.costContractorTextBox.Name = "costContractorTextBox";
            this.costContractorTextBox.Size = new System.Drawing.Size(96, 18);
            this.costContractorTextBox.TabIndex = 49;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costTextBox.Location = new System.Drawing.Point(276, 44);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(97, 18);
            this.costTextBox.TabIndex = 47;
            // 
            // instructTabPage
            // 
            this.instructTabPage.Controls.Add(this.instructionsTextBox);
            this.instructTabPage.Location = new System.Drawing.Point(4, 22);
            this.instructTabPage.Name = "instructTabPage";
            this.instructTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.instructTabPage.Size = new System.Drawing.Size(569, 165);
            this.instructTabPage.TabIndex = 1;
            this.instructTabPage.Text = "Instructions";
            this.instructTabPage.UseVisualStyleBackColor = true;
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Instructions", true));
            this.instructionsTextBox.Location = new System.Drawing.Point(6, 6);
            this.instructionsTextBox.MaxLength = 1000;
            this.instructionsTextBox.Multiline = true;
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.Size = new System.Drawing.Size(557, 153);
            this.instructionsTextBox.TabIndex = 44;
            // 
            // notesTabPage
            // 
            this.notesTabPage.Controls.Add(this.notesTextBox);
            this.notesTabPage.Location = new System.Drawing.Point(4, 22);
            this.notesTabPage.Name = "notesTabPage";
            this.notesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.notesTabPage.Size = new System.Drawing.Size(569, 165);
            this.notesTabPage.TabIndex = 5;
            this.notesTabPage.Text = "Notes";
            this.notesTabPage.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(6, 6);
            this.notesTextBox.MaxLength = 1000;
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(557, 153);
            this.notesTextBox.TabIndex = 45;
            // 
            // modifyWorkButton
            // 
            this.modifyWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modifyWorkButton.Location = new System.Drawing.Point(497, 216);
            this.modifyWorkButton.Name = "modifyWorkButton";
            this.modifyWorkButton.Size = new System.Drawing.Size(75, 23);
            this.modifyWorkButton.TabIndex = 43;
            this.modifyWorkButton.Text = "Edit";
            this.modifyWorkButton.UseVisualStyleBackColor = true;
            this.modifyWorkButton.Click += new System.EventHandler(this.modifyWorkButton_Click);
            // 
            // customerJobBindingSource
            // 
            this.customerJobBindingSource.DataMember = "CustomerJob";
            this.customerJobBindingSource.DataSource = this.mMSDataSet;
            // 
            // titleStrip1
            // 
            this.titleStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.titleStrip1.DrawEndLine = false;
            this.titleStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.titleStrip1.GradientEndColor = System.Drawing.Color.White;
            this.titleStrip1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(214)))));
            this.titleStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titleStrip1.Lines = 10;
            this.titleStrip1.Location = new System.Drawing.Point(0, 0);
            this.titleStrip1.Name = "titleStrip1";
            this.titleStrip1.Size = new System.Drawing.Size(881, 25);
            this.titleStrip1.TabIndex = 36;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // custPropertyJobsTableAdapter
            // 
            this.custPropertyJobsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BonusTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = null;
            this.tableAdapterManager.CustomerNewsletterTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = null;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = this.custPropertyJobsTableAdapter;
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
            // crewNameTableAdapter
            // 
            this.crewNameTableAdapter.ClearBeforeFill = true;
            // 
            // customerJobTableAdapter
            // 
            this.customerJobTableAdapter.ClearBeforeFill = true;
            // 
            // jobStatusListTableAdapter
            // 
            this.jobStatusListTableAdapter.ClearBeforeFill = true;
            // 
            // routeListTableAdapter
            // 
            this.routeListTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter1
            // 
            this.routeTableAdapter1.ClearBeforeFill = true;
            // 
            // customerNewletterBindingSource
            // 
            this.customerNewletterBindingSource.DataMember = "CustomerNewletter";
            this.customerNewletterBindingSource.DataSource = this.mMSDataSet;
            // 
            // customerNewsletterTableAdapter
            // 
            this.customerNewsletterTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // costDLabel
            // 
            costDLabel.AutoSize = true;
            costDLabel.Location = new System.Drawing.Point(225, 127);
            costDLabel.Name = "costDLabel";
            costDLabel.Size = new System.Drawing.Size(42, 13);
            costDLabel.TabIndex = 70;
            costDLabel.Text = "Cost D:";
            // 
            // costDTextBox
            // 
            this.costDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "CostD", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costDTextBox.Location = new System.Drawing.Point(276, 122);
            this.costDTextBox.Name = "costDTextBox";
            this.costDTextBox.ReadOnly = true;
            this.costDTextBox.Size = new System.Drawing.Size(97, 18);
            this.costDTextBox.TabIndex = 71;
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobStatusListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingNavigator)).EndInit();
            this.custPropertyJobsBindingNavigator.ResumeLayout(false);
            this.custPropertyJobsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crewNameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewNameBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.detailsTabPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.costTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.instructTabPage.ResumeLayout(false);
            this.instructTabPage.PerformLayout();
            this.notesTabPage.ResumeLayout(false);
            this.notesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNewletterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private Button modifyWorkButton;
        private TitleStrip titleStrip1;
        private BindingSource custPropertyJobsBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter custPropertyJobsTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator custPropertyJobsBindingNavigator;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private DataGridViewControls.ExtendedDataGridView extendedDataGridView1;
        private TextBox lastNameTextBox;
        private TextBox subdivisionTextBox;
        private TextBox stateTextBox;
        private TextBox cityTextBox;
        private TextBox addressTextBox;
        private TextBox firstNameTextBox;
        private TextBox instructionsTextBox;
        private TabControl tabControl1;
        private TabPage detailsTabPage;
        private TabPage instructTabPage;
        private DateTimePicker dateDateTimePicker;
        private Button deleteButton;
        private Button cancelButton;
        private BindingSource crewNameBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CrewNameTableAdapter crewNameTableAdapter;
        private GroupBox groupBox4;
        private TabPage costTabPage;
        private GroupBox groupBox3;
        private Button crewButton;
        private Button setJobStatusButton;
        private Button assignCrewButton;
        private ComboBox JobStatusFilterComboBox;
        private BindingSource customerJobBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter customerJobTableAdapter;
        private ComboBox statusComboBox;
        private ComboBox typeComboBox;
        private DateTimePicker fromDateTimePickerFilter;
        private Label label3;
        private Label label2;
        private DateTimePicker toDateTimePickerFilter;
        private CheckBox todayFilterCheckBox;
        private BindingSource jobStatusListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter jobStatusListTableAdapter;
        private CheckBox showAllDatesCheckBox;
        private ComboBox JobTypeFilterComboBox;
        private BindingSource routeListBindingSource;
        private Label label4;
        private Label label1;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter routeListTableAdapter;
        private TextBox manHoursTextBox;
        private TextBox costFourStepTextBox;
        private TextBox costContractorTextBox;
        private TextBox costTextBox;
        private GroupBox groupBox5;
        private DataGridView crewNameDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter routeTableAdapter1;
        private TextBox costBTextBox;
        private TextBox materialCostTextBox;
        private TextBox PMH;
        private TextBox revenueTextBox;
        private Label label5;
        private BindingSource customerNewletterBindingSource;
        private Data.MMSDataSetTableAdapters.CustomerNewsletterTableAdapter customerNewsletterTableAdapter;
        private TextBox qBInvoiceIDTextBox;
        private Button QBInvoiceButton;
        private TextBox costCTextBox;
        private Button PrintSheetsButton;
        private CheckBox fourStepJobCheckBox;
        private TextBox fourStepMatTextBox;
        private CheckBox FourStepFilterCheckBox;
        private CheckBox NotInvoiceCheckBox;
        private CheckBox NoDateCheckBox;
        private Button ClearDateButton;
        private TabPage notesTabPage;
        private TextBox notesTextBox;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Subdivision;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn PropertyID;
        private DataGridViewTextBoxColumn CrewKey;
        private DataGridViewCheckBoxColumn FourStepJob;
        private DataGridViewTextBoxColumn QBInvoiceID;
        private DataGridViewTextBoxColumn QBItemID;
        private DataGridViewTextBoxColumn QBItemIDB;
        private DataGridViewTextBoxColumn QBItemIDC;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn GutterRegion;
        private DataGridViewTextBoxColumn Notes;
        private DataGridViewTextBoxColumn FourStepMat;
        private DataGridViewCheckBoxColumn FourStepJob1;
        private DataGridViewCheckBoxColumn FourStepJob2;
        private DataGridViewCheckBoxColumn FourStepJob3;
        private DataGridViewCheckBoxColumn FourStepJob4;
        private TextBox costDTextBox;


    }
}
