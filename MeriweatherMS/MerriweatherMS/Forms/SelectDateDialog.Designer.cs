namespace System.Windows.Forms.MMS
{
    partial class SelectDateDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDateDialog));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SelectDateGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ScheduleJobCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SelectDateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(100, 140);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(189, 140);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectDateGroupBox
            // 
            this.SelectDateGroupBox.Controls.Add(this.dateTimePicker);
            this.SelectDateGroupBox.Enabled = false;
            this.SelectDateGroupBox.Location = new System.Drawing.Point(16, 65);
            this.SelectDateGroupBox.Name = "SelectDateGroupBox";
            this.SelectDateGroupBox.Size = new System.Drawing.Size(254, 63);
            this.SelectDateGroupBox.TabIndex = 1;
            this.SelectDateGroupBox.TabStop = false;
            this.SelectDateGroupBox.Text = "Select Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // ScheduleJobCheckBox
            // 
            this.ScheduleJobCheckBox.AutoSize = true;
            this.ScheduleJobCheckBox.Location = new System.Drawing.Point(16, 61);
            this.ScheduleJobCheckBox.Name = "ScheduleJobCheckBox";
            this.ScheduleJobCheckBox.Size = new System.Drawing.Size(97, 17);
            this.ScheduleJobCheckBox.TabIndex = 3;
            this.ScheduleJobCheckBox.Text = "Schedule Date";
            this.ScheduleJobCheckBox.UseVisualStyleBackColor = true;
            this.ScheduleJobCheckBox.CheckedChanged += new System.EventHandler(this.ScheduleJobCheckBox_CheckedChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(13, 18);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(142, 20);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "Message Text Line";
            // 
            // SelectDateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 185);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ScheduleJobCheckBox);
            this.Controls.Add(this.SelectDateGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDateDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule Date";
            this.SelectDateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button okButton;
        private GroupBox SelectDateGroupBox;
        private DateTimePicker dateTimePicker;
        private CheckBox ScheduleJobCheckBox;
        private Label MessageLabel;
    }
}