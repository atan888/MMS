using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            SplashScreen.ShowSplashScreen();
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());

            SingleApplication.Run(new MainForm());
            //Test code for console application
            if(SingleApplication.Run() == false)
            {                
            	return;
            }            
		}
	}
}