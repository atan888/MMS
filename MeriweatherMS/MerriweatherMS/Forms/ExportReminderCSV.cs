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
    public partial class ExportReminderCSV : Form
    {
        public ExportReminderCSV()
        {
            InitializeComponent();
        }

        private void ExportReminderCSV_Load(object sender, EventArgs e)
        {
            reminderComboBox.SelectedIndex = 0;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            if (exportAllCheckBox.Checked) 
                this.letterDataTableTableAdapter.Fill(this.mMSDataSet.LetterDataTable);
            else if (infrequentCostCheckBox.Checked)
                this.letterDataTableTableAdapter.FillByInFreqCost(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 0) //spring
                this.letterDataTableTableAdapter.FillBySpringServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 1) //summer
                this.letterDataTableTableAdapter.FillBySummerServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 2) //fall 1  ** all fall code execept those with LV, G
                this.letterDataTableTableAdapter.FillByFallServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 3) //fall 2  ** all fall code with LV, G, and PR only
                this.letterDataTableTableAdapter.FillByFallServices2(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 4)//winter
                this.letterDataTableTableAdapter.FillByWinterServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 5)// all with 4step cost and 4step customer**
                this.letterDataTableTableAdapter.FillByFourStepServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 6)// all with 4step cost but not current 4step customer**
                this.letterDataTableTableAdapter.FillByCanceFourStepServices(this.mMSDataSet.LetterDataTable);
            else if (reminderComboBox.SelectedIndex == 7)// Former Mowing Customer, active with cost, but infrequent**
                this.letterDataTableTableAdapter.FillByFormerMowingCustomer(this.mMSDataSet.LetterDataTable);
            else //all mowing customers - frequent
                this.letterDataTableTableAdapter.FillByMowingCustomer(this.mMSDataSet.LetterDataTable);

            fillButton.BackColor = System.Drawing.SystemColors.Control;
        }

        private void reminderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillButton.BackColor = System.Drawing.Color.Salmon;
        }

        private void exportAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            infrequentCostCheckBox.Enabled = !exportAllCheckBox.Checked;
            reminderComboBox.Enabled = !exportAllCheckBox.Checked;
            fillButton.BackColor = System.Drawing.Color.Salmon;
        }

        private void ToCVSButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            letterDataTableExtendedDataGridView.ToCsv();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Reminder List Export Complete!");
        }

        private void infrequentCostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            reminderComboBox.Enabled = !infrequentCostCheckBox.Checked;
            fillButton.BackColor = System.Drawing.Color.Salmon;
        }
    }
}
