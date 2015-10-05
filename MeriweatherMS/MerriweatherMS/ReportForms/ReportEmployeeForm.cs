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
    public partial class ReportEmployeeForm : Form
    {
        public ReportEmployeeForm()
        {
            InitializeComponent();
        }

        private void ReportEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.mMSDataSet.Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
