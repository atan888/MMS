namespace System.Windows.Forms.MMS
{
    partial class AssignCustomerTypeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignCustomerTypeDialog));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.mMSDataSet = new System.Windows.Forms.MMS.Data.MMSDataSet();
            this.customerTypeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTypeListTableAdapter = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter();
            this.tableAdapterManager = new System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager();
            this.customerTypeListComboBox = new System.Windows.Forms.ComboBox();
            routeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // routeNameLabel
            // 
            routeNameLabel.AutoSize = true;
            routeNameLabel.Location = new System.Drawing.Point(21, 15);
            routeNameLabel.Name = "routeNameLabel";
            routeNameLabel.Size = new System.Drawing.Size(113, 13);
            routeNameLabel.TabIndex = 7;
            routeNameLabel.Text = "Customer Group Type:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(24, 79);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okbutton
            // 
            this.okbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbutton.Location = new System.Drawing.Point(107, 79);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 23);
            this.okbutton.TabIndex = 5;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // mMSDataSet
            // 
            this.mMSDataSet.DataSetName = "MMSDataSet";
            this.mMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTypeListBindingSource
            // 
            this.customerTypeListBindingSource.DataMember = "CustomerTypeList";
            this.customerTypeListBindingSource.DataSource = this.mMSDataSet;
            // 
            // customerTypeListTableAdapter
            // 
            this.customerTypeListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrewTableAdapter = null;
            this.tableAdapterManager.CustomerJobTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.CustomerTypeListTableAdapter = this.customerTypeListTableAdapter;
            this.tableAdapterManager.CustPropertyJobsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.JobStatusListTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropServiceTableAdapter = null;
            this.tableAdapterManager.RouteListTableAdapter = null;
            this.tableAdapterManager.RouteTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // customerTypeListComboBox
            // 
            this.customerTypeListComboBox.DataSource = this.customerTypeListBindingSource;
            this.customerTypeListComboBox.DisplayMember = "CustomerType";
            this.customerTypeListComboBox.FormattingEnabled = true;
            this.customerTypeListComboBox.Location = new System.Drawing.Point(24, 40);
            this.customerTypeListComboBox.Name = "customerTypeListComboBox";
            this.customerTypeListComboBox.Size = new System.Drawing.Size(158, 21);
            this.customerTypeListComboBox.TabIndex = 9;
            this.customerTypeListComboBox.ValueMember = "CustomerTypeID";
            // 
            // AssignCustomerTypeDialog
            // 
            this.AcceptButton = this.okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(222, 135);
            this.Controls.Add(this.customerTypeListComboBox);
            this.Controls.Add(routeNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssignCustomerTypeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Customer Type";
            this.Load += new System.EventHandler(this.AssignCustomerTypeDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button okbutton;
        private System.Windows.Forms.MMS.Data.MMSDataSet mMSDataSet;
        private BindingSource customerTypeListBindingSource;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.CustomerTypeListTableAdapter customerTypeListTableAdapter;
        private System.Windows.Forms.MMS.Data.MMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ComboBox customerTypeListComboBox;
    }
}