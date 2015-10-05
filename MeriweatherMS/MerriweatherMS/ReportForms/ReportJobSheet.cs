using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms.MMS
{
    public partial class PrintSheetsDialog : Form
    {
        string m_szRoute = "Main";

        public PrintSheetsDialog(string szRoute)
        {
            InitializeComponent();

            m_szRoute = szRoute;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "MMSDataSet_CustPropertyJobs";
            reportDataSource1.Value = this.custPropertyJobsBindingSource;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "System.Windows.Forms.MMS.Reports.ContractorJobReport.rdlc";

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            ReportListBox.SelectedIndex = 0;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            this.Close();
        }

        private void PrintSheetsDialog_Load(object sender, EventArgs e)
        {
            try
            {

                // TODO: This line of code loads data into the 'mMSDataSet.CustPropertyJobs' table. You can move, or remove it, as needed.
                //this.custPropertyJobsTableAdapter.Fill(this.mMSDataSet.CustPropertyJobs);
                //this.custPropertyJobsTableAdapter.FillBySelectPrint(this.mMSDataSet.CustPropertyJobs, m_szRoute);
                if (m_szRoute == "Main")
                    this.custPropertyJobsTableAdapter.FillByMainRouteOrder(this.mMSDataSet.CustPropertyJobs);
                else
                    this.custPropertyJobsTableAdapter.FillByFourStepRotueOrder(this.mMSDataSet.CustPropertyJobs);
                this.routeListTableAdapter.Fill(this.mMSDataSet.RouteList);

                // TODO: This line of code loads data into the 'mMSDataSet.CustPropertyJobs' table. You can move, or remove it, as needed.
                this.reportViewer1.RefreshReport();
                m_szRoute = FilterComboBox.Text.ToString();
            }
            catch
            {

            }
        }

        private void ReportListBox_SelectedValueChanged(object sender, EventArgs e)
        {

            this.reportViewer1.Reset();

            if (ReportListBox.SelectedIndex == 0)  // instruction sheet
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "MMSDataSet_CustPropertyJobs";
                reportDataSource1.Value = this.custPropertyJobsBindingSource;

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "System.Windows.Forms.MMS.Reports.CustomerJobReport4Step.rdlc";
                
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                //this.custPropertyJobsTableAdapter.FillBySelectPrint(this.mMSDataSet.CustPropertyJobs, m_szRoute);
                if (m_szRoute == "Main")
                    this.custPropertyJobsTableAdapter.FillByMainRouteOrder(this.mMSDataSet.CustPropertyJobs);
                else
                    this.custPropertyJobsTableAdapter.FillByFourStepRotueOrder(this.mMSDataSet.CustPropertyJobs);

            }
            else if (ReportListBox.SelectedIndex == 1) //Revenue Sheeet
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "MMSDataSet_CustPropertyJobs";
                reportDataSource1.Value = this.custPropertyJobsBindingSource;

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "System.Windows.Forms.MMS.Reports.RevenueJobReport.rdlc";

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                //this.custPropertyJobsTableAdapter.FillBySelectPrint(this.mMSDataSet.CustPropertyJobs, m_szRoute);
                if (m_szRoute == "Main")
                    this.custPropertyJobsTableAdapter.FillByMainRouteOrder(this.mMSDataSet.CustPropertyJobs);
                else
                    this.custPropertyJobsTableAdapter.FillByFourStepRotueOrder(this.mMSDataSet.CustPropertyJobs);
            }
            else if (ReportListBox.SelectedIndex == 2) //Contractor pay Sheeet
            {
                Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
                reportDataSource1.Name = "MMSDataSet_CustPropertyJobs";
                reportDataSource1.Value = this.custPropertyJobsBindingSource;

                this.reportViewer1.LocalReport.ReportEmbeddedResource = "System.Windows.Forms.MMS.Reports.ContractorJobReport.rdlc";

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                //this.custPropertyJobsTableAdapter.FillBySelectPrint(this.mMSDataSet.CustPropertyJobs, m_szRoute);
                if (m_szRoute == "Main")
                    this.custPropertyJobsTableAdapter.FillByMainRouteOrder(this.mMSDataSet.CustPropertyJobs);
                else
                    this.custPropertyJobsTableAdapter.FillByFourStepRotueOrder(this.mMSDataSet.CustPropertyJobs);
            }

            this.reportViewer1.RefreshReport();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_szRoute = FilterComboBox.Text.ToString();
            ReportListBox_SelectedValueChanged(null, null);
        }       
        
    }
}
