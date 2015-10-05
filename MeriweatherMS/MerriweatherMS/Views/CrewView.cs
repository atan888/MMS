using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS.Views
{
    public partial class crewView : BaseView
    {
        public crewView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Crews";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                SplashScreen.SetStatus("Loading Crew Module", false);
            }
        }

        private void crewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
