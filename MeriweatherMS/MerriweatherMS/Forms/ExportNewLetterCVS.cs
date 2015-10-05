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
    public partial class ExportNewLetterCVS : Form
    {
        public ExportNewLetterCVS()
        {
            InitializeComponent();
        }

        private void ExportNewLetterCVS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerNewLetters' table. You can move, or remove it, as needed.            
            this.customerNewsletterTableAdapter.FillByQBStatus(this.mMSDataSet.CustomerNewletter);    
            startDateTimePicker.Value = DateTime.Now.AddDays(-30);
            endDateTimePicker.Value = DateTime.Now;

        }

        private void exportAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            startDateTimePicker.Enabled = !exportAllCheckBox.Checked;
            endDateTimePicker.Enabled = !exportAllCheckBox.Checked;
            fillButton.BackColor = System.Drawing.Color.Salmon;
        }           

        private void ToExcelButton_Click(object sender, EventArgs e)
        {
            customerNewletterDataGridView.ToExcel();
        }

        private void ToCVSButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            customerNewletterDataGridView.ToCsv();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Newsletter List Export Complete!");            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (exportAllCheckBox.Checked)
                {
                    this.customerNewsletterTableAdapter.FillByQBStatus(this.mMSDataSet.CustomerNewletter);                    
                }
                else
                {
                    DateTime fromDT = new DateTime(startDateTimePicker.Value.Year, startDateTimePicker.Value.Month, startDateTimePicker.Value.Day, 0, 0, 1, 0);
                    DateTime todTD = new DateTime(endDateTimePicker.Value.Year, endDateTimePicker.Value.Month, endDateTimePicker.Value.Day, 23, 59, 59, 0);
                    this.customerNewsletterTableAdapter.Fill(this.mMSDataSet.CustomerNewletter, fromDT, todTD);
                    //this.customerNewLettersTableAdapter.FillBy(this.mMSDataSet.CustomerNewLetters, fromDT, todTD);

                }
            }
            catch (System.Exception exe)
            {
                System.Windows.Forms.MessageBox.Show(exe.Message);
                MMSUtility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "ExportNewLetterCVS");
            }
            fillButton.BackColor = System.Drawing.SystemColors.Control;

        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fillButton.BackColor = System.Drawing.Color.Salmon;
        }

    }
}
