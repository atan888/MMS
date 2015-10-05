using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class Spine : UserControl
    {
        public Spine()
        {
            InitializeComponent();
        }

        private void Spine_Load(object sender, EventArgs e)
        {
            this.titleStrip1.HeaderText.Text = " " + DateTime.Now.ToString("MMMM dd, yyyy");
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
        }       
    }
}
