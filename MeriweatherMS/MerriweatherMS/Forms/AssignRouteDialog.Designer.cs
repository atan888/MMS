namespace System.Windows.Forms.MMS
{
    partial class AssignRouteDialog
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
            System.Windows.Forms.Label routeNameLabel;
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.routeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.routeNameComboBox = new System.Windows.Forms.ComboBox();
            this.routeListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.routeListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            routeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // routeNameLabel
            // 
            routeNameLabel.AutoSize = true;
            routeNameLabel.Location = new System.Drawing.Point(12, 27);
            routeNameLabel.Name = "routeNameLabel";
            routeNameLabel.Size = new System.Drawing.Size(70, 13);
            routeNameLabel.TabIndex = 3;
            routeNameLabel.Text = "Route Name:";
            // 
            // okbutton
            // 
            this.okbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutton.Location = new System.Drawing.Point(171, 79);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 0;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(80, 79);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = null;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.JobStatusListTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropServiceTableAdapter = null;
            this.tableAdapterManager.RouteListTableAdapter = this.routeListTableAdapter;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // routeNameComboBox
            // 
            this.routeNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeListBindingSource, "RouteName", true));
            this.routeNameComboBox.DataSource = this.routeListBindingSource;
            this.routeNameComboBox.DisplayMember = "RouteName";
            this.routeNameComboBox.FormattingEnabled = true;
            this.routeNameComboBox.Location = new System.Drawing.Point(88, 24);
            this.routeNameComboBox.Name = "routeNameComboBox";
            this.routeNameComboBox.Size = new System.Drawing.Size(158, 21);
            this.routeNameComboBox.TabIndex = 4;
            this.routeNameComboBox.ValueMember = "RouteNameID";
            // 
            // routeListBindingSource1
            // 
            this.routeListBindingSource1.DataMember = "RouteList";
            this.routeListBindingSource1.DataSource = this.mMSDataSet;
            // 
            // routeListBindingSource2
            // 
            this.routeListBindingSource2.DataMember = "RouteList";
            this.routeListBindingSource2.DataSource = this.mMSDataSet;
            // 
            // AssignRouteDialog
            // 
            this.AcceptButton = this.okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(268, 122);
            this.Controls.Add(routeNameLabel);
            this.Controls.Add(this.routeNameComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignRouteDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Route";
            this.Load += new System.EventHandler(this.AssignRouteDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeListBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button okbutton;
        private Button cancelButton;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource routeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.RouteListTableAdapter routeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ComboBox routeNameComboBox;
        private BindingSource routeListBindingSource1;
        private BindingSource routeListBindingSource2;
    }
}