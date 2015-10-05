using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace System.Windows.Forms.MMS.Views
{
    public partial class ReportView : BaseView
    {
        public ReportView()
        {
            InitializeComponent();
          
        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            SplashScreen.SetStatus("Loading Reporting Module", false);
            this.titleStrip1.HeaderText.Text = "Reports";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            //ReportEmployeeForm dlg = new ReportEmployeeForm();
            //dlg.ShowDialog();
            //Create a new process.

            if (MMSUtility.UserPref.ReportURL.Length > 0)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                //Here you can also specify a html page on local machine
                proc.StartInfo.FileName = MMSUtility.UserPref.ReportURL;
                proc.Start();
            }
            else
            {
                MessageBox.Show("URL Path is not set in the Preferences Dialog");
            }

        }
       
    }
}
