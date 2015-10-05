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
    public partial class BonusDialog : Form
    {
        public BonusDialog()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void BonusDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Bonus' table. You can move, or remove it, as needed.
            this.bonusTableAdapter.Fill(this.mMSDataSet.Bonus);
            yearComboBox.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (yearComboBox.SelectedItem != null)
            {
                string strYear = yearComboBox.SelectedItem.ToString();
                if (strYear == "") strYear = "2013";

                if (checkBox1.Checked)
                    bonusBindingSource.Filter = "Active > 0 and Contractor > 0 and Year is null or Year = " + strYear;
                else
                    bonusBindingSource.Filter = "Active > 0 and Contractor < 1 and Year is null or Year = " + strYear;
            }
        }
   

        private void okButton_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.bonusBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.mMSDataSet);

            foreach (DataGridViewRow dataRow in bonusDataGridView.Rows)
            {
                string bonusId = dataRow.Cells[0].Value.ToString();
                string strEmpId = dataRow.Cells[1].Value.ToString();
                string strBonus = dataRow.Cells[4].Value.ToString();
                string strQualityBonus = dataRow.Cells[5].Value.ToString();
                string strYear = yearComboBox.SelectedItem.ToString();

                if (bonusId != "") // there is a record
                {
                    //update
                    if ((strBonus != "") || (strQualityBonus != ""))
                    {
                        if (strBonus == "") strBonus = "0";
                        if (strQualityBonus == "") strQualityBonus = "0";

                        if ((strBonus == "0") && (strQualityBonus == "0"))
                            employeeBonusTableAdapter.Delete(Convert.ToInt32(bonusId));
                        else // update record
                            employeeBonusTableAdapter.Update(Convert.ToInt32(strEmpId),
                                Convert.ToDecimal(strBonus), Convert.ToDecimal(strQualityBonus), 
                                Convert.ToInt32(strYear), Convert.ToInt32(bonusId));
                    }
                    else  //delete record
                    {
                        employeeBonusTableAdapter.Delete(Convert.ToInt32(bonusId));
                    }
                       
                }
                else if ((strBonus != "") || (strQualityBonus != ""))
                {
                    if ((strBonus == "0") && (strQualityBonus != "0"))
                    {

                    }
                    else
                    {
                        if (strBonus == "") strBonus = "0";
                        if (strQualityBonus == "") strQualityBonus = "0";
                        //insert new record with ID
                        employeeBonusTableAdapter.Insert(Convert.ToInt32(strEmpId), Convert.ToDecimal(strBonus),
                            Convert.ToDecimal(strQualityBonus), Convert.ToInt32(strYear));
                    }
                }
            }

        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(null,null);
        }

        private void bonusDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if ((bonusDataGridView.CurrentCell.ColumnIndex == 4)|| (bonusDataGridView.CurrentCell.ColumnIndex == 5))
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
