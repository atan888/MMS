namespace System.Windows.Forms.MMS.Views
{
    partial class ServiceFourStepView
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label subdivisionLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label fourStepCostLabel;
            System.Windows.Forms.Label fourStepMatLabel;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label fourStepDate4Label;
            System.Windows.Forms.Label fourStepDate3Label;
            System.Windows.Forms.Label fourStepDate2Label;
            System.Windows.Forms.Label fourStepDate1Label;
            System.Windows.Forms.Label yCost4StepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceFourStepView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleStrip1 = new System.Windows.Forms.MMS.TitleStrip();
            this.propServiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.propServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceDataGridView = new DataGridViewControls.ExtendedDataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subdivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourStepType1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepType2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepType3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FourStepType4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FourStepFilterCheckbox = new System.Windows.Forms.CheckBox();
            this.AllFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.customerTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaveFourStepJobButton = new System.Windows.Forms.Button();
            this.clearJobButton = new System.Windows.Forms.Button();
            this.TotalNumLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Step1Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Step3Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Step4Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.JobFilterComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.fourStepTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.fourStepType4CheckBox = new System.Windows.Forms.CheckBox();
            this.fourStepType2CheckBox = new System.Windows.Forms.CheckBox();
            this.fourStepType3CheckBox = new System.Windows.Forms.CheckBox();
            this.fourStepType1CheckBox = new System.Windows.Forms.CheckBox();
            this.fourStepDate1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fourStepDate4DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fourStepDate3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fourStepDate2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.subdivisionTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.tabFourStep = new System.Windows.Forms.TabPage();
            this.yCost4StepComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetFourStepButton = new System.Windows.Forms.Button();
            this.fourStepCostTextBox = new System.Windows.Forms.TextBox();
            this.fourStepMatTextBox = new System.Windows.Forms.TextBox();
            this.tabFourStepOtherInst = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fourStepInstructTextBox = new System.Windows.Forms.TextBox();
            this.tabNotes = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerJobTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter();
            this.serviceTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.ServiceTableAdapter();
            this.routeTableAdapter1 = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter();
            this.customerTypeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.propServiceTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.PropServiceTableAdapter();
            this.customerJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobStatusListTableAdapter1 = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter();
            descriptionLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            subdivisionLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            fourStepCostLabel = new System.Windows.Forms.Label();
            fourStepMatLabel = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            fourStepDate4Label = new System.Windows.Forms.Label();
            fourStepDate3Label = new System.Windows.Forms.Label();
            fourStepDate2Label = new System.Windows.Forms.Label();
            fourStepDate1Label = new System.Windows.Forms.Label();
            yCost4StepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.propServiceBindingNavigator)).BeginInit();
            this.propServiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).BeginInit();
            this.jobGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabFourStep.SuspendLayout();
            this.tabFourStepOtherInst.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 82);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(11, 53);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(12, 25);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 20;
            firstNameLabel.Text = "First Name:";
            // 
            // subdivisionLabel
            // 
            subdivisionLabel.AutoSize = true;
            subdivisionLabel.Location = new System.Drawing.Point(239, 26);
            subdivisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subdivisionLabel.Name = "subdivisionLabel";
            subdivisionLabel.Size = new System.Drawing.Size(84, 17);
            subdivisionLabel.TabIndex = 19;
            subdivisionLabel.Text = "Subdivision:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(291, 112);
            zipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 17);
            zipLabel.TabIndex = 18;
            zipLabel.Text = "Zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(277, 84);
            stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 17;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(288, 54);
            cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(28, 111);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Address:";
            // 
            // fourStepCostLabel
            // 
            fourStepCostLabel.AutoSize = true;
            fourStepCostLabel.Location = new System.Drawing.Point(53, 49);
            fourStepCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepCostLabel.Name = "fourStepCostLabel";
            fourStepCostLabel.Size = new System.Drawing.Size(106, 17);
            fourStepCostLabel.TabIndex = 50;
            fourStepCostLabel.Text = "Four Step Cost:";
            // 
            // fourStepMatLabel
            // 
            fourStepMatLabel.AutoSize = true;
            fourStepMatLabel.Location = new System.Drawing.Point(24, 21);
            fourStepMatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepMatLabel.Name = "fourStepMatLabel";
            fourStepMatLabel.Size = new System.Drawing.Size(135, 17);
            fourStepMatLabel.TabIndex = 26;
            fourStepMatLabel.Text = "Four Step Materials:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(4, 0);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(122, 17);
            label15.TabIndex = 63;
            label15.Text = "4 Step Instruction:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(4, 4);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(111, 17);
            label20.TabIndex = 3;
            label20.Text = "Notes/Commets:";
            // 
            // fourStepDate4Label
            // 
            fourStepDate4Label.AutoSize = true;
            fourStepDate4Label.Location = new System.Drawing.Point(500, 114);
            fourStepDate4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepDate4Label.Name = "fourStepDate4Label";
            fourStepDate4Label.Size = new System.Drawing.Size(53, 17);
            fourStepDate4Label.TabIndex = 42;
            fourStepDate4Label.Text = "Step 4:";
            // 
            // fourStepDate3Label
            // 
            fourStepDate3Label.AutoSize = true;
            fourStepDate3Label.Location = new System.Drawing.Point(500, 87);
            fourStepDate3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepDate3Label.Name = "fourStepDate3Label";
            fourStepDate3Label.Size = new System.Drawing.Size(53, 17);
            fourStepDate3Label.TabIndex = 40;
            fourStepDate3Label.Text = "Step 3:";
            // 
            // fourStepDate2Label
            // 
            fourStepDate2Label.AutoSize = true;
            fourStepDate2Label.Location = new System.Drawing.Point(501, 57);
            fourStepDate2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepDate2Label.Name = "fourStepDate2Label";
            fourStepDate2Label.Size = new System.Drawing.Size(53, 17);
            fourStepDate2Label.TabIndex = 38;
            fourStepDate2Label.Text = "Step 2:";
            // 
            // fourStepDate1Label
            // 
            fourStepDate1Label.AutoSize = true;
            fourStepDate1Label.Location = new System.Drawing.Point(501, 25);
            fourStepDate1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fourStepDate1Label.Name = "fourStepDate1Label";
            fourStepDate1Label.Size = new System.Drawing.Size(49, 17);
            fourStepDate1Label.TabIndex = 36;
            fourStepDate1Label.Text = "Step1:";
            // 
            // yCost4StepLabel
            // 
            yCost4StepLabel.AutoSize = true;
            yCost4StepLabel.Location = new System.Drawing.Point(117, 75);
            yCost4StepLabel.Name = "yCost4StepLabel";
            yCost4StepLabel.Size = new System.Drawing.Size(42, 17);
            yCost4StepLabel.TabIndex = 54;
            yCost4StepLabel.Text = "Year:";
            yCost4StepLabel.Visible = false;
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
            this.titleStrip1.Size = new System.Drawing.Size(1219, 25);
            this.titleStrip1.TabIndex = 1;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // propServiceBindingNavigator
            // 
            this.propServiceBindingNavigator.AddNewItem = null;
            this.propServiceBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.propServiceBindingNavigator.BindingSource = this.propServiceBindingSource;
            this.propServiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propServiceBindingNavigator.DeleteItem = null;
            this.propServiceBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.propServiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.propServiceBindingNavigator.Location = new System.Drawing.Point(938, 527);
            this.propServiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propServiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propServiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propServiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propServiceBindingNavigator.Name = "propServiceBindingNavigator";
            this.propServiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propServiceBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.propServiceBindingNavigator.Size = new System.Drawing.Size(234, 27);
            this.propServiceBindingNavigator.TabIndex = 4;
            this.propServiceBindingNavigator.Text = "bindingNavigator1";
            // 
            // propServiceBindingSource
            // 
            this.propServiceBindingSource.DataMember = "PropService";
            this.propServiceBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AllowUserToAddRows = false;
            this.serviceDataGridView.AllowUserToDeleteRows = false;
            this.serviceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Address,
            this.City,
            this.Subdivision,
            this.FourStepType1,
            this.FourStepType2,
            this.FourStepType3,
            this.FourStepType4,
            this.GroupType,
            this.ServiceID,
            this.PropertyID});
            this.serviceDataGridView.DataSource = this.propServiceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.serviceDataGridView.Location = new System.Drawing.Point(20, 23);
            this.serviceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.serviceDataGridView.Name = "serviceDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.serviceDataGridView.RowTemplate.Height = 24;
            this.serviceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceDataGridView.Size = new System.Drawing.Size(1152, 469);
            this.serviceDataGridView.TabIndex = 5;
            this.serviceDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDataGridView_CellValueChanged);
            this.serviceDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.serviceDataGridView_ColumnHeaderMouseClick);
            this.serviceDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.serviceDataGridView_CurrentCellDirtyStateChanged);
            this.serviceDataGridView.SelectionChanged += new System.EventHandler(this.serviceDataGridView_SelectionChanged);
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
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 125F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 158;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Subdivision
            // 
            this.Subdivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subdivision.DataPropertyName = "Subdivision";
            this.Subdivision.HeaderText = "Subdivision";
            this.Subdivision.Name = "Subdivision";
            this.Subdivision.ReadOnly = true;
            // 
            // FourStepType1
            // 
            this.FourStepType1.DataPropertyName = "FourStepType1";
            this.FourStepType1.HeaderText = "Step1";
            this.FourStepType1.Name = "FourStepType1";
            this.FourStepType1.Width = 40;
            // 
            // FourStepType2
            // 
            this.FourStepType2.DataPropertyName = "FourStepType2";
            this.FourStepType2.HeaderText = "Step2";
            this.FourStepType2.Name = "FourStepType2";
            this.FourStepType2.Width = 40;
            // 
            // FourStepType3
            // 
            this.FourStepType3.DataPropertyName = "FourStepType3";
            this.FourStepType3.HeaderText = "Step3";
            this.FourStepType3.Name = "FourStepType3";
            this.FourStepType3.Width = 40;
            // 
            // FourStepType4
            // 
            this.FourStepType4.DataPropertyName = "FourStepType4";
            this.FourStepType4.HeaderText = "Step4";
            this.FourStepType4.Name = "FourStepType4";
            this.FourStepType4.Width = 40;
            // 
            // GroupType
            // 
            this.GroupType.DataPropertyName = "GroupType";
            this.GroupType.HeaderText = "GroupType";
            this.GroupType.Name = "GroupType";
            this.GroupType.Visible = false;
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "ServiceID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Visible = false;
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.serviceDataGridView);
            this.groupBox1.Controls.Add(this.propServiceBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1189, 569);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4-Step Services";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.filterTextBox);
            this.groupBox5.Location = new System.Drawing.Point(409, 500);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(293, 62);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Last Name";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(25, 25);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(241, 22);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.FourStepFilterCheckbox);
            this.groupBox3.Controls.Add(this.AllFilterCheckBox);
            this.groupBox3.Controls.Add(this.FilterComboBox);
            this.groupBox3.Location = new System.Drawing.Point(21, 500);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(380, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // FourStepFilterCheckbox
            // 
            this.FourStepFilterCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FourStepFilterCheckbox.AutoSize = true;
            this.FourStepFilterCheckbox.Location = new System.Drawing.Point(24, 41);
            this.FourStepFilterCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.FourStepFilterCheckbox.Name = "FourStepFilterCheckbox";
            this.FourStepFilterCheckbox.Size = new System.Drawing.Size(125, 21);
            this.FourStepFilterCheckbox.TabIndex = 3;
            this.FourStepFilterCheckbox.Text = "Four Step Only";
            this.FourStepFilterCheckbox.UseVisualStyleBackColor = true;
            this.FourStepFilterCheckbox.CheckedChanged += new System.EventHandler(this.FourStepFilterCheckbox_CheckedChanged);
            // 
            // AllFilterCheckBox
            // 
            this.AllFilterCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AllFilterCheckBox.AutoSize = true;
            this.AllFilterCheckBox.Checked = true;
            this.AllFilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllFilterCheckBox.Location = new System.Drawing.Point(24, 20);
            this.AllFilterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllFilterCheckBox.Name = "AllFilterCheckBox";
            this.AllFilterCheckBox.Size = new System.Drawing.Size(83, 21);
            this.AllFilterCheckBox.TabIndex = 2;
            this.AllFilterCheckBox.Text = "Show All";
            this.AllFilterCheckBox.UseVisualStyleBackColor = true;
            this.AllFilterCheckBox.CheckedChanged += new System.EventHandler(this.AllFilterCheckBox_CheckedChanged);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterComboBox.DataSource = this.customerTypeListBindingSource;
            this.FilterComboBox.DisplayMember = "CustomerType";
            this.FilterComboBox.Enabled = false;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(176, 23);
            this.FilterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(188, 24);
            this.FilterComboBox.TabIndex = 0;
            this.FilterComboBox.ValueMember = "CustomerType";
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // customerTypeListBindingSource
            // 
            this.customerTypeListBindingSource.DataMember = "CustomerTypeList";
            this.customerTypeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.jobGroupBox.Controls.Add(this.groupBox2);
            this.jobGroupBox.Controls.Add(this.tabControl1);
            this.jobGroupBox.Controls.Add(this.editButton);
            this.jobGroupBox.Controls.Add(this.cancelButton);
            this.jobGroupBox.Location = new System.Drawing.Point(16, 617);
            this.jobGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.jobGroupBox.Size = new System.Drawing.Size(1189, 271);
            this.jobGroupBox.TabIndex = 7;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SaveFourStepJobButton);
            this.groupBox2.Controls.Add(this.clearJobButton);
            this.groupBox2.Controls.Add(this.TotalNumLabel);
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.JobFilterComboBox);
            this.groupBox2.Location = new System.Drawing.Point(912, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 255);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pending Jobs";
            // 
            // SaveFourStepJobButton
            // 
            this.SaveFourStepJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveFourStepJobButton.Location = new System.Drawing.Point(141, 208);
            this.SaveFourStepJobButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFourStepJobButton.Name = "SaveFourStepJobButton";
            this.SaveFourStepJobButton.Size = new System.Drawing.Size(117, 38);
            this.SaveFourStepJobButton.TabIndex = 13;
            this.SaveFourStepJobButton.Text = "Create 4Steps";
            this.SaveFourStepJobButton.UseVisualStyleBackColor = true;
            this.SaveFourStepJobButton.Click += new System.EventHandler(this.SaveFourStepJobButton_Click);
            // 
            // clearJobButton
            // 
            this.clearJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearJobButton.Location = new System.Drawing.Point(144, 161);
            this.clearJobButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearJobButton.Name = "clearJobButton";
            this.clearJobButton.Size = new System.Drawing.Size(117, 38);
            this.clearJobButton.TabIndex = 11;
            this.clearJobButton.Text = "Clear";
            this.clearJobButton.UseVisualStyleBackColor = true;
            this.clearJobButton.Click += new System.EventHandler(this.clearJobButton_Click);
            // 
            // TotalNumLabel
            // 
            this.TotalNumLabel.AutoSize = true;
            this.TotalNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumLabel.Location = new System.Drawing.Point(104, 169);
            this.TotalNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalNumLabel.Name = "TotalNumLabel";
            this.TotalNumLabel.Size = new System.Drawing.Size(17, 17);
            this.TotalNumLabel.TabIndex = 1;
            this.TotalNumLabel.Text = "1";
            this.TotalNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Step1Label, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Step2Label, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Step3Label, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.Step4Label, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(9, 54);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(251, 100);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Location = new System.Drawing.Point(71, 0);
            this.Step1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(16, 17);
            this.Step1Label.TabIndex = 6;
            this.Step1Label.Text = "1";
            this.Step1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Location = new System.Drawing.Point(71, 25);
            this.Step2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(16, 17);
            this.Step2Label.TabIndex = 7;
            this.Step2Label.Text = "1";
            this.Step2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Step3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step3Label
            // 
            this.Step3Label.AutoSize = true;
            this.Step3Label.Location = new System.Drawing.Point(71, 50);
            this.Step3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Step3Label.Name = "Step3Label";
            this.Step3Label.Size = new System.Drawing.Size(16, 17);
            this.Step3Label.TabIndex = 8;
            this.Step3Label.Text = "1";
            this.Step3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Step4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step4Label
            // 
            this.Step4Label.AutoSize = true;
            this.Step4Label.Location = new System.Drawing.Point(71, 73);
            this.Step4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Step4Label.Name = "Step4Label";
            this.Step4Label.Size = new System.Drawing.Size(16, 17);
            this.Step4Label.TabIndex = 9;
            this.Step4Label.Text = "1";
            this.Step4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Job";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Job Filter:";
            // 
            // JobFilterComboBox
            // 
            this.JobFilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.JobFilterComboBox.FormattingEnabled = true;
            this.JobFilterComboBox.Items.AddRange(new object[] {
            "None",
            "Step1",
            "Step2",
            "Step3",
            "Step4"});
            this.JobFilterComboBox.Location = new System.Drawing.Point(100, 20);
            this.JobFilterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.JobFilterComboBox.Name = "JobFilterComboBox";
            this.JobFilterComboBox.Size = new System.Drawing.Size(145, 24);
            this.JobFilterComboBox.TabIndex = 5;
            this.JobFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabServices);
            this.tabControl1.Controls.Add(this.tabFourStep);
            this.tabControl1.Controls.Add(this.tabFourStepOtherInst);
            this.tabControl1.Controls.Add(this.tabNotes);
            this.tabControl1.Location = new System.Drawing.Point(17, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 196);
            this.tabControl1.TabIndex = 3;
            // 
            // tabServices
            // 
            this.tabServices.AutoScroll = true;
            this.tabServices.Controls.Add(this.fourStepTypeCheckBox);
            this.tabServices.Controls.Add(this.fourStepType4CheckBox);
            this.tabServices.Controls.Add(this.fourStepType2CheckBox);
            this.tabServices.Controls.Add(this.fourStepType3CheckBox);
            this.tabServices.Controls.Add(this.fourStepType1CheckBox);
            this.tabServices.Controls.Add(this.fourStepDate1DateTimePicker);
            this.tabServices.Controls.Add(this.fourStepDate4DateTimePicker);
            this.tabServices.Controls.Add(fourStepDate4Label);
            this.tabServices.Controls.Add(this.fourStepDate3DateTimePicker);
            this.tabServices.Controls.Add(fourStepDate3Label);
            this.tabServices.Controls.Add(this.fourStepDate2DateTimePicker);
            this.tabServices.Controls.Add(fourStepDate2Label);
            this.tabServices.Controls.Add(fourStepDate1Label);
            this.tabServices.Controls.Add(descriptionLabel);
            this.tabServices.Controls.Add(this.descriptionTextBox);
            this.tabServices.Controls.Add(lastNameLabel);
            this.tabServices.Controls.Add(this.lastNameTextBox);
            this.tabServices.Controls.Add(firstNameLabel);
            this.tabServices.Controls.Add(this.firstNameTextBox);
            this.tabServices.Controls.Add(subdivisionLabel);
            this.tabServices.Controls.Add(this.subdivisionTextBox);
            this.tabServices.Controls.Add(zipLabel);
            this.tabServices.Controls.Add(this.zipTextBox);
            this.tabServices.Controls.Add(stateLabel);
            this.tabServices.Controls.Add(this.stateTextBox);
            this.tabServices.Controls.Add(cityLabel);
            this.tabServices.Controls.Add(this.cityTextBox);
            this.tabServices.Controls.Add(addressLabel);
            this.tabServices.Controls.Add(this.addressTextBox);
            this.tabServices.Location = new System.Drawing.Point(4, 25);
            this.tabServices.Margin = new System.Windows.Forms.Padding(4);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(879, 167);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "General";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // fourStepTypeCheckBox
            // 
            this.fourStepTypeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.propServiceBindingSource, "FourStepType", true));
            this.fourStepTypeCheckBox.Location = new System.Drawing.Point(77, 134);
            this.fourStepTypeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepTypeCheckBox.Name = "fourStepTypeCheckBox";
            this.fourStepTypeCheckBox.Size = new System.Drawing.Size(205, 30);
            this.fourStepTypeCheckBox.TabIndex = 53;
            this.fourStepTypeCheckBox.Text = "Four Step Customer";
            this.fourStepTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // fourStepType4CheckBox
            // 
            this.fourStepType4CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.propServiceBindingSource, "FourStepType4", true));
            this.fourStepType4CheckBox.Location = new System.Drawing.Point(843, 111);
            this.fourStepType4CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepType4CheckBox.Name = "fourStepType4CheckBox";
            this.fourStepType4CheckBox.Size = new System.Drawing.Size(31, 30);
            this.fourStepType4CheckBox.TabIndex = 11;
            this.fourStepType4CheckBox.UseVisualStyleBackColor = true;
            // 
            // fourStepType2CheckBox
            // 
            this.fourStepType2CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.propServiceBindingSource, "FourStepType2", true));
            this.fourStepType2CheckBox.Location = new System.Drawing.Point(843, 48);
            this.fourStepType2CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepType2CheckBox.Name = "fourStepType2CheckBox";
            this.fourStepType2CheckBox.Size = new System.Drawing.Size(29, 30);
            this.fourStepType2CheckBox.TabIndex = 10;
            this.fourStepType2CheckBox.UseVisualStyleBackColor = true;
            // 
            // fourStepType3CheckBox
            // 
            this.fourStepType3CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.propServiceBindingSource, "FourStepType3", true));
            this.fourStepType3CheckBox.Location = new System.Drawing.Point(843, 79);
            this.fourStepType3CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepType3CheckBox.Name = "fourStepType3CheckBox";
            this.fourStepType3CheckBox.Size = new System.Drawing.Size(29, 30);
            this.fourStepType3CheckBox.TabIndex = 10;
            this.fourStepType3CheckBox.UseVisualStyleBackColor = true;
            // 
            // fourStepType1CheckBox
            // 
            this.fourStepType1CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.propServiceBindingSource, "FourStepType1", true));
            this.fourStepType1CheckBox.Location = new System.Drawing.Point(843, 16);
            this.fourStepType1CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepType1CheckBox.Name = "fourStepType1CheckBox";
            this.fourStepType1CheckBox.Size = new System.Drawing.Size(24, 30);
            this.fourStepType1CheckBox.TabIndex = 10;
            this.fourStepType1CheckBox.UseVisualStyleBackColor = true;
            // 
            // fourStepDate1DateTimePicker
            // 
            this.fourStepDate1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.propServiceBindingSource, "FourStepDate1", true));
            this.fourStepDate1DateTimePicker.Location = new System.Drawing.Point(560, 21);
            this.fourStepDate1DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepDate1DateTimePicker.Name = "fourStepDate1DateTimePicker";
            this.fourStepDate1DateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.fourStepDate1DateTimePicker.TabIndex = 37;
            // 
            // fourStepDate4DateTimePicker
            // 
            this.fourStepDate4DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.propServiceBindingSource, "FourStepDate4", true));
            this.fourStepDate4DateTimePicker.Location = new System.Drawing.Point(560, 116);
            this.fourStepDate4DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepDate4DateTimePicker.Name = "fourStepDate4DateTimePicker";
            this.fourStepDate4DateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.fourStepDate4DateTimePicker.TabIndex = 43;
            // 
            // fourStepDate3DateTimePicker
            // 
            this.fourStepDate3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.propServiceBindingSource, "FourStepDate3", true));
            this.fourStepDate3DateTimePicker.Location = new System.Drawing.Point(560, 84);
            this.fourStepDate3DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepDate3DateTimePicker.Name = "fourStepDate3DateTimePicker";
            this.fourStepDate3DateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.fourStepDate3DateTimePicker.TabIndex = 41;
            // 
            // fourStepDate2DateTimePicker
            // 
            this.fourStepDate2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.propServiceBindingSource, "FourStepDate2", true));
            this.fourStepDate2DateTimePicker.Location = new System.Drawing.Point(560, 53);
            this.fourStepDate2DateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepDate2DateTimePicker.Name = "fourStepDate2DateTimePicker";
            this.fourStepDate2DateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.fourStepDate2DateTimePicker.TabIndex = 39;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 79);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(124, 22);
            this.descriptionTextBox.TabIndex = 23;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(104, 49);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(124, 22);
            this.lastNameTextBox.TabIndex = 22;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 21);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(124, 22);
            this.firstNameTextBox.TabIndex = 21;
            // 
            // subdivisionTextBox
            // 
            this.subdivisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "Subdivision", true));
            this.subdivisionTextBox.Location = new System.Drawing.Point(335, 22);
            this.subdivisionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.subdivisionTextBox.Name = "subdivisionTextBox";
            this.subdivisionTextBox.ReadOnly = true;
            this.subdivisionTextBox.Size = new System.Drawing.Size(132, 22);
            this.subdivisionTextBox.TabIndex = 20;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "Zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(335, 108);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(132, 22);
            this.zipTextBox.TabIndex = 19;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(335, 80);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(132, 22);
            this.stateTextBox.TabIndex = 18;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(335, 50);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(132, 22);
            this.cityTextBox.TabIndex = 17;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(104, 107);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(124, 22);
            this.addressTextBox.TabIndex = 16;
            // 
            // tabFourStep
            // 
            this.tabFourStep.AutoScroll = true;
            this.tabFourStep.Controls.Add(this.yCost4StepComboBox);
            this.tabFourStep.Controls.Add(yCost4StepLabel);
            this.tabFourStep.Controls.Add(this.label6);
            this.tabFourStep.Controls.Add(this.label1);
            this.tabFourStep.Controls.Add(this.ResetFourStepButton);
            this.tabFourStep.Controls.Add(this.fourStepCostTextBox);
            this.tabFourStep.Controls.Add(fourStepCostLabel);
            this.tabFourStep.Controls.Add(this.fourStepMatTextBox);
            this.tabFourStep.Controls.Add(fourStepMatLabel);
            this.tabFourStep.Location = new System.Drawing.Point(4, 25);
            this.tabFourStep.Margin = new System.Windows.Forms.Padding(4);
            this.tabFourStep.Name = "tabFourStep";
            this.tabFourStep.Padding = new System.Windows.Forms.Padding(4);
            this.tabFourStep.Size = new System.Drawing.Size(879, 167);
            this.tabFourStep.TabIndex = 1;
            this.tabFourStep.Text = "Four Step";
            this.tabFourStep.UseVisualStyleBackColor = true;
            // 
            // yCost4StepComboBox
            // 
            this.yCost4StepComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "YCost4Step", true));
            this.yCost4StepComboBox.FormattingEnabled = true;
            this.yCost4StepComboBox.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.yCost4StepComboBox.Location = new System.Drawing.Point(179, 72);
            this.yCost4StepComboBox.Name = "yCost4StepComboBox";
            this.yCost4StepComboBox.Size = new System.Drawing.Size(127, 24);
            this.yCost4StepComboBox.TabIndex = 55;
            this.yCost4StepComboBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Should be done begining of each season";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Resets all 4step service dates & flags";
            // 
            // ResetFourStepButton
            // 
            this.ResetFourStepButton.Location = new System.Drawing.Point(28, 114);
            this.ResetFourStepButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetFourStepButton.Name = "ResetFourStepButton";
            this.ResetFourStepButton.Size = new System.Drawing.Size(131, 28);
            this.ResetFourStepButton.TabIndex = 52;
            this.ResetFourStepButton.Text = "Reset 4Step";
            this.ResetFourStepButton.UseVisualStyleBackColor = true;
            this.ResetFourStepButton.Click += new System.EventHandler(this.ResetFourStepButton_Click);
            // 
            // fourStepCostTextBox
            // 
            this.fourStepCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "FourStepCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.fourStepCostTextBox.Location = new System.Drawing.Point(179, 45);
            this.fourStepCostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepCostTextBox.Name = "fourStepCostTextBox";
            this.fourStepCostTextBox.Size = new System.Drawing.Size(127, 22);
            this.fourStepCostTextBox.TabIndex = 51;
            // 
            // fourStepMatTextBox
            // 
            this.fourStepMatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "FourStepMat", true));
            this.fourStepMatTextBox.Location = new System.Drawing.Point(179, 17);
            this.fourStepMatTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepMatTextBox.Name = "fourStepMatTextBox";
            this.fourStepMatTextBox.Size = new System.Drawing.Size(127, 22);
            this.fourStepMatTextBox.TabIndex = 27;
            // 
            // tabFourStepOtherInst
            // 
            this.tabFourStepOtherInst.AutoScroll = true;
            this.tabFourStepOtherInst.Controls.Add(this.tableLayoutPanel1);
            this.tabFourStepOtherInst.Location = new System.Drawing.Point(4, 25);
            this.tabFourStepOtherInst.Margin = new System.Windows.Forms.Padding(4);
            this.tabFourStepOtherInst.Name = "tabFourStepOtherInst";
            this.tabFourStepOtherInst.Padding = new System.Windows.Forms.Padding(4);
            this.tabFourStepOtherInst.Size = new System.Drawing.Size(879, 167);
            this.tabFourStepOtherInst.TabIndex = 7;
            this.tabFourStepOtherInst.Text = "4Step/Other Instruct";
            this.tabFourStepOtherInst.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.fourStepInstructTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(label15, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 159);
            this.tableLayoutPanel1.TabIndex = 66;
            // 
            // fourStepInstructTextBox
            // 
            this.fourStepInstructTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "FourStepInstruct", true));
            this.fourStepInstructTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourStepInstructTextBox.Location = new System.Drawing.Point(4, 29);
            this.fourStepInstructTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fourStepInstructTextBox.MaxLength = 1000;
            this.fourStepInstructTextBox.Multiline = true;
            this.fourStepInstructTextBox.Name = "fourStepInstructTextBox";
            this.fourStepInstructTextBox.Size = new System.Drawing.Size(863, 126);
            this.fourStepInstructTextBox.TabIndex = 62;
            // 
            // tabNotes
            // 
            this.tabNotes.Controls.Add(this.notesTextBox);
            this.tabNotes.Controls.Add(label20);
            this.tabNotes.Location = new System.Drawing.Point(4, 25);
            this.tabNotes.Margin = new System.Windows.Forms.Padding(4);
            this.tabNotes.Name = "tabNotes";
            this.tabNotes.Padding = new System.Windows.Forms.Padding(4);
            this.tabNotes.Size = new System.Drawing.Size(879, 167);
            this.tabNotes.TabIndex = 11;
            this.tabNotes.Text = "Notes";
            this.tabNotes.UseVisualStyleBackColor = true;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propServiceBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(8, 26);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(831, 130);
            this.notesTextBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Location = new System.Drawing.Point(21, 226);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 28);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Location = new System.Drawing.Point(135, 226);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.mMSDataSet;
            // 
            // customerJobTableAdapter
            // 
            this.customerJobTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter1
            // 
            this.routeTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager.CustomerTypeListTableAdapter = null;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = null;
            this.tableAdapterManager.EmployeeBonusTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.JobStatusListTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropServiceTableAdapter = this.propServiceTableAdapter;
            this.tableAdapterManager.RouteListTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfileTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // propServiceTableAdapter
            // 
            this.propServiceTableAdapter.ClearBeforeFill = true;
            // 
            // customerJobBindingSource
            // 
            this.customerJobBindingSource.DataMember = "CustomerJob";
            this.customerJobBindingSource.DataSource = this.mMSDataSet;
            // 
            // jobStatusListTableAdapter1
            // 
            this.jobStatusListTableAdapter1.ClearBeforeFill = true;
            // 
            // ServiceFourStepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceFourStepView";
            this.Size = new System.Drawing.Size(1219, 898);
            ((System.ComponentModel.ISupportInitialize)(this.propServiceBindingNavigator)).EndInit();
            this.propServiceBindingNavigator.ResumeLayout(false);
            this.propServiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).EndInit();
            this.jobGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.tabFourStep.ResumeLayout(false);
            this.tabFourStep.PerformLayout();
            this.tabFourStepOtherInst.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabNotes.ResumeLayout(false);
            this.tabNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TitleStrip titleStrip1;
        private BindingSource customerTypeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter customerJobTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter routeTableAdapter1;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter customerTypeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.PropServiceTableAdapter propServiceTableAdapter;
        private BindingSource customerJobBindingSource;
        private BindingSource propServiceBindingSource;
        private BindingNavigator propServiceBindingNavigator;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private BindingSource serviceBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.JobStatusListTableAdapter jobStatusListTableAdapter1;
        private DataGridViewControls.ExtendedDataGridView serviceDataGridView;
        private GroupBox groupBox1;
        private GroupBox jobGroupBox;
        private GroupBox groupBox2;
        private Button SaveFourStepJobButton;
        private Button clearJobButton;
        private Label TotalNumLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private Label Step1Label;
        private Label label3;
        private Label Step2Label;
        private Label label4;
        private Label Step3Label;
        private Label label5;
        private Label Step4Label;
        private Label label9;
        private Label label7;
        private ComboBox JobFilterComboBox;
        private TabControl tabControl1;
        private TabPage tabServices;
        private TextBox descriptionTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox subdivisionTextBox;
        private TextBox zipTextBox;
        private TextBox stateTextBox;
        private TextBox cityTextBox;
        private TextBox addressTextBox;
        private TabPage tabFourStep;
        private TextBox fourStepCostTextBox;
        private TextBox fourStepMatTextBox;
        private TabPage tabFourStepOtherInst;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox fourStepInstructTextBox;
        private TabPage tabNotes;
        private TextBox notesTextBox;
        private Button editButton;
        private Button cancelButton;
        private DateTimePicker fourStepDate1DateTimePicker;
        private DateTimePicker fourStepDate4DateTimePicker;
        private DateTimePicker fourStepDate3DateTimePicker;
        private DateTimePicker fourStepDate2DateTimePicker;
        private GroupBox groupBox5;
        private TextBox filterTextBox;
        private GroupBox groupBox3;
        private CheckBox AllFilterCheckBox;
        private ComboBox FilterComboBox;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Subdivision;
        private DataGridViewCheckBoxColumn FourStepType1;
        private DataGridViewCheckBoxColumn FourStepType2;
        private DataGridViewCheckBoxColumn FourStepType3;
        private DataGridViewCheckBoxColumn FourStepType4;
        private DataGridViewTextBoxColumn GroupType;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn PropertyID;
        private CheckBox fourStepType2CheckBox;
        private CheckBox fourStepType1CheckBox;
        private CheckBox fourStepType4CheckBox;
        private CheckBox fourStepType3CheckBox;
        private CheckBox fourStepTypeCheckBox;
        private CheckBox FourStepFilterCheckbox;
        private Button ResetFourStepButton;
        private Label label1;
        private Label label6;
        private ComboBox yCost4StepComboBox;
    }
}