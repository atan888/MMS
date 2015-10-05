namespace System.Windows.Forms.MMS.Forms
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.letterDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letterDataTableTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.LetterDataTableTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.letterDataTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.letterDataTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.letterDataTableExtendedDataGridView = new DataGridViewControls.ExtendedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableBindingNavigator)).BeginInit();
            this.letterDataTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableExtendedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // letterDataTableBindingSource
            // 
            this.letterDataTableBindingSource.DataMember = "LetterDataTable";
            this.letterDataTableBindingSource.DataSource = this.mMSDataSet;
            // 
            // letterDataTableTableAdapter
            // 
            this.letterDataTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = null;
            this.tableAdapterManager.CustomerNewsletterTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = null;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = null;
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
            // letterDataTableBindingNavigator
            // 
            this.letterDataTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.letterDataTableBindingNavigator.BindingSource = this.letterDataTableBindingSource;
            this.letterDataTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.letterDataTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.letterDataTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.letterDataTableBindingNavigatorSaveItem});
            this.letterDataTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.letterDataTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.letterDataTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.letterDataTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.letterDataTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.letterDataTableBindingNavigator.Name = "letterDataTableBindingNavigator";
            this.letterDataTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.letterDataTableBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.letterDataTableBindingNavigator.TabIndex = 0;
            this.letterDataTableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // letterDataTableBindingNavigatorSaveItem
            // 
            this.letterDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.letterDataTableBindingNavigatorSaveItem.Enabled = false;
            this.letterDataTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("letterDataTableBindingNavigatorSaveItem.Image")));
            this.letterDataTableBindingNavigatorSaveItem.Name = "letterDataTableBindingNavigatorSaveItem";
            this.letterDataTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.letterDataTableBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // letterDataTableExtendedDataGridView
            // 
            this.letterDataTableExtendedDataGridView.DataSource = this.letterDataTableBindingSource;
            this.letterDataTableExtendedDataGridView.Location = new System.Drawing.Point(12, 47);
            this.letterDataTableExtendedDataGridView.Name = "letterDataTableExtendedDataGridView";
            this.letterDataTableExtendedDataGridView.Size = new System.Drawing.Size(692, 378);
            this.letterDataTableExtendedDataGridView.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 457);
            this.Controls.Add(this.letterDataTableExtendedDataGridView);
            this.Controls.Add(this.letterDataTableBindingNavigator);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableBindingNavigator)).EndInit();
            this.letterDataTableBindingNavigator.ResumeLayout(false);
            this.letterDataTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letterDataTableExtendedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource letterDataTableBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.LetterDataTableTableAdapter letterDataTableTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator letterDataTableBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton letterDataTableBindingNavigatorSaveItem;
        private DataGridViewControls.ExtendedDataGridView letterDataTableExtendedDataGridView;

    }
}