using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.LetterDataTable' table. You can move, or remove it, as needed.
            this.letterDataTableTableAdapter.Fill(this.mMSDataSet.LetterDataTable);

        }
    }

}
