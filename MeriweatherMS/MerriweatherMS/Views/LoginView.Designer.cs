namespace System.Windows.Forms.MMS.Views
{
    partial class LoginView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleStrip1 = new System.Windows.Forms.MMS.TitleStrip();
            this.loginControl1 = new ErikSchmidt.LoginControl();
            this.SuspendLayout();
            // 
            // titleStrip1
            // 
            this.titleStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.titleStrip1.DrawEndLine = false;
            this.titleStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.titleStrip1.GradientEndColor = System.Drawing.Color.White;
            this.titleStrip1.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(186)))), ((int)(((byte)(214)))));
            this.titleStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.titleStrip1.Lines = 10;
            this.titleStrip1.Location = new System.Drawing.Point(0, 0);
            this.titleStrip1.Name = "titleStrip1";
            this.titleStrip1.Size = new System.Drawing.Size(889, 25);
            this.titleStrip1.TabIndex = 7;
            this.titleStrip1.Text = "titleStrip1";
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.loginControl1.Check = true;
            this.loginControl1.ErrorMessage = "Please enter the correct Username / Password combination!";
            this.loginControl1.Hash = true;
            this.loginControl1.labelButton = "Login";
            this.loginControl1.labelHeader = "Please enter your Username and Password.";
            this.loginControl1.labelHeadline = "Login";
            this.loginControl1.labelPassword = "Password";
            this.loginControl1.labelUsername = "Username";
            this.loginControl1.Location = new System.Drawing.Point(23, 43);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Password = "";
            this.loginControl1.Size = new System.Drawing.Size(488, 358);
            this.loginControl1.TabIndex = 8;
            this.loginControl1.Username = "";
            this.loginControl1.Ready += new System.EventHandler(this.loginControl1_Ready);
            this.loginControl1.Successful += new System.EventHandler(this.loginControl1_Successful);
            this.loginControl1.Failed += new System.EventHandler(this.loginControl1_Failed);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.titleStrip1);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(889, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ReInitializeComponent()
        {
            this.loginControl1 = new ErikSchmidt.LoginControl();
            this.SuspendLayout();

            // 
            // loginControl1
            // 
            this.loginControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.loginControl1.Check = true;
            this.loginControl1.ErrorMessage = "Please enter the correct Username / Password combination!";
            this.loginControl1.Hash = true;
            this.loginControl1.labelButton = "Login";
            this.loginControl1.labelHeader = "Please enter your Username and Password.";
            this.loginControl1.labelHeadline = "Login";
            this.loginControl1.labelPassword = "Password";
            this.loginControl1.labelUsername = "Username";
            this.loginControl1.Location = new System.Drawing.Point(182, 120);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Password = "";
            this.loginControl1.Size = new System.Drawing.Size(460, 300);
            this.loginControl1.TabIndex = 8;
            this.loginControl1.Username = "";
            this.loginControl1.Ready += new System.EventHandler(this.loginControl1_Ready);
            this.loginControl1.Successful += new System.EventHandler(this.loginControl1_Successful);
            this.loginControl1.Failed += new System.EventHandler(this.loginControl1_Failed);
            // 
            // LoginView
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginControl1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TitleStrip titleStrip1;
        private ErikSchmidt.LoginControl loginControl1;
    }
}
