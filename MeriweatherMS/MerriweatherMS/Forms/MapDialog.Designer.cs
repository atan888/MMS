namespace System.Windows.Forms.MMS
{
    partial class MapDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapDialog));
            this.button13 = new System.Windows.Forms.Button();
            this.checkBoxPlacemarkInfo = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBoxCurrLat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCurrLng = new System.Windows.Forms.TextBox();
            this.groupBoxLoading = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonSetEnd = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonSetStart = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBoxCurrentMarker = new System.Windows.Forms.CheckBox();
            this.textBoxGeo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.checkBoxCanDrag = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MainMap = new System.Windows.Forms.MMS.Map();
            this.groupBox8.SuspendLayout();
            this.groupBoxLoading.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(7, 117);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 24);
            this.button13.TabIndex = 6;
            this.button13.Text = "Get Static Map";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlacemarkInfo
            // 
            this.checkBoxPlacemarkInfo.AutoSize = true;
            this.checkBoxPlacemarkInfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxPlacemarkInfo.Checked = true;
            this.checkBoxPlacemarkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPlacemarkInfo.Location = new System.Drawing.Point(94, 19);
            this.checkBoxPlacemarkInfo.Name = "checkBoxPlacemarkInfo";
            this.checkBoxPlacemarkInfo.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPlacemarkInfo.TabIndex = 1;
            this.checkBoxPlacemarkInfo.Text = "place info";
            this.checkBoxPlacemarkInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.checkBoxPlacemarkInfo);
            this.groupBox8.Controls.Add(this.button5);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Location = new System.Drawing.Point(633, 398);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(169, 74);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "markers";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 24);
            this.button7.TabIndex = 2;
            this.button7.Text = "Zoom Center";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(94, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 24);
            this.button5.TabIndex = 3;
            this.button5.Text = "Clear All";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 24);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add Marker";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(94, 117);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 24);
            this.button12.TabIndex = 7;
            this.button12.Text = "Save View";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBoxCurrLat
            // 
            this.textBoxCurrLat.Location = new System.Drawing.Point(6, 19);
            this.textBoxCurrLat.Name = "textBoxCurrLat";
            this.textBoxCurrLat.ReadOnly = true;
            this.textBoxCurrLat.Size = new System.Drawing.Size(125, 20);
            this.textBoxCurrLat.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "mode";
            // 
            // textBoxCurrLng
            // 
            this.textBoxCurrLng.Location = new System.Drawing.Point(156, 19);
            this.textBoxCurrLng.Name = "textBoxCurrLng";
            this.textBoxCurrLng.ReadOnly = true;
            this.textBoxCurrLng.Size = new System.Drawing.Size(125, 20);
            this.textBoxCurrLng.TabIndex = 2;
            // 
            // groupBoxLoading
            // 
            this.groupBoxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxLoading.Controls.Add(this.progressBar1);
            this.groupBoxLoading.Location = new System.Drawing.Point(12, 480);
            this.groupBoxLoading.Name = "groupBoxLoading";
            this.groupBoxLoading.Size = new System.Drawing.Size(169, 48);
            this.groupBoxLoading.TabIndex = 6;
            this.groupBoxLoading.TabStop = false;
            this.groupBoxLoading.Text = "loading";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(7, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Route";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(6, 46);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(125, 21);
            this.comboBoxMode.TabIndex = 2;
            this.comboBoxMode.DropDownClosed += new System.EventHandler(this.comboBoxMode_DropDownClosed);
            // 
            // buttonSetEnd
            // 
            this.buttonSetEnd.Location = new System.Drawing.Point(85, 19);
            this.buttonSetEnd.Name = "buttonSetEnd";
            this.buttonSetEnd.Size = new System.Drawing.Size(74, 27);
            this.buttonSetEnd.TabIndex = 1;
            this.buttonSetEnd.Text = "Set End";
            this.buttonSetEnd.UseVisualStyleBackColor = true;
            this.buttonSetEnd.Click += new System.EventHandler(this.buttonSetEnd_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.textBoxCurrLat);
            this.groupBox6.Controls.Add(this.textBoxCurrLng);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(202, 480);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(433, 48);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "current location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "lat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "lng";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.buttonSetEnd);
            this.groupBox7.Controls.Add(this.buttonSetStart);
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Location = new System.Drawing.Point(633, 254);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(169, 138);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "routing";
            // 
            // buttonSetStart
            // 
            this.buttonSetStart.Location = new System.Drawing.Point(6, 19);
            this.buttonSetStart.Name = "buttonSetStart";
            this.buttonSetStart.Size = new System.Drawing.Size(75, 27);
            this.buttonSetStart.TabIndex = 0;
            this.buttonSetStart.Text = "Set Start";
            this.buttonSetStart.UseVisualStyleBackColor = true;
            this.buttonSetStart.Click += new System.EventHandler(this.buttonSetStart_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(8, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 24);
            this.button6.TabIndex = 3;
            this.button6.Text = "Clear All";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxCurrentMarker
            // 
            this.checkBoxCurrentMarker.AutoSize = true;
            this.checkBoxCurrentMarker.Checked = true;
            this.checkBoxCurrentMarker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCurrentMarker.Location = new System.Drawing.Point(6, 74);
            this.checkBoxCurrentMarker.Name = "checkBoxCurrentMarker";
            this.checkBoxCurrentMarker.Size = new System.Drawing.Size(96, 17);
            this.checkBoxCurrentMarker.TabIndex = 4;
            this.checkBoxCurrentMarker.Text = "Current Marker";
            this.checkBoxCurrentMarker.UseVisualStyleBackColor = true;
            this.checkBoxCurrentMarker.CheckedChanged += new System.EventHandler(this.checkBoxCurrentMarker_CheckedChanged);
            // 
            // textBoxGeo
            // 
            this.textBoxGeo.Location = new System.Drawing.Point(8, 19);
            this.textBoxGeo.Name = "textBoxGeo";
            this.textBoxGeo.Size = new System.Drawing.Size(153, 20);
            this.textBoxGeo.TabIndex = 0;
            this.textBoxGeo.Text = "enter address";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBoxGeo);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(633, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "coordinates";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(89, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.Location = new System.Drawing.Point(8, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 24);
            this.button8.TabIndex = 1;
            this.button8.Text = "GoTo !";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.MainMap);
            this.groupBox4.Location = new System.Drawing.Point(12, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(561, 464);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Map View";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Location = new System.Drawing.Point(6, 19);
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.comboBoxMapType.Size = new System.Drawing.Size(125, 21);
            this.comboBoxMapType.TabIndex = 0;
            this.comboBoxMapType.DropDownClosed += new System.EventHandler(this.comboBoxMapType_DropDownClosed);
            // 
            // checkBoxCanDrag
            // 
            this.checkBoxCanDrag.AutoSize = true;
            this.checkBoxCanDrag.Checked = true;
            this.checkBoxCanDrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCanDrag.Location = new System.Drawing.Point(6, 97);
            this.checkBoxCanDrag.Name = "checkBoxCanDrag";
            this.checkBoxCanDrag.Size = new System.Drawing.Size(148, 17);
            this.checkBoxCanDrag.TabIndex = 5;
            this.checkBoxCanDrag.Text = "Drag Map (left mouse btn)";
            this.checkBoxCanDrag.UseVisualStyleBackColor = true;
            this.checkBoxCanDrag.Click += new System.EventHandler(this.button13_Click);
            this.checkBoxCanDrag.CheckedChanged += new System.EventHandler(this.checkBoxCanDrag_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.button13);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.comboBoxMode);
            this.groupBox5.Controls.Add(this.checkBoxCanDrag);
            this.groupBox5.Controls.Add(this.checkBoxCurrentMarker);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.comboBoxMapType);
            this.groupBox5.Location = new System.Drawing.Point(633, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 146);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "gmap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(579, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(48, 462);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "zoom";
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 443);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // MainMap
            // 
            this.MainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMap.CanDragMap = true;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.Location = new System.Drawing.Point(12, 17);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.Name = "MainMap";
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(541, 438);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 0;
            // 
            // MapDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 540);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBoxLoading);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MapDialog";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBoxLoading.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button13;
        private CheckBox checkBoxPlacemarkInfo;
        private GroupBox groupBox8;
        private Button button7;
        private Button button5;
        private Button button4;
        private Button button12;
        private TextBox textBoxCurrLat;
        private Label label8;
        private TextBox textBoxCurrLng;
        private GroupBox groupBoxLoading;
        private ProgressBar progressBar1;
        private Button button3;
        private ComboBox comboBoxMode;
        private Button buttonSetEnd;
        private GroupBox groupBox6;
        private Label label14;
        private Label label13;
        private GroupBox groupBox7;
        private Button buttonSetStart;
        private Button button6;
        private CheckBox checkBoxCurrentMarker;
        private TextBox textBoxGeo;
        private GroupBox groupBox3;
        private Button button1;
        private Button button8;
        private GroupBox groupBox4;
        private ComboBox comboBoxMapType;
        private CheckBox checkBoxCanDrag;
        private GroupBox groupBox5;
        private Label label7;
        private GroupBox groupBox2;
        private TrackBar trackBar1;
        private Map MainMap;

    }
}