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
    public partial class UpdateJobStatusDialog : Form
    {
        RadioButton checkedRadioButton;

        public string TotalCost
        {
            set
            {
                totalCostTextBox.Text = value;
            }
        }
        public string TotalMatCost
        {
            set
            {
                materialCostTextBox.Text = value;
            }
        }

        public UpdateJobStatusDialog()
        {
            InitializeComponent();
        }

        private void UpdateJobStatusDialog_Load(object sender, EventArgs e)
        {

        }

        public void SetStatus(string szStatus)
        {
            if (szStatus == "Pending")
            {
                radioButton1.Checked = true;
            }
            else if (szStatus == "Completed")
            {
                radioButton2.Checked = true;
                manHoursTextBox.Enabled = radioButton2.Checked;
                label1.Enabled = radioButton2.Checked;
                label2.Enabled = radioButton2.Checked;
                label3.Enabled = radioButton2.Checked;
            }
            else if (szStatus == "Seasonal")
            {
                radioButton3.Checked = true;
            }
            else if (szStatus == "Gutters")
            {
                radioButton4.Checked = true;
            }
        }
        public string GetStatus()
        {
            if (checkedRadioButton != null)
            {
                return checkedRadioButton.Text;
            }
            return "";
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                if (radioButton.Checked)
                {
                    checkedRadioButton = radioButton;
                }
                else if (checkedRadioButton == radioButton)
                {
                    checkedRadioButton = null;
                }

                //enable if Completed button is pressed
                manHoursTextBox.Enabled = radioButton2.Checked;
                totalCostTextBox.Enabled = radioButton2.Checked;
                materialCostTextBox.Enabled = radioButton2.Checked;
                label1.Enabled = radioButton2.Checked;
                label2.Enabled = radioButton2.Checked;
                label3.Enabled = radioButton2.Checked;
            }
        }
        
        private void CheckDigitsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char Period = '.';
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != Period;
        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            if ((manHoursTextBox.Text == "") ||
                (totalCostTextBox.Text == "") ||
                (materialCostTextBox.Text == ""))
            {
                //warning?
            }
        }

        public double GetManHours()
        {            
            double hours = Convert.ToDouble(manHoursTextBox.Text);
            if (hours <= 0.0) hours = 0.0;

            return hours;
        }

        public double GetTotalCost()
        {
            double total = Convert.ToDouble(totalCostTextBox.Text);
            if (total <= 0.0) total = 0.0;
            return total;
        }
        public double GetMaterialCost()
        {
            double total = Convert.ToDouble(materialCostTextBox.Text);
            if (total <= 0.0) total = 0.0;
            return total;

        }

        private void validateTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = true;
            if ((manHoursTextBox.Text == "") ||
                (totalCostTextBox.Text == "") ||
                (materialCostTextBox.Text == ""))
            {
                okButton.Enabled = false;
            }
        }
  
    }
}
