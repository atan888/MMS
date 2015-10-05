using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.MMS.Views;
using System.Threading; 
using System.Data.OleDb; //This namespace is mainly used for dealing with 

namespace System.Windows.Forms.MMS
{
    public partial class PrintLetterDialog : Form
    {
        // local member variable to hold main form        
        System.Data.Odbc.OdbcDataAdapter obj_oledb_da;
        string strCSVFile = "";
        string strFormat = "CSVDelimited";
        private int nMaxCount = 0;

        #region Initialization
        public PrintLetterDialog()
        {
            InitializeComponent();
            Initialize();
        }
        
        public void Initialize()
        {
            if (cmbFormats.SelectedIndex < 0) 
                cmbFormats.SelectedIndex = 0;
            // AllCountLabel.Text = "0";
            txtCSVFolderPath.Text = MMSUtility.UserPref.ImportPath;            

        }
        private void PrintLetterDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerTypeList' table. You can move, or remove it, as needed.
            this.customerTypeListTableAdapter.Fill(this.mMSDataSet.CustomerTypeList);
        }
        #endregion

        #region Public Interface
      
        public int MaxCount
        {
            get { return nMaxCount; }         
        }
        
        #endregion

        #region Event Handler
        private void customerTypeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTypeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

        }
        
        private void btnOpenFldrBwsr_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdCSVFolder.ShowDialog() == DialogResult.OK)
                {
                    txtCSVFolderPath.Text = fbdCSVFolder.SelectedPath.Trim();
                }
            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), "PrintLetterDialog");
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void btnOpenFileDlg_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogCSVFilePath.InitialDirectory = txtCSVFolderPath.Text.Trim();
                if (openFileDialogCSVFilePath.ShowDialog() == DialogResult.OK)
                {
                    txtCSVFilePath.Text = openFileDialogCSVFilePath.FileName.Trim();
                }

            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), "PrintLetterDialog");
                MessageBox.Show(ex.Message);
            }
            finally
            { }
        }

        private void cmbFormats_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                if (cmbFormats.SelectedIndex == 2)
                {
                    txtDelimiter.Enabled = true;
                    txtDelimiter.BackColor = Color.FromName("Info");
                }
                else
                {
                    txtDelimiter.Enabled = false;
                    txtDelimiter.BackColor = Color.FromName("InactiveBorder");
                }
            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), "PrintLetterDialog");
                MessageBox.Show(ex.Message);
            }
            finally
            { }
        }
        #endregion

        #region Function For Importing Data From CSV File

        public DataSet ConnectCSV(string filetable, bool bFill)
        {
            DataSet ds = new DataSet();
            try
            {
                // You can get connected to driver either by using DSN or connection string

                // Create a connection string as below, if you want to use DSN less connection. The DBQ attribute sets the path of directory which contains CSV files
                string strConnString = "Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + txtCSVFolderPath.Text.Trim() + ";Extensions=asc,csv,tab,txt;Persist Security Info=False";
                string sql_select;
                System.Data.Odbc.OdbcConnection conn;

                //Create connection to CSV file


                conn = new System.Data.Odbc.OdbcConnection(strConnString.Trim());

                // For creating a connection using DSN, use following line
                //conn	=	new System.Data.Odbc.OdbcConnection(DSN="MyDSN");

                //Open the connection 
                conn.Open();
                //Fetch records from CSV
                sql_select = "select * from [" + filetable + "]";

                obj_oledb_da = new System.Data.Odbc.OdbcDataAdapter(sql_select, conn);
                //Fill dataset with the records from CSV file
                obj_oledb_da.Fill(ds, "Customers");

                if (bFill)
                {
                    //Set the datagrid properties				
                    dGridCSVdata.DataSource = ds;
                    dGridCSVdata.DataMember = "Customers";
                    //Close Connection to CSV file
                }
                conn.Close();
            }
            catch (Exception exe) //Error
            {
                MMSUtility.LogFile(exe.Message, "", "ConnectCSV", exe.LineNumber(), "PrintLetterDialog");
                MessageBox.Show(exe.Message);
            }
            return ds;
        }

        private void Format()
        {
            try
            {

                if (cmbFormats.SelectedIndex == 0)
                {
                    strFormat = "CSVDelimited";
                }
                else if (cmbFormats.SelectedIndex == 1)
                {
                    strFormat = "TabDelimited";
                }
                else
                {
                    strFormat = "Delimited(" + txtDelimiter.Text.Trim() + ")";
                }

            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }
            finally
            { }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                nMaxCount = 0;

                if (txtCSVFolderPath.Text == "")
                {
                    MessageBox.Show("The Folder Path TextBox cannot be empty.", "Warning");
                    return;
                }
                else if (txtCSVFilePath.Text == "")
                {
                    MessageBox.Show("The File Path TextBox cannot be empty.", "Warning");
                    return;
                }
                else if (txtDelimiter.Text == "\"")
                {
                    MessageBox.Show("You cannot specify (\") as a delimeter.", "Warning");
                    return;
                }
                else
                {
                    int intLengthOfFileName = txtCSVFilePath.Text.Trim().Length;
                    int intLastIndex = txtCSVFilePath.Text.Trim().LastIndexOf("\\");
                    strCSVFile = txtCSVFilePath.Text.Trim().Substring(intLastIndex, intLengthOfFileName - intLastIndex);
                    strCSVFile = strCSVFile.Remove(0, 1).Trim();
                    Format();

                    DataSet da = new DataSet();
                    da = this.ConnectCSV(strCSVFile, true);
                    AllCountLabel.Text = "(" + da.Tables["Customers"].Rows.Count.ToString() + ")";
                    nMaxCount = da.Tables["Customers"].Rows.Count;
                    //da.Tables["Stocks"].Columns[0].ColumnName.Trim()
                }
            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), "PrintLetterDialog");
                MessageBox.Show(ex.Message);
            }
            finally
            { }
        }

        public DataSet GetCustomerList()
        {
            DataSet da = new DataSet();
            da = this.ConnectCSV(strCSVFile, true);
            nMaxCount = da.Tables["Customers"].Rows.Count;
            return da;
        }

        # endregion      


    }
}
