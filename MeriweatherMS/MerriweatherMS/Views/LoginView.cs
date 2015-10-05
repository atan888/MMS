using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS.Views
{
    public partial class LoginView : BaseView
    {
        public LoginView()
        {
            InitializeComponent();
            this.titleStrip1.HeaderText.Text = "Login";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
            SetPassword();
        }

        private void loginControl1_Failed(object sender, EventArgs e)
        {
            MessageBox.Show("Login failed!", "LoginControl");
        }
        public event EventHandler LoginSuccessfull;

        private void loginControl1_Successful(object sender, EventArgs e)
        {
            //MessageBox.Show("User clicked the 'Login' button!", "LoginControl");
            LoginSuccessfull(this, EventArgs.Empty);
        }

        private void loginControl1_Ready(object sender, EventArgs e)
        {
            MessageBox.Show("User clicked the 'Login' button!", "LoginControl");
        }
        public void Reset()
        {
            loginControl1.Dispose();
            ReInitializeComponent();
            SetPassword();
        }
        private void SetPassword()
        {            
            this.loginControl1.Username = "";
            this.loginControl1.Password = "";
        }
    }
}
