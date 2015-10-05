using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.MMS.Components;
using System.Collections;
using Microsoft.Win32;
using System.Windows.Forms.MMS.Forms;

namespace System.Windows.Forms.MMS
{
	public partial class MainForm : Form
	{

        //preferences
        private BaseView m_activeView = null;
        private PersistWindowState m_windowState;
        private int nTimerCount = 0;
        private int nTimerMax = 0;

		public MainForm()
		{
            m_windowState = new PersistWindowState();
            m_windowState.Parent = this;
            m_windowState.RegistryPath = @"Software\Sercio\MeriweatherMS"; // set registry path in HKEY_CURRENT_USER
            m_windowState.LoadStateEvent += new PersistWindowState.WindowStateDelegate(LoadState);
            m_windowState.SaveStateEvent += new PersistWindowState.WindowStateDelegate(SaveState);

            //EventManager.RegisterClassHandler(typeof(MainForm),
            //                          Mouse.MouseDownEvent,
             //                         new MouseButtonEventHandler(OnGlobaMouseDown)); 

			InitializeComponent();
            //SplashScreen.ShowSplashScreen();
            SplashScreen.SetReferencePoint();
            SplashScreen.SetStatus("Initializing System");
		    vendorButton.Visible = false;

            //GetUserPreference();

            int nCount = 2;
            foreach (BaseView control in this.contentPanel.Controls)
            {
                // Hide all content
                //control.UserPref = m_UserPref;
                SplashScreen.SetStatus("Loading View " + nCount.ToString());
                System.Threading.Thread.Sleep(100);
                nCount++;
            }

            //get app version
            string strver = MMSUtility.CheckAppVersion();
            this.Text = "Meriweather Management System - " + strver;
            //mainProgressBar.Hide();          
            mainProgressBar.Visible = false;
            statusLabelStrip.Text = "";
            GetUserPreference();
            MMSUtility.myPageSettings.Margins.Top = 30;
		}


		#region Private Implementation		
		private void HideContent()
		{
			foreach (Control control in this.contentPanel.Controls)
			{
				// Hide all content
				control.Visible = false;
			}
            EnableEditButtons(false);

		}

        private int m_data = 34;

        private void LoadState(object sender, RegistryKey key)
        {
            // get additional state information from registry
            m_data = (int)key.GetValue("m_data", m_data);
        }

        private void SaveState(object sender, RegistryKey key)
        {
            // save additional state information to registry
            key.SetValue("m_data", m_data);
        }

        private void GetUserPreference()
        {            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            MMSUtility.UserPref.TemplatePath = path + "\\Meriweather Templates";
            MMSUtility.UserPref.ImportPath = path;
            MMSUtility.UserPref.Sound = true;

            System.Windows.Forms.MMS.Data.MMSDataSet.UserProfileDataTable myDataTable = new System.Windows.Forms.MMS.Data.MMSDataSet.UserProfileDataTable();
            userProfileTableAdapter1.Fill(myDataTable);                      
            DataRow dRow = myDataTable.Rows[0];
            if (dRow != null)
            {
                path = dRow["TemplatePath"].ToString();                
                if (path != "")
                {
                    MMSUtility.UserPref.TemplatePath = path;
                }
                
                path = dRow["ImportPath"].ToString();
                if (path != "")
                {
                    MMSUtility.UserPref.ImportPath = path;
                }

                string szEnableSound = dRow["EnableSound"].ToString();
                MMSUtility.UserPref.Sound = Convert.ToBoolean(szEnableSound);
                MMSUtility.UserPref.Password = dRow["Password"].ToString();
               

                //Andy - commented for remote 
                string szQBIntegration = dRow["QBIntegration"].ToString();
                if (szQBIntegration == "True")
                    MMSUtility.UserPref.QBIntegration = true;
                else
                    MMSUtility.UserPref.QBIntegration = false;


                MMSUtility.UserPref.QBAccount = dRow["QBAccount"].ToString();
                MMSUtility.UserPref.ReportURL = dRow["ReportURL"].ToString();

            }
        }

        private void SaveUserPreference()
        {
            bool bEnableSound = MMSUtility.UserPref.Sound;
            string szTemplatePath = MMSUtility.UserPref.TemplatePath;
            string szImportPath = MMSUtility.UserPref.ImportPath;
            string szPassword = MMSUtility.UserPref.Password;
            //userProfileTableAdapter1.UpdateUserProfile(szTemplatePath, bEnableSound, szPassword);

        }

		#endregion

        #region Event Handlers   
		private void MainForm_Load(object sender, EventArgs e)
		{
            HideContent();
            this.loginView1.Viewable = true;
            m_activeView = this.loginView1;
            customMenuStrip1.Enabled = false;
            customToolStrip1.Enabled = false;

            string szUpdate = MMSUtility.CheckUpdate();
            statusLabelStrip.Text = szUpdate;
            checkUpdateButton.Enabled = false;

            if (!MMSUtility.UserPref.QBIntegration)
            {
                refreshQBConnectionToolStripMenuItem.Enabled = false;
            }
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m_activeView.RefreshView();
        }
        public void RefreshView()
        {
            refreshDataToolStripMenuItem_Click(null, null);
        }
        public void RefreshServiceView()
        {
            this.serviceView1.RefreshView();
        }
        public void CheckServiceView()
        {
            this.serviceView1.CheckView();
        }

        public void RefreshServiceFourStepView()
        {
            this.servicefourstepView1.RefreshView();
        }
        public void RefreshScheduleView()
        {
            this.scheduleView1.RefreshView();
        }
        public void RefreshRouteView()
        {
            this.routeView1.RefreshView();
        }
        private void login_Successfull(object sender, EventArgs e)
        {
            //start here - show the first screen
            HideContent();
            //this.scheduleView1.Viewable = true;

            //this.customerView1.Viewable = true;
            //customerButton.ForeColor = System.Drawing.Color.Gold;
            this.serviceView1.Viewable = true;
            m_activeView = this.serviceView1;
            serviceButton.ForeColor = System.Drawing.Color.Gold;

            //enable menu and toolbar
            customMenuStrip1.Enabled = true;
            customToolStrip1.Enabled = true;
            checkUpdateButton.Enabled = true;           
        }
        private void checkUpdateButton_Click(object sender, EventArgs e)
        {
             MMSUtility.GetUpdate();
        }
        private void scheduleButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.scheduleView1.Viewable = true;
            m_activeView = this.scheduleView1;
            disableToolbarColor();
            //scheduleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            scheduleButton.ForeColor = System.Drawing.Color.Gold;

            printSheetToolStripMenuItem.Enabled = true;
        }
        private void VendorButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.vendorView1.Viewable = true;
            m_activeView = this.vendorView1;
            disableToolbarColor();
            //vendorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            vendorButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.reportView1.Viewable = true;
            m_activeView = this.reportView1;
            disableToolbarColor();
            //reportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            reportButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;
        }
        private void routeButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.routeView1.Viewable = true;
            m_activeView = this.routeView1;
            disableToolbarColor();
            //routeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            routeButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;
        }
        private void serviceButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.serviceView1.Viewable = true;
            m_activeView = this.serviceView1;
            disableToolbarColor();
            //serviceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            serviceButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;
        }
        private void FourStepServicesButtonClick(object sender, EventArgs e)
        {
            HideContent();
            this.servicefourstepView1.Viewable = true;
            m_activeView = this.servicefourstepView1;
            disableToolbarColor();
            servicefourstepButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;
        }

        private void letterButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.letterView1.Viewable = true;
            m_activeView = this.letterView1;
            disableToolbarColor();
            //materialButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            letterButton.ForeColor = System.Drawing.Color.Gold;
            EnableEditButtons(true);
            printSheetToolStripMenuItem.Enabled = false;

        }
        private void customerButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.customerView1.Viewable = true;
            m_activeView = this.customerView1;
            disableToolbarColor();
            //customerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            customerButton.ForeColor = System.Drawing.Color.Gold;
            if (this.customerView1.EditMode != 0)
            {
                
            }
            printSheetToolStripMenuItem.Enabled = false;
        }
        private void crewButton_Click(object sender, EventArgs e)
        {
            HideContent();
            //this.vendorView1.Viewable = true;
        }
        private void employeeButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.employeeView1.Viewable = true;
            m_activeView = this.employeeView1;
            disableToolbarColor();
            //employeeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            employeeButton.ForeColor = System.Drawing.Color.Gold;
            printSheetToolStripMenuItem.Enabled = false;

        }
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox dlg = new AboutBox();
            dlg.ShowDialog();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.ShowDialog();
            refreshQBConnectionToolStripMenuItem.Enabled = MMSUtility.UserPref.QBIntegration;
        }
      
        private void disableToolbarColor()
        {
            //serviceButton.BackColor = System.Drawing.SystemColors.Control;
            //scheduleButton.BackColor = System.Drawing.SystemColors.Control;
            //routeButton.BackColor = System.Drawing.SystemColors.Control;
            //customerButton.BackColor = System.Drawing.SystemColors.Control;
            //scheduleButton.BackColor = System.Drawing.SystemColors.Control;
            //vendorButton.BackColor = System.Drawing.SystemColors.Control;
            //materialButton.BackColor = System.Drawing.SystemColors.Control;
            //reportButton.BackColor = System.Drawing.SystemColors.Control;
            //employeeButton.BackColor = System.Drawing.SystemColors.Control;

            serviceButton.ForeColor = System.Drawing.Color.White;
            servicefourstepButton.ForeColor = System.Drawing.Color.White;
            scheduleButton.ForeColor = System.Drawing.Color.White;
            routeButton.ForeColor = System.Drawing.Color.White;
            customerButton.ForeColor = System.Drawing.Color.White;
            scheduleButton.ForeColor = System.Drawing.Color.White;
            vendorButton.ForeColor = System.Drawing.Color.White;
            letterButton.ForeColor = System.Drawing.Color.White;
            reportButton.ForeColor = System.Drawing.Color.White;
            employeeButton.ForeColor = System.Drawing.Color.White;
        }

        public void enableMainButtons(bool bEnable)
        {
            //customMenuStrip1.Enabled = bEnable;
            customToolStrip1.Enabled = bEnable;
            checkUpdateButton.Enabled = bEnable;
            exportNewsLetterCVSToolStripMenuItem.Enabled = bEnable;
            refreshDataToolStripMenuItem.Enabled = bEnable;
            pageSetupToolStripMenuItem.Enabled = bEnable;
            printPreviewToolStripMenuItem.Enabled = bEnable;
            printToolStripMenuItem.Enabled = bEnable;
            lockButton.Enabled = bEnable;
            preferencesToolStripMenuItem.Enabled = bEnable;
            reminderCSVToolStripMenuItem.Enabled = bEnable;
            contractorBonusToolStripMenuItem.Enabled = bEnable;
            //exitToolStripMenuItem.Enabled = bEnable;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SplashScreen.SetStatus("Initializing Complete...");
            System.Threading.Thread.Sleep(500);
            SplashScreen.CloseForm();
            this.Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUserPreference();

            if (MessageBox.Show("Do you want to Exit?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        public void EnableEditButtons(bool bEnable)
        {
            redoToolStripMenuItem.Enabled = bEnable;
            undoToolStripMenuItem.Enabled = bEnable;
            cutToolStripMenuItem.Enabled = bEnable;
            copyToolStripMenuItem.Enabled = bEnable;
            pasteToolStripMenuItem.Enabled = bEnable;
            selectAllToolStripMenuItem.Enabled = bEnable;
        }

        #region ProgressBar
        public void ProgressBarInit(int min, int max, int increment)
        {
             //mainProgressBar.Show();
             mainProgressBar.Visible = true;
             mainProgressBar.Value = 0;
             mainProgressBar.Minimum = min;
             mainProgressBar.Maximum = max;
             mainProgressBar.Step = increment;
        }
        public void ProgressBarUpdate()
        {
            mainProgressBar.PerformStep();

            if (mainProgressBar.Value >= (mainProgressBar.Maximum -1))
            {
                //mainProgressBar.Hide();
                mainProgressBar.Visible = false;
                mainProgressBar.Value = 0;
            }        
        }

        public void ProgressBarEnd()
        {
            //mainProgressBar.Hide();
            mainProgressBar.Visible = false;
            mainProgressBar.Value = 0;
        }

        public void SetStatusLabel(string szStatus)
        {
            //statusLabel.Text = szStatus;
            //statusLabelStrip.Text = szStatus;
            szStatus = "Status: " + szStatus;
            toolStripLabel2.Text = szStatus;
        }

        #endregion

        #region Menu Handlers
        private void lockButton_Click(object sender, EventArgs e)
        {
            HideContent();
            this.loginView1.Viewable = true;
            this.loginView1.Reset();
            customMenuStrip1.Enabled = false;
            customToolStrip1.Enabled = false;
            checkUpdateButton.Enabled = false;
            disableToolbarColor();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.PageSetup();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.Print();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.PrintPreview();
        }        

        private void launchManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://thetans.homeserver.com/mms/Meriweather%20System.mht";
            System.Diagnostics.Process.Start(url);
        }

        private void quickBooksButton_Click(object sender, EventArgs e)
        {           
            //Process p = null;
            //try
            //{
            //    //string targetDir;
            //    //targetDir = string.Format(@"C:\Temp\CallBatchFile\BatchFile");
            //    p = new Process();
            //    //p.StartInfo.WorkingDirectory = targetDir;
            //    //p.StartInfo.Arguments = string.Format("C-Sharp Console application");
            //    p.StartInfo.FileName = "notepad";
            //    //p.StartInfo.CreateNoWindow = false;
            //    p.Start();
            //    p.WaitForExit();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception Occurred :{0},{1}",
            //              ex.Message, ex.StackTrace.ToString());
            //}
        }

        private void calculatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = null;
            try
            {
                p = new Process();
                p.StartInfo.FileName = "calc";
                //p.StartInfo.CreateNoWindow = false;               
                p.Start();
                p.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}",
                         ex.Message, ex.StackTrace.ToString());
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("Redo");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("Undo");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("Cut");

        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("Copy");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("Paste");

        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.EditFunction("SelectAll");
        }
        private void printSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_activeView.PrintSheets();
        }


        #endregion

        private void exportNewsLetterCVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportNewLetterCVS dlg = new ExportNewLetterCVS();
            dlg.ShowDialog();
        }
       
        private void reminderCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportReminderCSV dlg = new ExportReminderCSV();
            dlg.ShowDialog();
        }

        private void testDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestForm dlg = new TestForm();
            dlg.ShowDialog();
        }

        public void SetStatusLabelTimer(int nSec, string szLabel)
        {
            nTimerCount = 0;
            nTimerMax = nSec;
            StatusLabelTimer.Start();
            SetStatusLabel(szLabel);
        }
        private void StatusLabelTimer_Tick(object sender, EventArgs e)
        {
            nTimerCount++;
            if (nTimerCount >= nTimerMax)
            {
                SetStatusLabel("");
                StatusLabelTimer.Stop();               
            }
        }

        private void refreshQBConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MMSUtility.UserPref.QBIntegration)
            {
                if (!this.scheduleView1.GetQBItems())
                {
                    MMSUtility.UserPref.QBIntegration = false;
                }
            }
        }

        private void contractorBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BonusDialog dlg = new BonusDialog();
            dlg.ShowDialog();
        }

        private void resetFourStepToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}