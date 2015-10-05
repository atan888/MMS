using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms.MMS
{
    public class UserPreferences
    {
        private bool bSound = false;
        private string szTemplatePath = "";
        private string szImportPath = "";
        private string szPassword = "";
        private DateTime szQBDate = System.DateTime.Now;
        private bool bQBIntegration;
        private string szQBAccount = "";
        private string szReportURL = "";

        public bool Sound   // the sound property
        {
           get { return bSound; }
           set { bSound = value; }
        }

        public string TemplatePath   // the template path property
        {
            get { return szTemplatePath; }
            set { szTemplatePath = value; }
        }
        public string ImportPath   // the import path property (letters)
        {
            get { return szImportPath; }
            set { szImportPath = value; }
        }

        public string Password   // the password property
        {
            get { return szPassword; }
            set { szPassword = value; }
        }
        public DateTime QBDate   // the password property
        {
            get { return szQBDate; }
            set { szQBDate = value; }
        }
        public bool QBIntegration   // the password property
        {
            get { return bQBIntegration; }
            set { bQBIntegration = value; }
        }
        public string QBAccount   // the password property
        {
            get { return szQBAccount; }
            set { szQBAccount = value; }
        }
        public string ReportURL   // the password property
        {
            get { return szReportURL; }
            set { szReportURL = value; }
        }
    }
}
