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
    public partial class SelectDateDialog : Form
    {
        DateTime SelectedDate = DateTime.Now;
        public DateTime selecteddate
        {
            get { return SelectedDate; }
            set
            {
                SelectedDate = value;
            }
        }

        public bool IsScheduledDate
        {
            get { return ScheduleJobCheckBox.Checked; }
            set
            {
                ScheduleJobCheckBox.Checked = value;
            }
        }

        public string MessageText
        {
            get { return MessageLabel.Text; }
            set
            {
                MessageLabel.Text = value;
            }
        }

        public SelectDateDialog(string szTitle)
        {
            InitializeComponent();
            this.Text = szTitle;
            dateTimePicker.Value = SelectedDate;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedDate = dateTimePicker.Value;
        }

        private void ScheduleJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SelectDateGroupBox.Enabled = ScheduleJobCheckBox.Checked;
        }
    }
}
