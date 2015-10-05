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
    public partial class AssignRouteDialog : Form
    {
        public AssignRouteDialog()
        {
            InitializeComponent();
        }

        public string GetRouteText()
        {
            if (routeNameComboBox != null)
            {
                return routeNameComboBox.Text;
            }
            return "";
        }

        private void routeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.routeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }

        private void AssignRouteDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.RouteList' table. You can move, or remove it, as needed.
            this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);

        }
    }
}
