using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class TestReport : Form
    {
        public TestReport()
        {
            InitializeComponent();
        }

        private void TestReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.CustProperty' table. You can move, or remove it, as needed.
            this.custPropertyTableAdapter.Fill(this.mMSDataSet.CustProperty);

            this.reportViewer1.RefreshReport();
        }
    }
}
