namespace System.Windows.Forms.MMS
{
    partial class QBBatchInvoiceDialog
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label8;
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AppendAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.DescTextBox1 = new System.Windows.Forms.ComboBox();
            this.ItemComboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerInoviceListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 28);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 17);
            label3.TabIndex = 4;
            label3.Text = "Item Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(21, 59);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(83, 17);
            label8.TabIndex = 6;
            label8.Text = "Description:";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(705, 427);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(579, 427);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppendAddressCheckBox);
            this.groupBox2.Controls.Add(this.DescTextBox1);
            this.groupBox2.Controls.Add(this.ItemComboBox1);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Location = new System.Drawing.Point(16, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(789, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice";
            // 
            // AppendAddressCheckBox
            // 
            this.AppendAddressCheckBox.AutoSize = true;
            this.AppendAddressCheckBox.Checked = true;
            this.AppendAddressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AppendAddressCheckBox.Location = new System.Drawing.Point(527, 92);
            this.AppendAddressCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AppendAddressCheckBox.Name = "AppendAddressCheckBox";
            this.AppendAddressCheckBox.Size = new System.Drawing.Size(230, 21);
            this.AppendAddressCheckBox.TabIndex = 16;
            this.AppendAddressCheckBox.Text = "Append Address to  Description";
            this.AppendAddressCheckBox.UseVisualStyleBackColor = true;
            // 
            // DescTextBox1
            // 
            this.DescTextBox1.FormattingEnabled = true;
            this.DescTextBox1.Items.AddRange(new object[] {
            "Step #1 of 4-Step Lawn Care Treatment Plan: Crabgrass Preventative/Fertilizer",
            "Step #2 of 4-Step Lawn Care Treatment Plan: Broadleaf Weed Control/Fertilizer",
            "Step #3 of 4-Step Lawn Care Treatment Plan:  Insect Control/Fertilizer",
            "Step #4 of 4-Step Lawn Care Treatment Plan: High Nitrogen Fertilizer",
            "Mow",
            "Clean Gutters",
            "Pruning as Per Estimate",
            "Mulching as Per Estimate",
            "Leaf removal; haul",
            "Leaf removal; dispose of on property",
            "Pruning",
            "Mulching",
            "Core aeration",
            "Seeding",
            "Fertilizing",
            "Lime",
            "Hauling",
            "Mulch delivery – 5 cubic yds.",
            "Mulch delivery – 10 cubic yds.",
            "Mulch delivery – 15 cubic yds."});
            this.DescTextBox1.Location = new System.Drawing.Point(113, 59);
            this.DescTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DescTextBox1.Name = "DescTextBox1";
            this.DescTextBox1.Size = new System.Drawing.Size(648, 24);
            this.DescTextBox1.TabIndex = 15;
            // 
            // ItemComboBox1
            // 
            this.ItemComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox1.FormattingEnabled = true;
            this.ItemComboBox1.Location = new System.Drawing.Point(113, 23);
            this.ItemComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ItemComboBox1.Name = "ItemComboBox1";
            this.ItemComboBox1.Size = new System.Drawing.Size(409, 24);
            this.ItemComboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Selected Job to be Invoiced in QB";
            // 
            // CustomerInoviceListBox
            // 
            this.CustomerInoviceListBox.FormattingEnabled = true;
            this.CustomerInoviceListBox.ItemHeight = 16;
            this.CustomerInoviceListBox.Location = new System.Drawing.Point(31, 28);
            this.CustomerInoviceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerInoviceListBox.Name = "CustomerInoviceListBox";
            this.CustomerInoviceListBox.Size = new System.Drawing.Size(729, 164);
            this.CustomerInoviceListBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CustomerInoviceListBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 182);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(788, 238);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(684, 208);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(64, 15);
            this.TotalLabel.TabIndex = 24;
            this.TotalLabel.Text = "Total: XXX";
            // 
            // QBBatchInvoiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QBBatchInvoiceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QB Batch Invoice Dialog";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button OKButton;
        private Button CancelButton;
        private GroupBox groupBox2;
        private ComboBox DescTextBox1;
        private ComboBox ItemComboBox1;
        private Label label2;
        private ListBox CustomerInoviceListBox;
        private GroupBox groupBox1;
        private Label TotalLabel;
        private CheckBox AppendAddressCheckBox;
    }
}