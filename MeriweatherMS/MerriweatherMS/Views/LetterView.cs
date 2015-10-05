using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using ExtendedRichTextBox;
using System.Text.RegularExpressions;
using System.Windows.Forms.MMS;
using System.Windows.Forms.MMS.Views;
using System.Threading; 


namespace System.Windows.Forms.MMS.Views
{
    public partial class LetterView : BaseView
    {

        #region "Declaration"

        private string currentFile;
        private int checkPrint;
        private RichTextBoxPrintCtrl mTempTextControl;
        private PrintLetterDialog m_printdlg;
        private string _szOtherJobs = "";
        private bool m_StopPrint = false;
        private bool m_bPrinting = false;
        private string szErrorName = "";

        #endregion

        public LetterView()
        {
            InitializeComponent();
            mTempTextControl = new RichTextBoxPrintCtrl();
            m_printdlg = new PrintLetterDialog();
            stopPrintButton.Enabled = false;
            MaxCountTextBox.Text = m_printdlg.MaxCount.ToString();            
        }
        protected override void OnLoad(EventArgs e)
        {
            // Call base
            base.OnLoad(e);
            SplashScreen.SetStatus("Loading Letter Module", false);
            this.titleStrip1.HeaderText.Text = "Materials";
            this.titleStrip1.HeaderText.Font = new Font(this.titleStrip1.HeaderText.Font, FontStyle.Bold);
            this.titleStrip1.HeaderText.Margin = new Padding(10, 0, 0, 0);
            this.titleStrip1.HeaderText.ForeColor = Color.FromArgb(91, 89, 91);
            this.titleStrip1.HeaderText.Alignment = ToolStripItemAlignment.Right;
            if (!this.DesignMode)
            {
                //this.letterDataTableTableAdapter.Fill(this.mMSDataSet.LetterDataTable);
            }

            currentFile = "";
            this.Text = "Editor: New Document";
        }

        #region "Editor Menu Methods"

        private void NewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.Modified == true)
                {
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current document before creating new document?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        currentFile = "";
                        this.Text = "Editor: New Document";
                        rtbDoc.Modified = false;
                        rtbDoc.Clear();
                        return;
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                        rtbDoc.Modified = false;
                        rtbDoc.Clear();
                        currentFile = "";
                        this.Text = "Editor: New Document";
                        return;
                    }
                }
                else
                {
                    currentFile = "";
                    this.Text = "Editor: New Document";
                    rtbDoc.Modified = false;
                    rtbDoc.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.Modified == true)
                {
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current file before opening another document?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        rtbDoc.Modified = false;
                        OpenFile();
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                        OpenFile();
                    }
                }
                else
                {
                    OpenFile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void OpenFile()
        {
            try
            {
                OpenFileDialog1.Title = "Open File";
                OpenFileDialog1.InitialDirectory = MMSUtility.UserPref.TemplatePath;
                OpenFileDialog1.DefaultExt = "rtf";
                OpenFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                OpenFileDialog1.FilterIndex = 1;
                OpenFileDialog1.FileName = string.Empty;

                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (OpenFileDialog1.FileName == "")
                    {
                        return;
                    }

                    string strExt;
                    strExt = System.IO.Path.GetExtension(OpenFileDialog1.FileName);
                    strExt = strExt.ToUpper();

                    if (strExt == ".RTF")
                    {
                        rtbDoc.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        System.IO.StreamReader txtReader;
                        txtReader = new System.IO.StreamReader(OpenFileDialog1.FileName);
                        rtbDoc.Text = txtReader.ReadToEnd();
                        txtReader.Close();
                        txtReader = null;
                        rtbDoc.SelectionStart = 0;
                        rtbDoc.SelectionLength = 0;
                    }

                    currentFile = OpenFileDialog1.FileName;
                    rtbDoc.Modified = false;
                    this.Text = "Editor: " + currentFile.ToString();
                }
                else
                {
                    MessageBox.Show("Open File request cancelled by user.", "Cancelled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (currentFile == string.Empty)
                {
                    SaveAsToolStripMenuItem_Click(this, e);
                    return;
                }

                try
                {
                    string strExt;
                    strExt = System.IO.Path.GetExtension(currentFile);
                    strExt = strExt.ToUpper();
                    if (strExt == ".RTF")
                    {
                        rtbDoc.SaveFile(currentFile);
                    }
                    else
                    {
                        System.IO.StreamWriter txtWriter;
                        txtWriter = new System.IO.StreamWriter(currentFile);
                        txtWriter.Write(rtbDoc.Text);
                        txtWriter.Close();
                        txtWriter = null;
                        rtbDoc.SelectionStart = 0;
                        rtbDoc.SelectionLength = 0;
                    }

                    this.Text = "Editor: " + currentFile.ToString();
                    rtbDoc.Modified = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "File Save Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }


        }

        private void SaveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            try
            {
                SaveFileDialog1.Title = "Save File";
                SaveFileDialog1.DefaultExt = "rtf";
                SaveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                SaveFileDialog1.FilterIndex = 1;

                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (SaveFileDialog1.FileName == "")
                    {
                        return;
                    }

                    string strExt;
                    strExt = System.IO.Path.GetExtension(SaveFileDialog1.FileName);
                    strExt = strExt.ToUpper();

                    if (strExt == ".RTF")
                    {
                        rtbDoc.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        System.IO.StreamWriter txtWriter;
                        txtWriter = new System.IO.StreamWriter(SaveFileDialog1.FileName);
                        txtWriter.Write(rtbDoc.Text);
                        txtWriter.Close();
                        txtWriter = null;
                        rtbDoc.SelectionStart = 0;
                        rtbDoc.SelectionLength = 0;
                    }

                    currentFile = SaveFileDialog1.FileName;
                    rtbDoc.Modified = false;
                    this.Text = "Editor: " + currentFile.ToString();
                    MessageBox.Show(currentFile.ToString() + " saved.", "File Save");
                }
                else
                {
                    MessageBox.Show("Save File request cancelled by user.", "Cancelled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.Modified == true)
                {
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save this document before closing?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        rtbDoc.Modified = false;
                        Application.Exit();
                    }
                }
                else
                {
                    rtbDoc.Modified = false;
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to select all document content.", "MMS - Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Copy();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to copy document content.", "MMS - Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Cut();
            }
            catch
            {
                MessageBox.Show("Unable to cut document content.", "MMS - Cut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.Paste();
            }
            catch
            {
                MessageBox.Show("Unable to copy clipboard content to document.", "MMS - Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectFontToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    FontDialog1.Font = rtbDoc.SelectionFont;
                }
                else
                {
                    FontDialog1.Font = null;
                }
                FontDialog1.ShowApply = true;
                if (FontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbDoc.SelectionFont = FontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void FontColorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                ColorDialog1.Color = rtbDoc.ForeColor;
                if (ColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbDoc.SelectionColor = ColorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void BoldToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Bold;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void ItalicToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Italic;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void UnderlineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = rtbDoc.SelectionFont.Style ^ FontStyle.Underline;

                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void NormalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!(rtbDoc.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = rtbDoc.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;
                    newFontStyle = FontStyle.Regular;
                    rtbDoc.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void PageColorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                ColorDialog1.Color = rtbDoc.BackColor;
                if (ColorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    rtbDoc.BackColor = ColorDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuUndo_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.CanUndo)
                {
                    rtbDoc.Undo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuRedo_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (rtbDoc.CanRedo)
                {
                    rtbDoc.Redo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void LeftToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void CenterToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void RightToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void AddBulletsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.BulletIndent = 10;
                rtbDoc.SelectionBullet = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void RemoveBulletsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionBullet = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent0_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent5_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent10_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent15_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 15;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void mnuIndent20_Click(object sender, System.EventArgs e)
        {
            try
            {
                rtbDoc.SelectionIndent = 20;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        private void FindToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                LetterTemplateFind f = new LetterTemplateFind(this);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void FindAndReplaceToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            try
            {
                LetterTemplateReplace f = new LetterTemplateReplace(this);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void InsertImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            OpenFileDialog1.Title = "Insert Image File";
            OpenFileDialog1.DefaultExt = "rtf";
            OpenFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif";
            OpenFileDialog1.FilterIndex = 1;
            OpenFileDialog1.ShowDialog();

            if (OpenFileDialog1.FileName == "")
            {
                return;
            }

            try
            {
                string strImagePath = OpenFileDialog1.FileName;
                Image img;
                img = Image.FromFile(strImagePath);
                Clipboard.SetDataObject(img);
                DataFormats.Format df;
                df = DataFormats.GetFormat(DataFormats.Bitmap);
                if (this.rtbDoc.CanPaste(df))
                {
                    this.rtbDoc.Paste(df);
                }
            }
            catch
            {
                MessageBox.Show("Unable to insert image format selected.", "MMS - Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtbDoc_SelectionChanged(object sender, EventArgs e)
        {
            if (m_bPrinting) return;

            tbrBold.Checked = rtbDoc.SelectionFont.Bold;
            tbrItalic.Checked = rtbDoc.SelectionFont.Italic;
            tbrUnderline.Checked = rtbDoc.SelectionFont.Underline;
        }

        private void InsertVariableButton_Click(object sender, EventArgs e)
        {
            string szVariable = VariableListBox.Text;
            //int nStart = rtbDoc.SelectionStart;
            //Color saveColor = rtbDoc.SelectionColor;
            //Font saveFont = rtbDoc.SelectionFont;

            rtbDoc.SelectedText = szVariable;
            //rtbDoc.SelectionStart = nStart;
            //rtbDoc.SelectionLength = szVariable.Length;
            //rtbDoc.SelectionFont = new Font("Verdana", 8F, FontStyle.Italic, GraphicsUnit.Point);
            //rtbDoc.SelectionColor = Color.CadetBlue;

            //rtbDoc.SelectionStart = nStart + szVariable.Length;
            //rtbDoc.SelectionColor = saveColor
            //rtbDoc.SelectionFont = saveFont;
            rtbDoc.Focus();
        }

        public override void EditFunction(string szFunction)
        {
            switch (szFunction)
            {
                case "Undo":
                    mnuUndo_Click(null, null);
                    break;
                case "Redo":
                    mnuRedo_Click(null, null);
                    break;
                case "Cut":
                    CutToolStripMenuItem_Click(null, null);
                    break;
                case "Copy":
                    CopyToolStripMenuItem_Click(null, null);
                    break;
                case "Paste":
                    PasteToolStripMenuItem_Click(null, null);
                    break;
                case "SelectAll":
                    SelectAllToolStripMenuItem_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void LetterTemplateEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (rtbDoc.Modified == true)
                {
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current document before exiting?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        rtbDoc.Modified = false;
                        rtbDoc.Clear();
                        return;
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                    }
                }
                else
                {
                    rtbDoc.Clear();
                }
                currentFile = "";
                this.Text = "Editor: New Document";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        #region Toolbar Methods


        private void tbrSave_Click(object sender, System.EventArgs e)
        {
            SaveToolStripMenuItem_Click(this, e);
        }


        private void tbrOpen_Click(object sender, System.EventArgs e)
        {
            OpenToolStripMenuItem_Click(this, e);
        }


        private void tbrNew_Click(object sender, System.EventArgs e)
        {
            NewToolStripMenuItem_Click(this, e);
        }


        private void tbrBold_Click(object sender, System.EventArgs e)
        {
            BoldToolStripMenuItem_Click(this, e);
        }


        private void tbrItalic_Click(object sender, System.EventArgs e)
        {
            ItalicToolStripMenuItem_Click(this, e);
        }


        private void tbrUnderline_Click(object sender, System.EventArgs e)
        {
            UnderlineToolStripMenuItem_Click(this, e);
        }


        private void tbrFont_Click(object sender, System.EventArgs e)
        {
            SelectFontToolStripMenuItem_Click(this, e);
        }


        private void tbrLeft_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Left;
        }


        private void tbrCenter_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Center;
        }


        private void tbrRight_Click(object sender, System.EventArgs e)
        {
            rtbDoc.SelectionAlignment = HorizontalAlignment.Right;
        }


        private void tbrFind_Click(object sender, System.EventArgs e)
        {
            LetterTemplateFind f = new LetterTemplateFind(this);
            f.Show();
        }


        private void tspColor_Click(object sender, EventArgs e)
        {
            FontColorToolStripMenuItem_Click(this, new EventArgs());
        }




        #endregion


        #region Printing

        public override void PageSetup()
        {
            try
            {

                PageSetupDialog1.Document = PrintDocument1;
                if (null != MMSUtility.myPageSettings)
                    PageSetupDialog1.PageSettings = MMSUtility.myPageSettings;

                if (PageSetupDialog1.ShowDialog() == DialogResult.OK)
                {
                    MMSUtility.myPageSettings = PageSetupDialog1.PageSettings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        //Import Cusotmer List Button
        private void ImportListBtn_Click(object sender, EventArgs e)
        {
            m_printdlg.Initialize();
            m_printdlg.ShowDialog();  //import list dialog
            MaxCountTextBox.Text = m_printdlg.MaxCount.ToString();
            stopNumericUpDown.Maximum = m_printdlg.MaxCount;
            startNumericUpDown.Maximum = m_printdlg.MaxCount; 
        }

        public void OnPrint(object sender, EventArgs e)
        {
            Print();
        }

        public override void Print()
        {
            if (m_printdlg.MaxCount < 1)
            {
                MessageBox.Show("Please Import Customer List for Printing!", "Warning");
                return;
            }
            
            int nStart = Convert.ToInt32(startNumericUpDown.Value);
            int nStop = Convert.ToInt32(stopNumericUpDown.Value);
            int nDelay = Convert.ToInt32(delayNumericUpDown.Value);
            MainForm pParent = (MainForm)this.ParentForm;

            if (nStop > m_printdlg.MaxCount)
            {
                nStop = m_printdlg.MaxCount;
                stopNumericUpDown.Maximum = nStop;
                stopNumericUpDown.Value = nStop;
            }

            if (nStart >= nStop)
            {
                MessageBox.Show("Start Count is greater than Stop", "Error");
                return;
            }

            if (MessageBox.Show("This process may take time depending on the number of records to print?",
               "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                DataSet da = m_printdlg.GetCustomerList();
                //int numJob = PrintMergeDocument(da, "All", false, nStart, nStop, nDelay, false);
                int numJob = PrintMergeDocument(da, "All", PreviewCheckBox.Checked, nStart, nStop, nDelay, false );
            }

            /*
            m_StopPrint = false;
            OutputTxtBox.Clear();
            stopPrintButton.Enabled = true;
            if (PrintDialog1.ShowDialog() == DialogResult.OK)
            {
                mTempTextControl.Clear();
                rtbDoc.SelectAll();
                rtbDoc.Copy();
                mTempTextControl.SelectAll();
                mTempTextControl.Paste();

                stopPrintButton.Enabled = true;
                pParent.SetStatusLabel("Begin Print");
                m_StopPrint = false;
                pParent.ProgressBarInit(0, nStop-nStart+1, 1);
                pParent.enableMainButtons(false);
                
                for (int i = nStart-1; i < nStop; i++)
                {
                    pParent.ProgressBarUpdate();
                    pParent.SetStatusLabel("Printing Record: " + (i + 1).ToString());

                    PrintDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();
                    PrintDocument1.Print();

                    Application.DoEvents();
                    Thread.Sleep(250);
                    if (m_StopPrint)
                    {
                        pParent.SetStatusLabel("Print Cancelled");                        
                        pParent.ProgressBarEnd();
                        break;
                    }
                }
                if (!m_StopPrint)
                    pParent.SetStatusLabel("Print Complete");
            }

            stopPrintButton.Enabled = false;            
            pParent.enableMainButtons(true);
            Thread.Sleep(1000);
            pParent.SetStatusLabel("");
            */
        }

        public int PrintMergeDocumentTest(DataSet da, string szGroup, bool bFirstRecordOnly, int nStart, int nStop, int nDelay, bool bPreview)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            
            pParent.ProgressBarInit(0, nStop - nStart + 1, 1);
            m_StopPrint = false;

            if (PrintDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                for (int i = nStart; i <= nStop; i++)
                {
                    int pc = (int)((double)((i / nStop) * 100));

                    string fname = da.Tables["Customers"].Rows[i - 1].ItemArray.GetValue(0).ToString();
                    string lname = da.Tables["Customers"].Rows[i - 1].ItemArray.GetValue(1).ToString();

                    //m_printdlg.UpdatePrintStatus("Printing Record: " + i.ToString(), pc);
                    PrintToOutput("Printing Record: " + fname + " " + lname);

                    pParent.ProgressBarUpdate();
                    Thread.Sleep(nDelay * 1000);

                    if (m_StopPrint)
                    {
                        PrintToOutput("Printing Aborted...");
                        break;
                    }
                    
                    
                }
                if (!m_StopPrint)
                    PrintToOutput("Printing Completed...");
            }

            return 0;
        }

        public int PrintMergeDocument(DataSet da, string szGroup, bool bFirstRecordOnly, int nStart, int nStop, int nDelay, bool bPreview)
        {
            string szLastName = "";
            string szFirstName = "";
            //string szDescription = "";
            string szAddress = "";
            string szCity = "";
            string szState = "";
            string szZip = "";
            string szPropAddress = "";
            string szPropCity = "";
            string szPropState = "";
            string szPropZip = "";
            //string szSubdivision = "";
            string szPropMow = "";
            string szPropFourStep = "";
            string szPropSeed = "";
            string szPropFertilize = "";
            string szPropLime = "";
            string szPropAeration = "";
            string szSpringServices = "";
            string szSummerServices = "";
            string szFallServices = "";
            string szWinterServices = "";
            string szGroupType = "";
            string szCost = "";
            string szFourStepCost = "";
            string szFourStepType = "";
            int ncount = 0;            
            m_StopPrint = false;
            bool bMowCustomer = false;
            bool b4StepCustomer = false;
            bool bFormer4StepCustomer = false;

            try
            {
                MainForm pParent = (MainForm)this.ParentForm;
                //PrintDialog1.Document = PrintDocument1;

                if (null != MMSUtility.myPrinterSettings)
                    PrintDialog1.PrinterSettings = MMSUtility.myPrinterSettings;

                if (null != MMSUtility.myPageSettings)
                    PrintDialog1.Document.DefaultPageSettings = MMSUtility.myPageSettings;


                if (PrintDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MMSUtility.myPrinterSettings = PrintDialog1.PrinterSettings;
                    m_bPrinting = true;                    
                    m_StopPrint = false;

                    OutputTxtBox.Clear();
                    ErrorTextBox.Clear();
                    stopPrintButton.Enabled = true;
                    pParent.enableMainButtons(false);                    
                    pParent.SetStatusLabel("Starting Print Jobs...");                    

                    if (szGroup == "Template")
                    {
                        //mTempTextControl.Text = rtbDoc.Text;
                        mTempTextControl.Clear();
                        rtbDoc.SelectAll();
                        rtbDoc.Copy();
                        mTempTextControl.SelectAll();
                        mTempTextControl.Paste();
                        PrintDocument1.Print();
                        ncount = 1;
                    }
                    else
                    {
                        System.Windows.Forms.MMS.Data.MMSDataSet.LetterDataTableDataTable myDataTable = new System.Windows.Forms.MMS.Data.MMSDataSet.LetterDataTableDataTable();
                        pParent.ProgressBarInit(0, nStop - nStart + 1, 1);

                        //start merge and print each letter                                                
                        for (int i = nStart; i <= nStop; i++)
                        {
                            szErrorName = "";
                            bMowCustomer = false;
                            bFormer4StepCustomer = false;
                            b4StepCustomer = false;
                            string fname = da.Tables["Customers"].Rows[i - 1].ItemArray.GetValue(0).ToString();
                            string lname = da.Tables["Customers"].Rows[i - 1].ItemArray.GetValue(1).ToString();
                            string accnum = da.Tables["Customers"].Rows[i - 1].ItemArray.GetValue(2).ToString();

                            //using accunum for the property address wildcard" and use FillbyCustomer2 below
                            if ((accnum == null)||(accnum == "0"))
                            {
                                accnum = "%";
                            }
                            else {
                                int len = accnum.Length;
                                if (accnum.Length > 3) len = 3;
                                accnum = accnum.Substring(0, len);
                                accnum = "%" + accnum + "%";
                            }

                            //if (accnum == "0") accnum = " ";

                            if (bPreview)
                            {
                                letterDataTableTableAdapter.Fill(myDataTable);
                            }
                            else
                            {
                                //letterDataTableTableAdapter.FillByCustomerName(myDataTable, lname, fname, accnum);
                                //lname = lname.Replace("'", "''");
                                if (fname == "") fname = " ";
                                //use lastname, firstname and address - accnum veriable is reused
                                letterDataTableTableAdapter.FillByCustomerName2(myDataTable, lname, fname, accnum);
                            }

                            if (myDataTable.Rows.Count < 1)
                            {
                                PrintToErrorOutput("Error:" + fname + " " + lname + "," + accnum + ", not found in database.");
                            }
                            else
                            {

                                int pc = (int)((double)(((double)i / (double)nStop)) * 100);
                                PrintToOutput("Print: " + i.ToString() + ": " + fname + " " + lname + "," + accnum);
                                pParent.SetStatusLabel("Printing Record: " + (i).ToString());
                                szErrorName = "Record: " + (i).ToString() + " " + fname + "," + lname + ":";

                                DataRow dRow = myDataTable.Rows[0];
                                szWinterServices = dRow["WinterServices"].ToString();
                                if ((szWinterServices == "")&&(myDataTable.Rows.Count > 1))
                                {
                                    dRow = myDataTable.Rows[1];
                                }


                                //clear and print new document
                                mTempTextControl.Clear();
                                rtbDoc.SelectAll();
                                rtbDoc.Copy();
                                mTempTextControl.SelectAll();
                                mTempTextControl.Paste();

                                szLastName = dRow["LastName"].ToString();
                                szFirstName = dRow["FirstName"].ToString();
                                //szDescription = dRow["Description"].ToString();
                                szAddress = dRow["Address"].ToString();
                                szCity = dRow["City"].ToString();
                                szState = dRow["State"].ToString();
                                szZip = dRow["Zip"].ToString();

                                szPropAddress = dRow["PropAddress"].ToString();
                                szPropCity = dRow["PropCity"].ToString();
                                szPropState = dRow["PropState"].ToString();
                                szPropZip = dRow["PropZip"].ToString();

                                //szSubdivision = dRow["Subdivision"].ToString();
                                
                                szPropMow = dRow["PropMow"].ToString();
                                if (szPropMow == "") szPropMow = "0.00";
                                else szPropMow = szPropMow.Remove(szPropMow.Length - 2);

                                szPropFourStep = dRow["PropFourStep"].ToString();
                                if (szPropFourStep == "") szPropFourStep = "0.00";
                                else szPropFourStep = szPropFourStep.Remove(szPropFourStep.Length - 2);

                                szPropSeed = dRow["PropSeed"].ToString();
                                if (szPropSeed == "") szPropSeed = "0.00";
                                else szPropSeed = szPropSeed.Remove(szPropSeed.Length - 2);

                                szPropFertilize = dRow["PropFertilize"].ToString();
                                if (szPropFertilize == "") szPropFertilize = "0.00";
                                else szPropFertilize = szPropFertilize.Remove(szPropFertilize.Length - 2);

                                szPropLime = dRow["PropLime"].ToString();
                                if (szPropLime == "") szPropLime = "0.00";
                                else szPropLime = szPropLime.Remove(szPropLime.Length - 2);

                                szPropAeration = dRow["PropAeration"].ToString();
                                if (szPropAeration == "") szPropAeration = "0.00";
                                else szPropAeration = szPropAeration.Remove(szPropAeration.Length - 2);
                               
                                szSpringServices = dRow["SpringServices"].ToString();
                                szSummerServices = dRow["SummerServices"].ToString();
                                szFallServices = dRow["FallServices"].ToString();
                                szWinterServices = dRow["WinterServices"].ToString();

                                szGroupType = dRow["GroupType"].ToString();

                                szCost = dRow["Cost"].ToString();
                                if (szCost == "") szCost = "0.00";
                                else szCost = szCost.Remove(szCost.Length - 2);

                                if (szCost == "0.00")
                                    szCost = "";

                                szFourStepCost = dRow["FourStepCost"].ToString();
                                if (szFourStepCost == "") szFourStepCost = "0.00";
                                else szFourStepCost = szFourStepCost.Remove(szFourStepCost.Length - 2);

                                szFourStepType = dRow["FourStepType"].ToString();
                                if (szFourStepType == "True") 
                                    b4StepCustomer = true;

                                //replace text with variable fields
                                if (szFirstName == "")
                                {
                                    //szFirstName = "Customer"; //make it generic
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("Dear [CustomerFirstName]", szLastName);
                                }
                                else
                                {
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerFirstName]", szFirstName);
                                }

                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerFirstName]", szFirstName);
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerLastName]", szLastName);
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerAddress]", szAddress);
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerCity]", szCity);
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerState]", szState);
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[CustomerZip]", szZip);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyDescription]", szDescription);

                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyAddress]", szPropAddress);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyCity]", szPropCity);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyState]", szPropState);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyZip]", szPropZip);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[MowCost]", szCost);
                                //mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertySubDivision]", szSubdivision);

                                string szText = "";
                                if ((szCost != "0.00")&&(szCost != "")) szText = "$" + szCost + " per cut";
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[MowCost]", szText);

                                szText = "";
                                if ((szFourStepCost != "0.00") && (szFourStepCost != "")) szText = "$" + szFourStepCost + " per step";
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[FourStepCost]", szText);


                                //header
                                szText = "We have done this at some point in the past:\n";
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[ServicesCommentHeader]", szText);

                                ///SPRING/////////////////////////////////////////////////////////////////////////////////////////////////////
                                if (mTempTextControl.Text.Contains("PropertyListSpringServices"))
                                {
                                    string[] szExtraServices = new string[] 
                                        { "* Mowing          [PropMow]", 
                                          "* Spring cleanup", 
                                          "* Mulching", 
                                          "* 4-Step Lawn Treatment Program (see info enclosed)        [PropFourStep]", 
                                          "* Seeding         [PropSeed]", 
                                          "* Fertilization          [PropFertilize]", 
                                          "* Liming          [PropLime]",
                                          "* Core aeration          [PropAeration]", 
                                          "* Pruning", 
                                        };

                                    if (szSpringServices == "0") szSpringServices = "";
                                    string[] szServiceCodes = szSpringServices.Split(',');
                                    string[] szServices = FindServiceCodes(szSpringServices);

                                    if ((szSpringServices.Length > 0) || (szCost.Length > 0) || (szFourStepCost.Length > 0))
                                    {
                                        int nstart = mTempTextControl.Find("[PropertyListSpringServices]", 0);

                                        //infrequent mowing customers with cost then print
                                        if (szCost.Length > 0)
                                        {
                                            if (szGroupType == "InFrequent")
                                            {
                                                if ((szCost != "0.00") && (szCost != ""))
                                                {
                                                    szText = "* Mowing     Approximate price: $" + szCost + " per cut";
                                                    //else szText = "* Mowing";
                                                    mTempTextControl.SelectionStart = nstart;
                                                    mTempTextControl.SelectionLength = 0;
                                                    mTempTextControl.SelectedText = szText + "\n";
                                                    nstart += szText.Length + 1;
                                                    bMowCustomer = true;
                                                }
                                            }
                                        }

                                        if ((!b4StepCustomer)&&(szFourStepCost.Length > 0) && (szFourStepCost != "0.00") && (szFourStepCost != ""))
                                        {
                                            szText = "* 4-Step Lawn Treatment Program (see info enclosed)    Approximate price: $" + szFourStepCost + " per step";
                                            mTempTextControl.SelectionStart = nstart;
                                            mTempTextControl.SelectionLength = 0;
                                            mTempTextControl.SelectedText = szText + "\n";
                                            nstart += szText.Length + 1;
                                            bFormer4StepCustomer = true;
                                        }

                                        bool bDoit = false;
                                        int nIndex = 0;
                                        if (szSpringServices.Length > 0)
                                        {
                                            foreach (string str in szServices)
                                            {
                                                if (((bFormer4StepCustomer)||(b4StepCustomer)) && (str.Contains("4-Step")))
                                                {
                                                    //do nthing
                                                }
                                                else if (str != "")
                                                {

                                                    bDoit = true;
                                                    int nNumJob = ParseJobCode(szServiceCodes[nIndex]);
                                                    if (nNumJob == 101) //other jobs
                                                    {
                                                        if (_szOtherJobs.Length > 1)
                                                        {
                                                            szText = _szOtherJobs;
                                                        }
                                                        else
                                                            szText = "Others";

                                                        _szOtherJobs = "";
                                                    }
                                                    else if (nNumJob > 0)
                                                        szText = str + " - (" + nNumJob.ToString() + " times)";
                                                    else
                                                        szText = str;

                                                    mTempTextControl.SelectionStart = nstart;
                                                    mTempTextControl.SelectionLength = 0;
                                                    mTempTextControl.SelectedText = szText + "\n";
                                                    nstart += szText.Length + 1;
                                                }
                                                nIndex++;
                                            }


                                        }
                                        
                                        if ((!bDoit)&&(bMowCustomer == false)&&(bFormer4StepCustomer == false))  //no spring services code
                                        {
                                            szText = "We have done this at some point in the past:";
                                            mTempTextControl.Rtf = mTempTextControl.Rtf.Replace(szText, "");
                                        }

                                        //add spaces to fill up to 8 spaces
                                        if (nIndex > 0)
                                        {
                                            int nMax = 2 - nIndex;
                                            szText = "";
                                            for (int j = 0; j < nMax; j++)
                                            {
                                                szText += "\n";
                                            }
                                            if (szText.Length > 0)
                                            {
                                                mTempTextControl.SelectionStart = nstart;
                                                mTempTextControl.SelectionLength = 0;
                                                mTempTextControl.SelectedText = szText;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[ServicesCommentHeader]", "\n");
                                        szText = "We have done this at some point in the past:";
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace(szText, "");

                                    }

                                    if (szGroupType == "Current")
                                    {
                                        bMowCustomer = true;
                                    }

                                    //you might consider giving us a shot at this
                                    int nstart2 = mTempTextControl.Find("[PropertyExtraListSpringServices]", 0);

                                    int zStart = 0;
                                    if (bMowCustomer) zStart = 1;
                                    for (int k = zStart; k < szExtraServices.Length; k++)
                                    {
                                        if ((k == 3) && ((bFormer4StepCustomer)||(b4StepCustomer))) k++;  //skip 4step

                                        bool bSkip = false;                                                                                
                                        if (((szServices != null)&&((szServices.Length > 1) || (szServices[0].Length > 0))))
                                        {
                                            for (int z = 0; z < szServices.Length; z++)
                                            {
                                                if (szExtraServices[k].Contains(szServices[z]))
                                                {
                                                    bSkip = true;
                                                }
                                                
                                            }
                                        }
                                        /*
                                        if (!bSkip) 
                                        {
                                            mTempTextControl.SelectionStart = nstart2;
                                            mTempTextControl.SelectionLength = 0;
                                            szText = szExtraServices[k];
                                            mTempTextControl.SelectedText = szText + "\n";
                                            nstart2 += szText.Length + 1;
                                        }*/
                                    }

                                    szText = "";
                                    if ((szPropMow != "0.00")&&(szPropMow != "")) szText = "Approximate price: $" + szPropMow + " per cut";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropMow]", szText);

                                    szText = "";
                                    if ((szPropFourStep != "0.00") && (szPropFourStep != "")) szText = "App. price: $" + szPropFourStep + " per step";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropFourStep]", szText);

                                    szText = "";
                                    if ((szPropSeed != "0.00") && (szPropSeed != "")) szText = "Approximate price: $" + szPropSeed + " per application";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropSeed]", szText);

                                    szText = "";
                                    if ((szPropFertilize != "0.00") && (szPropFertilize != "")) szText = "Approximate price: $" + szPropFertilize + " per application";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropFertilize]", szText);

                                    szText = "";
                                    if ((szPropLime != "0.00") && (szPropLime != "")) szText = "Approximate price: $" + szPropLime + " per application";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropLime]", szText);

                                    szText = "";
                                    if ((szPropAeration != "0.00") && (szPropAeration != "")) szText = "Approximate price: $" + szPropAeration + " per aeration";
                                    mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropAeration]", szText);
                                }

                                //What if there is no services...should we print out something?
                                //remove this datafield marker
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyListSpringServices]", "");
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyExtraListSpringServices]", "");


                                ///SUMMER/////////////////////////////////////////////////////////////////////////////////////////////////////
                                if ((szSummerServices.Length > 0) && (mTempTextControl.Text.Contains("PropertyListSummerServices")))
                                {
                                    //summer services
                                    if ((szSummerServices.Length > 0) || (szCost.Length > 0))
                                    {
                                        string[] szServiceCodes = szSummerServices.Split(',');
                                        string[] szServices = FindServiceCodes(szSummerServices);
                                        string[,] szRemainderServices = FindRemainderServices(szServices);

                                        int nstart = mTempTextControl.Find("[PropertyListSummerServices]", 0);

                                        int nIndex = 0;
                                        if (szSummerServices.Length > 0)
                                        {
                                            foreach (string str in szServices)
                                            {
                                                if (str != "")
                                                {
                                                    int nNumJob = ParseJobCode(szServiceCodes[nIndex]);
                                                    if (nNumJob == 101) //other jobs
                                                    {
                                                        if (_szOtherJobs.Length > 1)
                                                        {
                                                            szText = _szOtherJobs;
                                                        }
                                                        else
                                                            szText = "Others";

                                                        _szOtherJobs = "";
                                                    }
                                                    else if (nNumJob > 0)
                                                        szText = str + " - (" + nNumJob.ToString() + " times)";
                                                    else
                                                        szText = str;

                                                    mTempTextControl.SelectionStart = nstart;
                                                    mTempTextControl.SelectionLength = 0;
                                                    mTempTextControl.SelectedText = szText + "\n";
                                                    nstart += szText.Length + 1;
                                                }
                                                nIndex++;
                                            }
                                        }


                                        //add remainder services  
                                        nstart = mTempTextControl.Find("[RemainderListSummerServices]", 0);
                                        nIndex = 0;
                                        for (int j = 0; j < 10; j++)
                                        {
                                            if (szRemainderServices[j, 1] == "True")
                                            {
                                                mTempTextControl.SelectionStart = nstart;
                                                mTempTextControl.SelectionLength = 0;
                                                mTempTextControl.SelectedText = szRemainderServices[j, 0] + "\n";
                                                nstart += szRemainderServices[j, 0].Length + 1;
                                            }
                                        }
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[RemainderListSummerServices]", "\n");
                                    }
                                    else
                                    {
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[ServicesCommentHeader]", "\n");
                                    }

                                }
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyListSummerServices]", "");

                                // FALL //////////////////////////////////////////////////////////////////////////////////////////////////////
                                if (szFallServices == "0") szFallServices = "";
                                if ((szFallServices.Length > 0) && 
                                    (mTempTextControl.Text.Contains("PropertyListFallServices") ||
                                     mTempTextControl.Text.Contains("PropertyListFallLeafGutterServices")))
                                {
                                    //fall services                                    
                                    if ((szFallServices.Length > 0) || (szCost.Length > 0))
                                    {
                                        string[] szServiceCodes = szFallServices.Split(',');
                                        //string[,] szRemainderServices = FindRemainderServices(szServices);

                                        string[] szServices;
                                        int nstart = 0;
                                        if (mTempTextControl.Text.Contains("PropertyListFallServices"))
                                        {
                                            szServices = FindFallServiceCodes(szFallServices);
                                            nstart = mTempTextControl.Find("[PropertyListFallServices]", 0);
                                        }
                                        else
                                        {
                                            szServices = FindFallServiceCodes2(szFallServices);
                                            nstart = mTempTextControl.Find("[PropertyListFallLeafGutterServices]", 0);
                                        }
                                        
                                        int nIndex = 0;
                                        if (szFallServices.Length > 0)
                                        {
                                            foreach (string str in szServices)
                                            {
                                                if (str != "")
                                                {
                                                    int nNumJob = ParseJobCode(szServiceCodes[nIndex]);
                                                    if (nNumJob == 101) //other jobs
                                                    {
                                                        if (_szOtherJobs.Length > 1)
                                                        {
                                                            szText = _szOtherJobs;
                                                        }
                                                        else
                                                            szText = "Others";

                                                        _szOtherJobs = "";
                                                    }
                                                    else if (nNumJob > 0)
                                                        szText = str + " - (" + nNumJob.ToString() + " times)";
                                                    else
                                                        szText = str;

                                                    mTempTextControl.SelectionStart = nstart;
                                                    mTempTextControl.SelectionLength = 0;
                                                    mTempTextControl.SelectedText = szText + "\n";
                                                    nstart += szText.Length + 1;
                                                }
                                                nIndex++;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[ServicesCommentHeader]", "\n");
                                    }

                                }
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyListFallServices]", "");
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyListFallLeafGutterServices]", "");

                                // WINTER //////////////////////////////////////////////////////////////////////////////////////////////////////

                                if ((szWinterServices.Length > 0) && (mTempTextControl.Text.Contains("PropertyListWinterServices")))
                                {
                                    //summer services
                                    if ((szWinterServices.Length > 0) || (szCost.Length > 0))
                                    {
                                        string[] szServiceCodes = szWinterServices.Split(',');
                                        string[] szServices = FindServiceCodes(szWinterServices);

                                        int nstart = mTempTextControl.Find("[PropertyListWinterServices]", 0);

                                        int nIndex = 0;
                                        if (szWinterServices.Length > 0)
                                        {
                                            foreach (string str in szServices)
                                            {
                                                if (str != "")
                                                {
                                                    int nNumJob = ParseJobCode(szServiceCodes[nIndex]);
                                                    if (nNumJob == 101) //other jobs
                                                    {
                                                        if (_szOtherJobs.Length > 1)
                                                        {
                                                            szText = _szOtherJobs;
                                                        }
                                                        else
                                                            szText = "Others";

                                                        _szOtherJobs = "";
                                                    }
                                                    else if (nNumJob > 0)
                                                        szText = str + " - (" + nNumJob.ToString() + " times)";
                                                    else
                                                        szText = str;

                                                    mTempTextControl.SelectionStart = nstart;
                                                    mTempTextControl.SelectionLength = 0;
                                                    mTempTextControl.SelectedText = szText + "\n";
                                                    nstart += szText.Length + 1;
                                                }
                                                nIndex++;
                                            }
                                        }


                                    }
                                    else
                                    {
                                        mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[ServicesCommentHeader]", "\n");
                                    }

                                }
                                mTempTextControl.Rtf = mTempTextControl.Rtf.Replace("[PropertyListWinterServices]", "");


                                ////////////////////////////////////////////////////////////////////////////////////////////////////////
                                pParent.ProgressBarUpdate();
                               
                                //if (!bFirstRecordOnly)
                                //{  //runtrhought
                                    Thread.Sleep(nDelay * 1000);
                                    ncount++;
                                //}
                               
                                if (bPreview)
                                {
                                    PrintPreviewDialog1.Document = PrintDocument1;
                                    PrintPreviewDialog1.ShowDialog();
                                }
                                else
                                {
                                    if (!bFirstRecordOnly)
                                    {  //runtrhought
                                        PrintDocument1.PrintController = new System.Drawing.Printing.StandardPrintController();                                    //
                                        PrintDocument1.Print();
                                    }
                                }

                                if (m_StopPrint)
                                {
                                    pParent.SetStatusLabel("Printing Aborted...");
                                    PrintToOutput("Printing Aborted...");                                       
                                    pParent.ProgressBarEnd();
                                    break;
                                }
                            }
                        }

                        if (!m_StopPrint)
                        {
                            pParent.SetStatusLabel("Printing Completed...");
                            PrintToOutput("Printing Complete...");
                        }
                    }

                    m_bPrinting = false;
                    stopPrintButton.Enabled = false;
                    pParent.enableMainButtons(true);
                    Thread.Sleep(1000);
                    pParent.SetStatusLabel("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            return ncount;
        }

        public override void PrintPreview()
        {
            try
            {
                if (mTempTextControl != null) 
                mTempTextControl.Clear();
                rtbDoc.SelectAll();
                rtbDoc.Copy();
                mTempTextControl.SelectAll();
                mTempTextControl.Paste();
                PrintPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void PrintDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            checkPrint = mTempTextControl.Print(checkPrint, mTempTextControl.TextLength, e);

            if (checkPrint < mTempTextControl.TextLength)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

        }

        private void stopPrintButton_Click(object sender, EventArgs e)
        {
            m_StopPrint = true;
        }


        private int ParseJobCode(string szJobCode)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            try
            {
                int nNumJob = 0;
                //string[] szCodes = Regex.Split(szJobCode, "\w+(\(.*\))");
                //if (szCodes.Length > 0)
                //  nNumJob = Convert.ToInt32(szCodes[1]);

                string[] szCodes = szJobCode.Split(new char[] { '(', ')' });

                if (szJobCode.StartsWith("o"))
                {
                    //upper case first letter
                    _szOtherJobs = szCodes[1];
                    _szOtherJobs = "* " + char.ToUpper(_szOtherJobs[0]) + _szOtherJobs.Substring(1);
                    return 101; //other job code
                }
                else if (szCodes.Length > 2)
                {
                    nNumJob = Convert.ToInt32(szCodes[1]);
                }

                return nNumJob;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString() + "Error Code: " + szJobCode, "Error");
                PrintToOutput(ex.Message.ToString() + "Error Code: " + szJobCode);
                return 0;
            }
        }

        private string[,] FindRemainderServices(string[] szServices)
        {
            //2-12-13 for summer, rod ask to remove the last 3 to make room on the sheet so it does not span to second page.

            string[,] szRemainderServices = new string[10, 2];
            szRemainderServices[0, 0] = "* Tree Work";
            szRemainderServices[1, 0] = "* Brush Clearing";
            szRemainderServices[2, 0] = "* Pruning";
            szRemainderServices[3, 0] = "* Power Washing";
            szRemainderServices[4, 0] = "* Gutter Cleaning";
            szRemainderServices[5, 0] = "* Weeding";
            szRemainderServices[6, 0] = "* Hauling";
            szRemainderServices[7, 0] = "* Driveway Sealing";
            szRemainderServices[8, 0] = "* Roundup Application";
            szRemainderServices[9, 0] = "* Mulching";
            //szRemainderServices[10, 0] = "* Brown Patch Application";
            //szRemainderServices[11, 0] = "* Insect Control";
            //szRemainderServices[12, 0] = "* Other";

            szRemainderServices[0, 1] = "True";
            szRemainderServices[1, 1] = "True";
            szRemainderServices[2, 1] = "True";
            szRemainderServices[3, 1] = "True";
            szRemainderServices[4, 1] = "True";
            szRemainderServices[5, 1] = "True";
            szRemainderServices[6, 1] = "True";
            szRemainderServices[7, 1] = "True";
            szRemainderServices[8, 1] = "True";
            szRemainderServices[9, 1] = "True";
            //szRemainderServices[10, 1] = "True";
            //szRemainderServices[11, 1] = "True";
            //szRemainderServices[12, 1] = "True";

            foreach (string str in szServices)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (str == szRemainderServices[i, 0])
                        szRemainderServices[i, 1] = "False";
                }
            }

            return szRemainderServices;
        }

        private string[] FindServiceCodes(string szServices)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            if (szServices.Length == 0) return null;

            try
            {

                string[] szCodes = szServices.Split(',');
                string str = "";

                int ncount = 0;
                foreach (string str1 in szCodes)
                {
                    str = str1.ToLower();
                    if (str.StartsWith("4st"))
                        szCodes[ncount] = "* 4-Step Lawn Treatment Program";
                    else if (str.StartsWith("a"))
                        szCodes[ncount] = "* Core Aeration";
                    else if (str.StartsWith("e"))
                        szCodes[ncount] = "* Edging";
                    else if (str.StartsWith("f"))
                        szCodes[ncount] = "* Fertilization";
                    else if (str.StartsWith("gc"))
                        szCodes[ncount] = "* General Cleanup";
                    else if (str.StartsWith("g"))
                        szCodes[ncount] = "* Gutter Cleaning";
                    else if (str.StartsWith("h"))
                        szCodes[ncount] = "* Hauling";
                    else if (str.StartsWith("lm"))
                        szCodes[ncount] = "* Liming";
                    else if (str.StartsWith("lv"))
                        szCodes[ncount] = "* Leaf Removal";
                    else if (str.StartsWith("m"))
                        szCodes[ncount] = "* Mulching";
                    else if (str.StartsWith("pr"))
                        szCodes[ncount] = "* Pruning";
                    else if (str.StartsWith("so"))
                        szCodes[ncount] = "* Soil or Compost Application";
                    else if (str.StartsWith("s"))
                        szCodes[ncount] = "* Seeding";
                    else if (str.StartsWith("tr"))
                        szCodes[ncount] = "* Tree Work";
                    else if (str.StartsWith("w"))
                        szCodes[ncount] = "* Weeding";
                    else if (str.StartsWith("br"))
                        szCodes[ncount] = "* Brush Clearing";
                    else if (str.StartsWith("p"))
                        szCodes[ncount] = "* Power Washing";
                    else if (str.StartsWith("ds"))
                        szCodes[ncount] = "* Driveway Sealing";
                    else if (str.StartsWith("d"))
                        szCodes[ncount] = "* Dethaching";
                    else if (str.StartsWith("r"))
                        szCodes[ncount] = "* Roundup Application";
                    else if (str.StartsWith("bro"))
                        szCodes[ncount] = "* Brown Patch Application";
                    else if (str.StartsWith("i"))
                        szCodes[ncount] = "* Insect Control";
                    else if (str.StartsWith("o"))
                        szCodes[ncount] = "* Other";
                    else
                    {
                        szCodes[ncount] = "";
                        if (str.Length > 0)
                            PrintToErrorOutput(szErrorName + " Code: " + str + " Not Found! ");
                            //PrintToOutput("Attn: " + str + " Code Not Found! ");
                    }
                    ncount++;
                }
                return szCodes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return null;
            }

        }

        private string[] FindFallServiceCodes(string szServices)
        {
            MainForm pParent = (MainForm)this.ParentForm;

            try
            {
                string[] szCodes = szServices.Split(',');
                string str = "";

                int ncount = 0;
                foreach (string str1 in szCodes)
                {
                    str = str1.ToLower();
                    if (str.StartsWith("4st"))
                        szCodes[ncount] = "* 4-Step Lawn Treatment Program";
                    else if (str.StartsWith("a"))
                        szCodes[ncount] = "* Core Aeration";
                    else if (str.StartsWith("e"))
                        szCodes[ncount] = "* Edging";
                    else if (str.StartsWith("f"))
                        szCodes[ncount] = "* Fertilization";
                    else if (str.StartsWith("gc"))
                        szCodes[ncount] = "* General Cleanup";
                    else if (str.StartsWith("g"))
                        //szCodes[ncount] = "* Gutter Cleaning";
                        szCodes[ncount] = "";
                    else if (str.StartsWith("h"))
                        szCodes[ncount] = "* Hauling";
                    else if (str.StartsWith("lm"))
                        szCodes[ncount] = "* Liming";
                    else if (str.StartsWith("lv"))
                        //szCodes[ncount] = "* Leaf Removal";
                        szCodes[ncount] = "";
                    else if (str.StartsWith("m"))
                        szCodes[ncount] = "* Mulching";
                    else if (str.StartsWith("pr"))
                        szCodes[ncount] = "* Pruning";
                    else if (str.StartsWith("so"))
                        szCodes[ncount] = "* Soil or Compost Application";
                    else if (str.StartsWith("s"))
                        szCodes[ncount] = "* Seeding";
                    else if (str.StartsWith("tr"))
                        szCodes[ncount] = "* Tree Work";
                    else if (str.StartsWith("w"))
                        szCodes[ncount] = "* Weeding";
                    else if (str.StartsWith("br"))
                        szCodes[ncount] = "* Brush Clearing";
                    else if (str.StartsWith("p"))
                        szCodes[ncount] = "* Power Washing";
                    else if (str.StartsWith("ds"))
                        szCodes[ncount] = "* Driveway Sealing";
                    else if (str.StartsWith("d"))
                        szCodes[ncount] = "* Dethaching";
                    else if (str.StartsWith("r"))
                        szCodes[ncount] = "* Roundup Application";
                    else if (str.StartsWith("bro"))
                        szCodes[ncount] = "* Brown Patch Application";
                    else if (str.StartsWith("i"))
                        szCodes[ncount] = "* Insect Control";
                    else if (str.StartsWith("o"))
                        szCodes[ncount] = "* Other";
                    else
                    {
                        szCodes[ncount] = "";
                        if (str.Length > 0) PrintToErrorOutput(szErrorName + " Code: " + str + " Not Found! ");
                            //PrintToOutput("Attn: " + str + " Code Not Found! b");
                    }
                    ncount++;
                }
                return szCodes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return null;
            }

        }

        private string[] FindFallServiceCodes2(string szServices)
        {
            MainForm pParent = (MainForm)this.ParentForm;
            try
            {
                string[] szCodes = szServices.Split(',');
                string str = "";

                int ncount = 0;
                foreach (string str1 in szCodes)
                {
                    str = str1.ToLower();
                    if (str.StartsWith("4st"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("a"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("e"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("f"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("gc"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("g"))
                        szCodes[ncount] = "* Gutter Cleaning";
                    else if (str.StartsWith("h"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("lm"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("lv"))
                        szCodes[ncount] = "* Leaf Removal";
                    else if (str.StartsWith("m"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("pr"))
                        szCodes[ncount] = "* Trimming/Pruning";
                    else if (str.StartsWith("so"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("s"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("tr"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("w"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("br"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("p"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("ds"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("d"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("r"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("bro"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("i"))
                        szCodes[ncount] = "";
                    else if (str.StartsWith("o"))
                        szCodes[ncount] = "";
                    else
                    {
                        szCodes[ncount] = "";
                        if (str.Length > 0) PrintToErrorOutput(szErrorName + " Code: " + str + " Not Found! ");
                            //PrintToOutput("Attn: " + str + " Code Not Found! c");
                    }
                    ncount++;
                }
                return szCodes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                return null;
            }

        }
        
        //Method for printing to the print UI log
        public void PrintToOutput(string txt)
        {
            txt = txt + "\r\n";
            OutputTxtBox.AppendText(txt);
        }

        public void PrintToErrorOutput(string txt)
        {
            txt = txt + "\r\n";
            ErrorTextBox.AppendText(txt);
        }

        #endregion
        
    }   
}
