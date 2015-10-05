using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class PreferencesDialog : Form
    {

        public PreferencesDialog()
        {
            InitializeComponent();
        }

        private void customerTypeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTypeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);

        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.mMSDataSet.UserProfile);
            // TODO: This line of code loads data into the 'mMSDataSet.RouteList' table. You can move, or remove it, as needed.
            this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
            // TODO: This line of code loads data into the 'mMSDataSet.JobStatusList' table. You can move, or remove it, as needed.
            this.jobStatusListTableAdapter.Fill(this.mMSDataSet.JobStatusList);
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerTypeList' table. You can move, or remove it, as needed.
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerTypeList' table. You can move, or remove it, as needed.
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
            generalSaveButton.Enabled = false;
        }

        #region CustomerType
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string szID = customerTypeListListBox.SelectedValue.ToString();
                if (szID != "")
                {
                    customerTypeListTableAdapter.DeleteCustomerType(Convert.ToInt32(szID));
                    this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (addTextBox.Text != "")
            {
                string szMessage = "Do you want to add: '" + addTextBox.Text + "'?";
                if (MessageBox.Show(szMessage, "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    customerTypeListTableAdapter.InsertCustomerType(addTextBox.Text);
                    this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }
        #endregion

        #region Jobstatus
        private void addJobStatusButton_Click(object sender, EventArgs e)
        {
            if (jobStatusTextBox.Text != "")
            {
                string szMessage = "Do you want to add: '" + jobStatusTextBox.Text + "'?";
                if (MessageBox.Show(szMessage, "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    jobStatusListTableAdapter.InsertJobStatus(jobStatusTextBox.Text);                   
                    this.jobStatusListTableAdapter.Fill(this.mMSDataSet.JobStatusList);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }

        private void deleteJobStatusButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                string szID = jobStatusListListBox.SelectedValue.ToString();
                if (szID != "")
                {
                    jobStatusListTableAdapter.DeleteJobStatus(Convert.ToInt32(szID));
                    this.jobStatusListTableAdapter.Fill(this.mMSDataSet.JobStatusList);
                    MMSUtility.PlayAcceptSound();
                }
            }

        }
        #endregion

        #region Route
        private void addRouteButton_Click(object sender, EventArgs e)
        {
            if (routeTextBox.Text != "")
            {
                string szMessage = "Do you want to add: '" + routeTextBox.Text + "'?";
                if (MessageBox.Show(szMessage, "Attention", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {                    
                    routeListTableAdapter.InsertRoute(routeTextBox.Text);
                    this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
                    MMSUtility.PlayAcceptSound();
                }
            }
        }

        private void deleteRouteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {

                string szID = routeListListBox.SelectedValue.ToString();
                if (szID != "")
                {
                    routeListTableAdapter.DeleteRoute(Convert.ToInt32(szID));
                    this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);
                    MMSUtility.PlayAcceptSound();
                }
            }

        }
        #endregion

        #region General
        //browse default path location
        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            dlg.SelectedPath = MMSUtility.UserPref.TemplatePath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                templatePathTextBox.Text = dlg.SelectedPath;
            }
        }

        private void browsButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            dlg.SelectedPath = MMSUtility.UserPref.ImportPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                importPathTextBox.Text = dlg.SelectedPath;
            }  
        }

        private void generalSaveButton_Click(object sender, EventArgs e)
        {
            bool bEnableSound = enableSoundCheckBox.Checked;

            userProfileTableAdapter.UpdateUserProfile(templatePathTextBox.Text, bEnableSound, importPathTextBox.Text, 
                QBInvoiceDate.Value.ToShortDateString(), EnableQBCheckBox.Checked, QBAccountTextBox.Text, reportURLTextBox.Text);

            MMSUtility.UserPref.Sound = bEnableSound;
            MMSUtility.UserPref.TemplatePath = templatePathTextBox.Text;
            MMSUtility.UserPref.ImportPath = importPathTextBox.Text;
            MMSUtility.UserPref.ReportURL = reportURLTextBox.Text;
            MMSUtility.UserPref.QBIntegration = enableSoundCheckBox.Checked;
            MMSUtility.PlayAcceptSound();
            generalSaveButton.Enabled = false;
        }

        private void templatePathTextBox_TextChanged(object sender, EventArgs e)
        {
            generalSaveButton.Enabled = true;
        }
        #endregion

        private void passwordSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;            
            proc.StartInfo.FileName = reportURLTextBox.Text;
            proc.Start();
        }

    }
}
