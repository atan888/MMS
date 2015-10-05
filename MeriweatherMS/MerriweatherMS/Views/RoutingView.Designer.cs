namespace System.Windows.Forms.MMS.Views
{
    partial class RoutingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutingView));
            this.titleStrip1 = new System.Windows.Forms.MMS.TitleStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.FourStepCheckBox = new System.Windows.Forms.CheckBox();
            this.reNumberButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MapItButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.routeViewBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.routeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.routeViewDataGridView = new DataGridViewControls.ExtendedDataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FourStepType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeViewTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteViewTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.routeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter();
            this.routeTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moveUpNexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.moveDownNextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingNavigator)).BeginInit();
            this.routeViewBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.titleStrip1.TabIndex = 4;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CustTypeCheckBox);
            this.groupBox1.Controls.Add(this.FourStepCheckBox);
            this.groupBox1.Controls.Add(this.reNumberButton);
            this.groupBox1.Controls.Add(this.lockButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MapItButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.FilterComboBox);
            this.groupBox1.Controls.Add(this.routeViewBindingNavigator);
            this.groupBox1.Controls.Add(this.routeViewDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(19, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 598);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routing View";
            // 
            // CustTypeCheckBox
            // 
            this.CustTypeCheckBox.AutoSize = true;
            this.CustTypeCheckBox.Checked = true;
            this.CustTypeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustTypeCheckBox.Location = new System.Drawing.Point(223, 22);
            this.CustTypeCheckBox.Name = "CustTypeCheckBox";
            this.CustTypeCheckBox.Size = new System.Drawing.Size(84, 17);
            this.CustTypeCheckBox.TabIndex = 70;
            this.CustTypeCheckBox.Text = "Current Only";
            this.CustTypeCheckBox.UseVisualStyleBackColor = true;
            this.CustTypeCheckBox.CheckedChanged += new System.EventHandler(this.CustTypeCheckBox_CheckedChanged);
            // 
            // FourStepCheckBox
            // 
            this.FourStepCheckBox.AutoSize = true;
            this.FourStepCheckBox.Checked = true;
            this.FourStepCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FourStepCheckBox.Location = new System.Drawing.Point(329, 22);
            this.FourStepCheckBox.Name = "FourStepCheckBox";
            this.FourStepCheckBox.Size = new System.Drawing.Size(106, 17);
            this.FourStepCheckBox.TabIndex = 69;
            this.FourStepCheckBox.Text = "4Step Customers";
            this.FourStepCheckBox.UseVisualStyleBackColor = true;
            this.FourStepCheckBox.CheckedChanged += new System.EventHandler(this.CustTypeCheckBox_CheckedChanged);
            // 
            // reNumberButton
            // 
            this.reNumberButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reNumberButton.Enabled = false;
            this.reNumberButton.Location = new System.Drawing.Point(194, 558);
            this.reNumberButton.Name = "reNumberButton";
            this.reNumberButton.Size = new System.Drawing.Size(75, 23);
            this.reNumberButton.TabIndex = 67;
            this.reNumberButton.Text = "Renumber";
            this.reNumberButton.UseVisualStyleBackColor = true;
            this.reNumberButton.Click += new System.EventHandler(this.reNumberButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lockButton.Enabled = false;
            this.lockButton.Location = new System.Drawing.Point(18, 558);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(75, 23);
            this.lockButton.TabIndex = 68;
            this.lockButton.Text = "Lock Edit";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Route Name:";
            // 
            // MapItButton
            // 
            this.MapItButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MapItButton.Location = new System.Drawing.Point(460, 559);
            this.MapItButton.Name = "MapItButton";
            this.MapItButton.Size = new System.Drawing.Size(75, 23);
            this.MapItButton.TabIndex = 65;
            this.MapItButton.Text = "Map It...";
            this.MapItButton.UseVisualStyleBackColor = true;
            this.MapItButton.Click += new System.EventHandler(this.MapItButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(99, 558);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 64;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.CausesValidation = false;
            this.FilterComboBox.DataSource = this.routeListBindingSource;
            this.FilterComboBox.DisplayMember = "RouteName";
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(567, 19);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(178, 21);
            this.FilterComboBox.TabIndex = 65;
            this.FilterComboBox.ValueMember = "RouteName";
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // routeListBindingSource
            // 
            this.routeListBindingSource.DataMember = "RouteList";
            this.routeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeViewBindingNavigator
            // 
            this.routeViewBindingNavigator.AddNewItem = null;
            this.routeViewBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.routeViewBindingNavigator.BindingSource = this.routeViewBindingSource;
            this.routeViewBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.routeViewBindingNavigator.DeleteItem = null;
            this.routeViewBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.routeViewBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.routeViewBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.routeViewBindingNavigator.Location = new System.Drawing.Point(545, 557);
            this.routeViewBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.routeViewBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.routeViewBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.routeViewBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.routeViewBindingNavigator.Name = "routeViewBindingNavigator";
            this.routeViewBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.routeViewBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.routeViewBindingNavigator.Size = new System.Drawing.Size(200, 25);
            this.routeViewBindingNavigator.TabIndex = 6;
            this.routeViewBindingNavigator.Text = "bindingNavigator1";
            // 
            // routeViewBindingSource
            // 
            this.routeViewBindingSource.DataMember = "RouteView";
            this.routeViewBindingSource.DataSource = this.mMSDataSet;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            // routeViewDataGridView
            // 
            this.routeViewDataGridView.AllowDrop = true;
            this.routeViewDataGridView.AllowUserToAddRows = false;
            this.routeViewDataGridView.AllowUserToDeleteRows = false;
            this.routeViewDataGridView.AllowUserToResizeRows = false;
            this.routeViewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.routeViewDataGridView.AutoGenerateColumns = false;
            this.routeViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.PropertyID,
            this.dataGridViewTextBoxColumn13,
            this.FourStepType,
            this.GroupType});
            this.routeViewDataGridView.DataSource = this.routeViewBindingSource;
            this.routeViewDataGridView.Location = new System.Drawing.Point(18, 60);
            this.routeViewDataGridView.Name = "routeViewDataGridView";
            this.routeViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routeViewDataGridView.Size = new System.Drawing.Size(727, 480);
            this.routeViewDataGridView.TabIndex = 0;
            this.routeViewDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeViewDataGridView_CellValueChanged);
            this.routeViewDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.routeViewDataGridView_MouseDown);
            this.routeViewDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.routeViewDataGridView_CellBeginEdit);
            this.routeViewDataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeViewDataGridView_CellLeave);
            this.routeViewDataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.routeViewDataGridView_MouseMove);
            this.routeViewDataGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.routeViewDataGridView_DragOver);
            this.routeViewDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeViewDataGridView_CellEndEdit);
            this.routeViewDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.routeViewDataGridView_DragDrop);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RouteID";
            this.dataGridViewTextBoxColumn9.HeaderText = "RouteID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RouteOrder";
            this.dataGridViewTextBoxColumn12.HeaderText = "RouteOrder";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn5.HeaderText = "City";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn6.HeaderText = "State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Zip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Subdivision";
            this.dataGridViewTextBoxColumn8.HeaderText = "Subdivision";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RouteName";
            this.dataGridViewTextBoxColumn11.HeaderText = "RouteName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // PropertyID
            // 
            this.PropertyID.DataPropertyName = "PropertyID";
            this.PropertyID.HeaderText = "PropertyID";
            this.PropertyID.Name = "PropertyID";
            this.PropertyID.ReadOnly = true;
            this.PropertyID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PropertyID.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn13.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // FourStepType
            // 
            this.FourStepType.DataPropertyName = "FourStepType";
            this.FourStepType.HeaderText = "FourStepType";
            this.FourStepType.Name = "FourStepType";
            this.FourStepType.ReadOnly = true;
            this.FourStepType.Visible = false;
            // 
            // GroupType
            // 
            this.GroupType.DataPropertyName = "GroupType";
            this.GroupType.HeaderText = "GroupType";
            this.GroupType.Name = "GroupType";
            this.GroupType.ReadOnly = true;
            this.GroupType.Visible = false;
            // 
            // routeViewTableAdapter
            // 
            this.routeViewTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PropServiceTableAdapter = null;
            this.tableAdapterManager.RouteListTableAdapter = this.routeListTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = this.routeTableAdapter;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserProfileTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // routeListTableAdapter
            // 
            this.routeListTableAdapter.ClearBeforeFill = true;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(797, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(62, 595);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpNexToolStripButton,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.toolStripSeparator5,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.moveDownNextToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(22, 215);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(24, 121);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moveUpNexToolStripButton
            // 
            this.moveUpNexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveUpNexToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("moveUpNexToolStripButton.Image")));
            this.moveUpNexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveUpNexToolStripButton.Name = "moveUpNexToolStripButton";
            this.moveUpNexToolStripButton.Size = new System.Drawing.Size(22, 20);
            this.moveUpNexToolStripButton.Text = "toolStripButton1";
            this.moveUpNexToolStripButton.Click += new System.EventHandler(this.moveUpNexToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(22, 20);
            this.toolStripButton2.Text = "Move Up 1";
            this.toolStripButton2.Click += new System.EventHandler(this.moveUpToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(22, 20);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.moveDownToolStripButton_Click);
            // 
            // moveDownNextToolStripButton
            // 
            this.moveDownNextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveDownNextToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("moveDownNextToolStripButton.Image")));
            this.moveDownNextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveDownNextToolStripButton.Name = "moveDownNextToolStripButton";
            this.moveDownNextToolStripButton.Size = new System.Drawing.Size(22, 20);
            this.moveDownNextToolStripButton.Text = "toolStripButton5";
            this.moveDownNextToolStripButton.Click += new System.EventHandler(this.moveDownNextToolStripButton_Click);
            // 
            // RoutingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.titleStrip1);
            this.Name = "RoutingView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingNavigator)).EndInit();
            this.routeViewBindingNavigator.ResumeLayout(false);
            this.routeViewBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeViewDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TitleStrip titleStrip1;
        private GroupBox groupBox1;
        private DataGridViewControls.ExtendedDataGridView routeViewDataGridView;
        private BindingSource routeViewBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteViewTableAdapter routeViewTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator routeViewBindingNavigator;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private Label label1;
        private ComboBox FilterComboBox;
        private BindingSource routeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter routeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteTableAdapter routeTableAdapter;
        private Button MapItButton;
        private Button DeleteButton;
        private GroupBox groupBox2;
        private Button reNumberButton;
        private ToolStrip toolStrip1;
        private ToolStripButton moveUpNexToolStripButton;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton moveDownNextToolStripButton;
        private Button lockButton;
        private CheckBox CustTypeCheckBox;
        private CheckBox FourStepCheckBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn PropertyID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewCheckBoxColumn FourStepType;
        private DataGridViewTextBoxColumn GroupType;
    }
}
