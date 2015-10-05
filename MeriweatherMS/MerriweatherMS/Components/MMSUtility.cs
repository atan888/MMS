using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Deployment.Application;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.OleDb; //This namespace is mainly used for dealing with 
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Reflection;

namespace System.Windows.Forms.MMS
{
    class MMSUtility
    {
        static private PrinterSettings _myPrinterSettings = null;
        static private PageSettings _myPageSettings = new PageSettings();
        static private UserPreferences _UserPref = new UserPreferences();
        static public string QBAppName = "MMS Application";
        static public string QBAppID = "App";

        static public PageSettings myPageSettings
        {
            get { return _myPageSettings; }
            set
            {
                _myPageSettings = value;
            }
        }

        static public PrinterSettings myPrinterSettings
        {
            get { return _myPrinterSettings; }
            set
            {
                _myPrinterSettings = value;
            }
        }

        static public UserPreferences UserPref
        {
            get { return _UserPref; }
            set
            {
                _UserPref = value;
            }
        }
      
        static public void PlaySound()
        {
            if (UserPref.Sound)
            {
                //SystemSounds.Beep.Play();
                SystemSounds.Asterisk.Play();
            }
        }

        static public void PlayAcceptSound()
        {
            if (UserPref.Sound) 
            {
                //SoundPlayer simpleSound = new SoundPlayer(@"c:\windows\media\chimes.wav");
                SoundPlayer simpleSound = new SoundPlayer(@"c:\windows\media\Windows Information Bar.wav"); 
                //SoundPlayer simpleSound = new SoundPlayer(@"c:\windows\media\Windows XP Information Bar.wav");
                simpleSound.Play();
            }   
        }

        static public string CheckAppVersion()
        {
            string strVersion;

            // Get version, only available if deployed!
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment appDeployment = ApplicationDeployment.CurrentDeployment;
                Version version = appDeployment.CurrentVersion;
                strVersion = "Ver: " + version.ToString();
            }
            else
            {
                //strVersion = "Version : [not deployed via ClickOnce]";
                //strVersion = "Ver: [Development]";

                string ver = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location)
                   .ToString("yyyy.MM.dd.HHmm");
                strVersion = "Ver: " + ver;

                //Version version = Assembly.GetExecutingAssembly().GetName().Version;
                //strVersion = "Ver: " + version.ToString();                                
            }
            return strVersion;
        }

        public static string CheckUpdate()
        {
            string szUpdate;

             UpdateCheckInfo info = null;
            // If not deployed via network, it's either installed from cd or running on your own development pc.
             if (!ApplicationDeployment.IsNetworkDeployed)
             {
                 szUpdate = "OffLine";
                 return szUpdate;
             }
             else
             {
                 ApplicationDeployment updateCheck = ApplicationDeployment.CurrentDeployment;

                 try
                 {
                     // Get detailed information.
                     info = updateCheck.CheckForDetailedUpdate();
                     szUpdate = "Update Available";

                 }             
                 catch
                 {
                     szUpdate = "OffLine";
                     return szUpdate;
                 }

                 // Check if update is actually available.
                 if (info.UpdateAvailable)
                 {

                     // Check if update is required. If not, ask user if they actually want to install.
                     if (!info.IsUpdateRequired)
                     {
                         szUpdate = "Update Available";
                         return szUpdate;
                     }
                 }
                 else
                 {
                     szUpdate = "No Updates";
                     return szUpdate;

                 }
                 szUpdate = "No Updates";
                 return szUpdate;
             }
        }


        public static void GetUpdate()
        {
            UpdateCheckInfo info = null;

            // If not deployed via network, it's either installed from cd or running on your own development pc.
            if (!ApplicationDeployment.IsNetworkDeployed)
            {
                MessageBox.Show("This application was not deployed using ClickOnce", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ApplicationDeployment updateCheck = ApplicationDeployment.CurrentDeployment;

                try
                {
                    // Get detailed information.
                    info = updateCheck.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    MessageBox.Show("The new version of the application cannot be downloaded at this time. \n\nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    MessageBox.Show("Cannot check for a new version of the application. The deployment maybe corrupt. Please try again later. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    MessageBox.Show("This application cannot be updated. It is likely not a Deployed application. Error: " + ioe.Message);
                    return;
                }

                // Check if update is actually available.
                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    // Check if update is required. If not, ask user if they actually want to install.
                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dialogResult = MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dialogResult))
                        {
                            doUpdate = false;
                        }
                    }

                    // Perform the actual update.
                    if (doUpdate)
                    {
                        try
                        {
                            updateCheck.Update();
                            MessageBox.Show("The application has been upgraded, and need to be closed.  Please re-launch application from start menu.");
                            //Application.Restart();
                            Application.Exit();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            MessageBox.Show("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. Error: " + dde);
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No update is currently available", "Check for updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        // Tests whether the input string is a whole number - ie. 0, 1, 2, ...
        public static bool IsWholeNumber(string txt)
        {
            if (txt == null)
                txt = "";

            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(txt);
        }


        // Will return 'txt' as is if it's a number; otherwise will return a null string
        public static string NumericOnly(string txt)
        {
            if (IsWholeNumber(txt))
                return txt;
            else
                return "";
        }

        //call LogFile method and pass argument as Exception message, event name, control name, error line number, current form name
        //  LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
        public static void LogFile(string sExceptionName, string sEventName, string sControlName, int nErrorLineNo, string sFormName)
        {

            LogFile2(sExceptionName, sEventName, sControlName, nErrorLineNo, sFormName);
            /*

            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }

            else
            {
                log = File.AppendText("logfile.txt");
            }

            // Write to the file:
            log.WriteLine("Data Time:" + DateTime.Now);
            log.WriteLine("Exception Name:" + sExceptionName);
            log.WriteLine("Event Name:" + sEventName);
            log.WriteLine("Control Name:" + sControlName);
            log.WriteLine("Error Line No.:" + nErrorLineNo);
            log.WriteLine("Form Name:" + sFormName);


            // Close the stream:
            log.Close();
            */
        }

        public static void LogFile2(string sExceptionName, string sEventName, string sControlName, int nErrorLineNo, string sFormName)
        {
            //inserting data into the Sql Server
            SqlConnection conn = new global::System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = global::System.Windows.Forms.MMS.Properties.Settings.Default.MMSConnectionString1;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert into ExceptionLog(LogTime,ExceptionName, EventName, ControlName, ErrorLine, FormName) values(@logtime,@exception,@event,@control,@line,@form); SELECT SCOPE_IDENTITY()";
            cmd.Parameters.Add("@logtime", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@exception", SqlDbType.VarChar).Value = sExceptionName;
            cmd.Parameters.Add("@event", SqlDbType.VarChar).Value = sEventName;
            cmd.Parameters.Add("@control", SqlDbType.VarChar).Value = sControlName;
            cmd.Parameters.Add("@line", SqlDbType.VarChar).Value = nErrorLineNo.ToString();
            cmd.Parameters.Add("@form", SqlDbType.VarChar).Value = sFormName;

            cmd.CommandType = CommandType.Text;
            conn.Open();            
            string insertedID = cmd.ExecuteScalar().ToString(); ;
            conn.Close();
            
        }


    }

    public static class ExceptionHelper
    {
        public static int LineNumber(this Exception e)
        {
            int linenum = 0;

            try
            {
                linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));
            }
            catch
            {
                //Stack trace is not available!
            }

            return linenum;
        }

    }
}
