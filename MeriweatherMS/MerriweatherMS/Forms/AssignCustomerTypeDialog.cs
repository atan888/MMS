using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class AssignCustomerTypeDialog : Form
    {
        public AssignCustomerTypeDialog()
        {
            InitializeComponent();
        }


        public string GetAssignType()
        {
            if (customerTypeListComboBox != null)
            {
                return customerTypeListComboBox.Text;
            }
            return "";
        }
        public void SetType(string szType)
        {
            customerTypeListComboBox.SelectedItem = szType;
        }

        private void customerTypeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTypeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void AssignCustomerTypeDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerTypeList' table. You can move, or remove it, as needed.
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);

        }

        private void okbutton_Click(object sender, EventArgs e)
        {            
            string szMessage = "Assign selected customer as '" + customerTypeListComboBox.Text + "'?";
            if (MessageBox.Show(szMessage, "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            }
        }
    }
}
