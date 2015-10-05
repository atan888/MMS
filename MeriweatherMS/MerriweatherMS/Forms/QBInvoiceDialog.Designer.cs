namespace System.Windows.Forms
{
    partial class QBInvoiceDialog
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
            System.Windows.Forms.Label costCLabel;
            System.Windows.Forms.Label qBInvoiceIDLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label costBLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            this.costCTextBox = new System.Windows.Forms.TextBox();
            this.customerJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.qBInvoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemComboBox3 = new System.Windows.Forms.ComboBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemGroupBox3 = new System.Windows.Forms.GroupBox();
            this.DescTextBox3 = new System.Windows.Forms.ComboBox();
            this.qbItemIDCTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DescTextBox1 = new System.Windows.Forms.ComboBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.ItemComboBox1 = new System.Windows.Forms.ComboBox();
            this.qbItemIDTextBox = new System.Windows.Forms.TextBox();
            this.ItemGroupBox2 = new System.Windows.Forms.GroupBox();
            this.DescTextBox2 = new System.Windows.Forms.ComboBox();
            this.costBTextBox = new System.Windows.Forms.TextBox();
            this.ItemComboBox2 = new System.Windows.Forms.ComboBox();
            this.qbItemIDBTextBox = new System.Windows.Forms.TextBox();
            this.JobdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.custPropertyJobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ItemBCheckBox = new System.Windows.Forms.CheckBox();
            this.AppendAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemGroupBox4 = new System.Windows.Forms.GroupBox();
            this.DescTextBox4 = new System.Windows.Forms.ComboBox();
            this.ItemComboBox4 = new System.Windows.Forms.ComboBox();
            this.qbItemIDDTextBox = new System.Windows.Forms.TextBox();
            this.costDTextBox = new System.Windows.Forms.TextBox();
            this.customerJobTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.custPropertyJobsTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter();
            this.propertyTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.PropertyTableAdapter();
            this.ItemDCheckBox = new System.Windows.Forms.CheckBox();
            this.ItemCCheckBox = new System.Windows.Forms.CheckBox();
            costCLabel = new System.Windows.Forms.Label();
            qBInvoiceIDLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            costBLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            this.ItemGroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ItemGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            this.ItemGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // costCLabel
            // 
            costCLabel.AutoSize = true;
            costCLabel.Location = new System.Drawing.Point(38, 41);
            costCLabel.Name = "costCLabel";
            costCLabel.Size = new System.Drawing.Size(41, 13);
            costCLabel.TabIndex = 2;
            costCLabel.Text = "Cost C:";
            // 
            // qBInvoiceIDLabel
            // 
            qBInvoiceIDLabel.AutoSize = true;
            qBInvoiceIDLabel.Location = new System.Drawing.Point(18, 58);
            qBInvoiceIDLabel.Name = "qBInvoiceIDLabel";
            qBInvoiceIDLabel.Size = new System.Drawing.Size(74, 13);
            qBInvoiceIDLabel.TabIndex = 0;
            qBInvoiceIDLabel.Text = "QBInvoice ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(200, 38);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 13);
            label4.TabIndex = 4;
            label4.Text = "Item Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 13);
            label5.TabIndex = 6;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(18, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(85, 13);
            label6.TabIndex = 6;
            label6.Text = "Customer Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(20, 17);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 13);
            label7.TabIndex = 0;
            label7.Text = "QBItem ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "QBItem ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(200, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 4;
            label3.Text = "Item Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(16, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 13);
            label8.TabIndex = 6;
            label8.Text = "Description:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(20, 17);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(59, 13);
            label9.TabIndex = 0;
            label9.Text = "QBItem ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(200, 38);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(58, 13);
            label11.TabIndex = 4;
            label11.Text = "Item Code:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(16, 61);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(63, 13);
            label12.TabIndex = 6;
            label12.Text = "Description:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(336, 35);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(53, 13);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Job Date:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(38, 39);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(41, 13);
            costLabel.TabIndex = 2;
            costLabel.Text = "Cost A:";
            // 
            // costBLabel
            // 
            costBLabel.AutoSize = true;
            costBLabel.Location = new System.Drawing.Point(38, 41);
            costBLabel.Name = "costBLabel";
            costBLabel.Size = new System.Drawing.Size(41, 13);
            costBLabel.TabIndex = 2;
            costBLabel.Text = "Cost B:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(335, 12);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(54, 13);
            typeLabel.TabIndex = 2;
            typeLabel.Text = "Job Type:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(49, 35);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 13);
            label2.TabIndex = 0;
            label2.Text = "QBItem ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(38, 41);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(42, 13);
            label10.TabIndex = 2;
            label10.Text = "Cost D:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(200, 38);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(58, 13);
            label13.TabIndex = 4;
            label13.Text = "Item Code:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(16, 63);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(63, 13);
            label14.TabIndex = 6;
            label14.Text = "Description:";
            // 
            // costCTextBox
            // 
            this.costCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "CostC", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.costCTextBox.Location = new System.Drawing.Point(85, 37);
            this.costCTextBox.Name = "costCTextBox";
            this.costCTextBox.Size = new System.Drawing.Size(100, 20);
            this.costCTextBox.TabIndex = 3;
            this.costCTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged_1);
            // 
            // customerJobBindingSource
            // 
            this.customerJobBindingSource.DataMember = "CustomerJob";
            this.customerJobBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qBInvoiceIDTextBox
            // 
            this.qBInvoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "QBInvoiceID", true));
            this.qBInvoiceIDTextBox.Location = new System.Drawing.Point(110, 54);
            this.qBInvoiceIDTextBox.Name = "qBInvoiceIDTextBox";
            this.qBInvoiceIDTextBox.ReadOnly = true;
            this.qBInvoiceIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.qBInvoiceIDTextBox.TabIndex = 1;
            // 
            // ItemComboBox3
            // 
            this.ItemComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox3.FormattingEnabled = true;
            this.ItemComboBox3.Location = new System.Drawing.Point(264, 34);
            this.ItemComboBox3.Name = "ItemComboBox3";
            this.ItemComboBox3.Size = new System.Drawing.Size(308, 21);
            this.ItemComboBox3.TabIndex = 5;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(110, 9);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.CustomerNameTextBox.TabIndex = 7;
            // 
            // ItemGroupBox3
            // 
            this.ItemGroupBox3.Controls.Add(this.DescTextBox3);
            this.ItemGroupBox3.Controls.Add(label7);
            this.ItemGroupBox3.Controls.Add(this.ItemComboBox3);
            this.ItemGroupBox3.Controls.Add(this.qbItemIDCTextBox);
            this.ItemGroupBox3.Controls.Add(this.costCTextBox);
            this.ItemGroupBox3.Controls.Add(costCLabel);
            this.ItemGroupBox3.Controls.Add(label4);
            this.ItemGroupBox3.Controls.Add(label5);
            this.ItemGroupBox3.Location = new System.Drawing.Point(25, 272);
            this.ItemGroupBox3.Name = "ItemGroupBox3";
            this.ItemGroupBox3.Size = new System.Drawing.Size(592, 88);
            this.ItemGroupBox3.TabIndex = 12;
            this.ItemGroupBox3.TabStop = false;
            this.ItemGroupBox3.Text = "Item C";
            // 
            // DescTextBox3
            // 
            this.DescTextBox3.FormattingEnabled = true;
            this.DescTextBox3.Items.AddRange(new object[] {
            "Step #1 of 4-Step Lawn Care Treatment Plan: Crabgrass Preventative/Fertilizer",
            "Step #2 of 4-Step Lawn Care Treatment Plan: Broadleaf Weed Control/Fertilizer",
            "Step #3 of 4-Step Lawn Care Treatment Plan:  Insect Control/Fertilizer",
            "Step #4 of 4-Step Lawn Care Treatment Plan: High Nitrogen Fertilizer",
            "Mow",
            "Clean Gutters",
            "Pruning as Per Estimate",
            "Mulching as Per Estimate",
            "Leaf removal; haul",
            "Leaf removal; dispose of on property",
            "Pruning",
            "Mulching",
            "Core aeration",
            "Seeding",
            "Fertilizing",
            "Lime",
            "Hauling",
            "Mulch delivery – 5 cubic yds.",
            "Mulch delivery – 10 cubic yds.",
            "Mulch delivery – 15 cubic yds."});
            this.DescTextBox3.Location = new System.Drawing.Point(85, 60);
            this.DescTextBox3.Name = "DescTextBox3";
            this.DescTextBox3.Size = new System.Drawing.Size(487, 21);
            this.DescTextBox3.TabIndex = 17;
            // 
            // qbItemIDCTextBox
            // 
            this.qbItemIDCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "QBItemIDC", true));
            this.qbItemIDCTextBox.Location = new System.Drawing.Point(85, 14);
            this.qbItemIDCTextBox.Name = "qbItemIDCTextBox";
            this.qbItemIDCTextBox.ReadOnly = true;
            this.qbItemIDCTextBox.Size = new System.Drawing.Size(100, 20);
            this.qbItemIDCTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DescTextBox1);
            this.groupBox2.Controls.Add(costLabel);
            this.groupBox2.Controls.Add(this.costTextBox);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.ItemComboBox1);
            this.groupBox2.Controls.Add(this.qbItemIDTextBox);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Location = new System.Drawing.Point(25, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item A";
            // 
            // DescTextBox1
            // 
            this.DescTextBox1.FormattingEnabled = true;
            this.DescTextBox1.Items.AddRange(new object[] {
            "Step #1 of 4-Step Lawn Care Treatment Plan: Crabgrass Preventative/Fertilizer",
            "Step #2 of 4-Step Lawn Care Treatment Plan: Broadleaf Weed Control/Fertilizer",
            "Step #3 of 4-Step Lawn Care Treatment Plan:  Insect Control/Fertilizer",
            "Step #4 of 4-Step Lawn Care Treatment Plan: High Nitrogen Fertilizer",
            "Mow",
            "Clean Gutters",
            "Pruning as Per Estimate",
            "Mulching as Per Estimate",
            "Leaf removal; haul",
            "Leaf removal; dispose of on property",
            "Pruning ",
            "Mulching ",
            "Core aeration",
            "Seeding",
            "Fertilizing",
            "Lime",
            "Hauling",
            "Mulch delivery – 5 cubic yds.",
            "Mulch delivery – 10 cubic yds.",
            "Mulch delivery – 15 cubic yds."});
            this.DescTextBox1.Location = new System.Drawing.Point(85, 60);
            this.DescTextBox1.Name = "DescTextBox1";
            this.DescTextBox1.Size = new System.Drawing.Size(487, 21);
            this.DescTextBox1.TabIndex = 15;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.costTextBox.Location = new System.Drawing.Point(85, 37);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 3;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged_1);
            // 
            // ItemComboBox1
            // 
            this.ItemComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox1.FormattingEnabled = true;
            this.ItemComboBox1.Location = new System.Drawing.Point(264, 34);
            this.ItemComboBox1.Name = "ItemComboBox1";
            this.ItemComboBox1.Size = new System.Drawing.Size(308, 21);
            this.ItemComboBox1.TabIndex = 5;
            // 
            // qbItemIDTextBox
            // 
            this.qbItemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "QBItemID", true));
            this.qbItemIDTextBox.Location = new System.Drawing.Point(85, 14);
            this.qbItemIDTextBox.Name = "qbItemIDTextBox";
            this.qbItemIDTextBox.ReadOnly = true;
            this.qbItemIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.qbItemIDTextBox.TabIndex = 1;
            // 
            // ItemGroupBox2
            // 
            this.ItemGroupBox2.Controls.Add(this.DescTextBox2);
            this.ItemGroupBox2.Controls.Add(costBLabel);
            this.ItemGroupBox2.Controls.Add(this.costBTextBox);
            this.ItemGroupBox2.Controls.Add(label9);
            this.ItemGroupBox2.Controls.Add(this.ItemComboBox2);
            this.ItemGroupBox2.Controls.Add(this.qbItemIDBTextBox);
            this.ItemGroupBox2.Controls.Add(label11);
            this.ItemGroupBox2.Controls.Add(label12);
            this.ItemGroupBox2.Location = new System.Drawing.Point(25, 178);
            this.ItemGroupBox2.Name = "ItemGroupBox2";
            this.ItemGroupBox2.Size = new System.Drawing.Size(592, 88);
            this.ItemGroupBox2.TabIndex = 11;
            this.ItemGroupBox2.TabStop = false;
            this.ItemGroupBox2.Text = "Item B";
            // 
            // DescTextBox2
            // 
            this.DescTextBox2.FormattingEnabled = true;
            this.DescTextBox2.Items.AddRange(new object[] {
            "Step #1 of 4-Step Lawn Care Treatment Plan: Crabgrass Preventative/Fertilizer",
            "Step #2 of 4-Step Lawn Care Treatment Plan: Broadleaf Weed Control/Fertilizer",
            "Step #3 of 4-Step Lawn Care Treatment Plan:  Insect Control/Fertilizer",
            "Step #4 of 4-Step Lawn Care Treatment Plan: High Nitrogen Fertilizer",
            "Mow",
            "Clean Gutters",
            "Pruning as Per Estimate",
            "Mulching as Per Estimate",
            "Leaf removal; haul",
            "Leaf removal; dispose of on property",
            "Pruning",
            "Mulching",
            "Core aeration",
            "Seeding",
            "Fertilizing",
            "Lime",
            "Hauling",
            "Mulch delivery – 5 cubic yds.",
            "Mulch delivery – 10 cubic yds.",
            "Mulch delivery – 15 cubic yds."});
            this.DescTextBox2.Location = new System.Drawing.Point(85, 61);
            this.DescTextBox2.Name = "DescTextBox2";
            this.DescTextBox2.Size = new System.Drawing.Size(487, 21);
            this.DescTextBox2.TabIndex = 16;
            // 
            // costBTextBox
            // 
            this.costBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "CostB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.costBTextBox.Location = new System.Drawing.Point(85, 37);
            this.costBTextBox.Name = "costBTextBox";
            this.costBTextBox.Size = new System.Drawing.Size(100, 20);
            this.costBTextBox.TabIndex = 3;
            this.costBTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged_1);
            // 
            // ItemComboBox2
            // 
            this.ItemComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox2.FormattingEnabled = true;
            this.ItemComboBox2.Location = new System.Drawing.Point(264, 35);
            this.ItemComboBox2.Name = "ItemComboBox2";
            this.ItemComboBox2.Size = new System.Drawing.Size(308, 21);
            this.ItemComboBox2.TabIndex = 5;
            // 
            // qbItemIDBTextBox
            // 
            this.qbItemIDBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "QBItemIDB", true));
            this.qbItemIDBTextBox.Location = new System.Drawing.Point(85, 14);
            this.qbItemIDBTextBox.Name = "qbItemIDBTextBox";
            this.qbItemIDBTextBox.ReadOnly = true;
            this.qbItemIDBTextBox.Size = new System.Drawing.Size(100, 20);
            this.qbItemIDBTextBox.TabIndex = 1;
            // 
            // JobdateDateTimePicker
            // 
            this.JobdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerJobBindingSource, "Date", true));
            this.JobdateDateTimePicker.Enabled = false;
            this.JobdateDateTimePicker.Location = new System.Drawing.Point(394, 32);
            this.JobdateDateTimePicker.Name = "JobdateDateTimePicker";
            this.JobdateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.JobdateDateTimePicker.TabIndex = 5;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(446, 466);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(541, 466);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 14;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(394, 9);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 3;
            // 
            // custPropertyJobsBindingSource
            // 
            this.custPropertyJobsBindingSource.DataMember = "CustPropertyJobs";
            this.custPropertyJobsBindingSource.DataSource = this.mMSDataSet;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = this.custPropertyJobsBindingSource;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custPropertyJobsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(110, 32);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(187, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // ItemBCheckBox
            // 
            this.ItemBCheckBox.AutoSize = true;
            this.ItemBCheckBox.Location = new System.Drawing.Point(31, 176);
            this.ItemBCheckBox.Name = "ItemBCheckBox";
            this.ItemBCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ItemBCheckBox.TabIndex = 8;
            this.ItemBCheckBox.Text = "Item B";
            this.ItemBCheckBox.UseVisualStyleBackColor = true;
            this.ItemBCheckBox.CheckedChanged += new System.EventHandler(this.ItemBCheckBox_CheckedChanged);
            // 
            // AppendAddressCheckBox
            // 
            this.AppendAddressCheckBox.AutoSize = true;
            this.AppendAddressCheckBox.Checked = true;
            this.AppendAddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendAddressCheckBox.Location = new System.Drawing.Point(420, 58);
            this.AppendAddressCheckBox.Name = "AppendAddressCheckBox";
            this.AppendAddressCheckBox.Size = new System.Drawing.Size(175, 17);
            this.AppendAddressCheckBox.TabIndex = 17;
            this.AppendAddressCheckBox.Text = "Append Address to  Description";
            this.AppendAddressCheckBox.UseVisualStyleBackColor = true;
            // 
            // ItemGroupBox4
            // 
            this.ItemGroupBox4.Controls.Add(this.DescTextBox4);
            this.ItemGroupBox4.Controls.Add(label2);
            this.ItemGroupBox4.Controls.Add(this.ItemComboBox4);
            this.ItemGroupBox4.Controls.Add(this.qbItemIDDTextBox);
            this.ItemGroupBox4.Controls.Add(this.costDTextBox);
            this.ItemGroupBox4.Controls.Add(label10);
            this.ItemGroupBox4.Controls.Add(label13);
            this.ItemGroupBox4.Controls.Add(label14);
            this.ItemGroupBox4.Location = new System.Drawing.Point(24, 366);
            this.ItemGroupBox4.Name = "ItemGroupBox4";
            this.ItemGroupBox4.Size = new System.Drawing.Size(592, 88);
            this.ItemGroupBox4.TabIndex = 18;
            this.ItemGroupBox4.TabStop = false;
            this.ItemGroupBox4.Text = "Item C";
            // 
            // DescTextBox4
            // 
            this.DescTextBox4.FormattingEnabled = true;
            this.DescTextBox4.Items.AddRange(new object[] {
            "Step #1 of 4-Step Lawn Care Treatment Plan: Crabgrass Preventative/Fertilizer",
            "Step #2 of 4-Step Lawn Care Treatment Plan: Broadleaf Weed Control/Fertilizer",
            "Step #3 of 4-Step Lawn Care Treatment Plan:  Insect Control/Fertilizer",
            "Step #4 of 4-Step Lawn Care Treatment Plan: High Nitrogen Fertilizer",
            "Mow",
            "Clean Gutters",
            "Pruning as Per Estimate",
            "Mulching as Per Estimate",
            "Leaf removal; haul",
            "Leaf removal; dispose of on property",
            "Pruning",
            "Mulching",
            "Core aeration",
            "Seeding",
            "Fertilizing",
            "Lime",
            "Hauling",
            "Mulch delivery – 5 cubic yds.",
            "Mulch delivery – 10 cubic yds.",
            "Mulch delivery – 15 cubic yds."});
            this.DescTextBox4.Location = new System.Drawing.Point(85, 60);
            this.DescTextBox4.Name = "DescTextBox4";
            this.DescTextBox4.Size = new System.Drawing.Size(487, 21);
            this.DescTextBox4.TabIndex = 17;
            // 
            // ItemComboBox4
            // 
            this.ItemComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox4.FormattingEnabled = true;
            this.ItemComboBox4.Location = new System.Drawing.Point(264, 34);
            this.ItemComboBox4.Name = "ItemComboBox4";
            this.ItemComboBox4.Size = new System.Drawing.Size(308, 21);
            this.ItemComboBox4.TabIndex = 5;
            // 
            // qbItemIDDTextBox
            // 
            this.qbItemIDDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "QBItemIDD", true));
            this.qbItemIDDTextBox.Location = new System.Drawing.Point(85, 14);
            this.qbItemIDDTextBox.Name = "qbItemIDDTextBox";
            this.qbItemIDDTextBox.ReadOnly = true;
            this.qbItemIDDTextBox.Size = new System.Drawing.Size(100, 20);
            this.qbItemIDDTextBox.TabIndex = 1;
            // 
            // costDTextBox
            // 
            this.costDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerJobBindingSource, "CostD", true));
            this.costDTextBox.Location = new System.Drawing.Point(85, 37);
            this.costDTextBox.Name = "costDTextBox";
            this.costDTextBox.Size = new System.Drawing.Size(100, 20);
            this.costDTextBox.TabIndex = 3;
            // 
            // customerJobTableAdapter
            // 
            this.customerJobTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BonusTableAdapter = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = this.customerJobTableAdapter;
            this.tableAdapterManager.CustomerNewsletterTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = null;
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
            // custPropertyJobsTableAdapter
            // 
            this.custPropertyJobsTableAdapter.ClearBeforeFill = true;
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // ItemDCheckBox
            // 
            this.ItemDCheckBox.AutoSize = true;
            this.ItemDCheckBox.Enabled = false;
            this.ItemDCheckBox.Location = new System.Drawing.Point(32, 365);
            this.ItemDCheckBox.Name = "ItemDCheckBox";
            this.ItemDCheckBox.Size = new System.Drawing.Size(57, 17);
            this.ItemDCheckBox.TabIndex = 19;
            this.ItemDCheckBox.Text = "Item D";
            this.ItemDCheckBox.UseVisualStyleBackColor = true;
            this.ItemDCheckBox.CheckedChanged += new System.EventHandler(this.ItemDCheckBox_CheckedChanged);
            // 
            // ItemCCheckBox
            // 
            this.ItemCCheckBox.AutoSize = true;
            this.ItemCCheckBox.Enabled = false;
            this.ItemCCheckBox.Location = new System.Drawing.Point(32, 269);
            this.ItemCCheckBox.Name = "ItemCCheckBox";
            this.ItemCCheckBox.Size = new System.Drawing.Size(56, 17);
            this.ItemCCheckBox.TabIndex = 20;
            this.ItemCCheckBox.Text = "Item C";
            this.ItemCCheckBox.UseVisualStyleBackColor = true;
            this.ItemCCheckBox.CheckedChanged += new System.EventHandler(this.ItemCCheckBox1_CheckedChanged);
            // 
            // QBInvoiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 501);
            this.Controls.Add(this.ItemCCheckBox);
            this.Controls.Add(this.ItemDCheckBox);
            this.Controls.Add(this.ItemGroupBox4);
            this.Controls.Add(this.AppendAddressCheckBox);
            this.Controls.Add(this.ItemBCheckBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.JobdateDateTimePicker);
            this.Controls.Add(this.ItemGroupBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ItemGroupBox3);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(label6);
            this.Controls.Add(qBInvoiceIDLabel);
            this.Controls.Add(this.qBInvoiceIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QBInvoiceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QB Invoice Dialog";
            this.Load += new System.EventHandler(this.QBInvoiceDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            this.ItemGroupBox3.ResumeLayout(false);
            this.ItemGroupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ItemGroupBox2.ResumeLayout(false);
            this.ItemGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custPropertyJobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            this.ItemGroupBox4.ResumeLayout(false);
            this.ItemGroupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource customerJobBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerJobTableAdapter customerJobTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TextBox costCTextBox;
        private TextBox qBInvoiceIDTextBox;
        private ComboBox ItemComboBox3;
        private TextBox CustomerNameTextBox;
        private GroupBox ItemGroupBox3;
        private TextBox qbItemIDCTextBox;
        private GroupBox groupBox2;
        private ComboBox ItemComboBox1;
        private TextBox qbItemIDTextBox;
        private GroupBox ItemGroupBox2;
        private ComboBox ItemComboBox2;
        private TextBox qbItemIDBTextBox;
        private DateTimePicker JobdateDateTimePicker;
        private Button CancelButton;
        private Button OKButton;
        private TextBox costTextBox;
        private TextBox costBTextBox;
        private BindingSource custPropertyJobsBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustPropertyJobsTableAdapter custPropertyJobsTableAdapter;
        private TextBox typeTextBox;
        private BindingSource propertyBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.PropertyTableAdapter propertyTableAdapter;
        private TextBox addressTextBox;
        private CheckBox ItemBCheckBox;
        private ComboBox DescTextBox1;
        private ComboBox DescTextBox2;
        private ComboBox DescTextBox3;
        private CheckBox AppendAddressCheckBox;
        private GroupBox ItemGroupBox4;
        private ComboBox DescTextBox4;
        private ComboBox ItemComboBox4;
        private TextBox qbItemIDDTextBox;
        private TextBox costDTextBox;
        private CheckBox ItemDCheckBox;
        private CheckBox ItemCCheckBox;
    }
}