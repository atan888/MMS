using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb; //This namespace is mainly used for dealing with 
using System.Data.SqlClient;
using System.Web;
using System.Data.SqlTypes;

namespace System.Windows.Forms.MMS
{
    public partial class ImportForm : Form
    {
        private string _Message = "";
        private bool _stopProcess = false;
        private int _recNum = 0;
        private bool bFourstepFlag = false;
        private string _szFileName = "";

        string nwsltr = "";
        string gut = "";
        string foursp = "";
        string fourspnum = "";
        string bags = "";
        string fourspdollar = "";
        string foursp1 = "";
        string foursp2 = "";
        string foursp3 = "";
        string foursp4 = "";
        string leaf = "";
        string mow = "";
        string number = "";
        string lname = "";
        string fname = "";
        string idnum = "";
        string address1 = "";
        string address2 = "";
        string city = "";
        string state = "";
        string zip = "";
        string freq = "";
        string cost = "";
        string cdollar = "";
        string phone = "";
        string subdiv = "";
        string custtype = "";
        string winterservices = "";
        string springservices = "";
        string summerservices = "";
        string fallservices = "";
        string leafinstruct = "";
        string specialinstruct = "";
        string fourspinstruct = "";
        string gutinstruct = "";
        string propmow = "";
        string propfourstep = "";
        string propseed = "";
        string propfert = "";
        string proplime = "";
        string propaerate = "";
        
        public ImportForm()
        {
            InitializeComponent();
            stopBtn.Enabled = false;
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = @"C:\Documents and Settings\Andy\My Documents";
            dlg.Filter = "CVS File (*.xls)|*.xls";            

            if (dlg.ShowDialog() != DialogResult.Cancel)
            {
                fileNameTxtBox.Text = dlg.FileName;
                _szFileName = dlg.FileName;
            }

            else
            {
                fileNameTxtBox.Text = "";
                _szFileName = "";
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            //start background thread
            if (fileNameTxtBox.Text.Length > 0)
            {
                convertBtn.Enabled = false;
                stopBtn.Enabled = true;
                _stopProcess = false;

                PrintToOutput("Begin Conversion...");
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                PrintToOutput("Please specify filename...");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            convertBtn.Enabled = true;
            stopBtn.Enabled = false;
            _stopProcess = true;
            backgroundWorker1.CancelAsync();
            PrintToOutput("Conversion aborted...");
        }   

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertToSQL();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (_Message.Length > 0)
            {
                PrintToOutput(_Message);
                _Message = "";
            }
            recordNumTextBox.Text = _recNum.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PrintToOutput("Import Competed..." + _recNum.ToString() + " records");
        }

        private void ConvertToSQL()
        {
            //string szFile = "C:\\Documents and Settings\\andy.tan\\My Documents\\Visual Studio 2008\\Projects\\MerriweatherMS\\ImportCVS\\ImportCVS\\bin\\Debug\\example-one.xls";
            backgroundWorker1.ReportProgress(0);
            //OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileNameTxtBox.Text.ToString() + "; Extended Properties=Excel 8.0");
            OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _szFileName + "; Extended Properties=Excel 8.0");

            //OledbConnection and connectionstring to connect to the Excel Sheet
            try
            {
                //After connecting to the Excel sheet here we are selecting the data using select statement from the Excel sheet
	            OleDbCommand ocmd = new OleDbCommand("select * from [Sheet1$]", oconn);
               
                //in the Excel file where the data is present
                oconn.Open();  //Here [Sheet1$] is the name of the sheet 
                
                OleDbDataReader odr = ocmd.ExecuteReader();
               

                while (odr.Read())
                {
                    bFourstepFlag = false;

                    nwsltr = valid(odr, 0);
                    gut = valid(odr, 1);
                    foursp = valid(odr, 2);
                    fourspnum = valid(odr, 3);  //4step route number
                    bags = valid(odr, 4);
                    fourspdollar = valid(odr, 5);
                    foursp1 = valid(odr, 6);
                    foursp2 = valid(odr, 7);
                    foursp3 = valid(odr, 8);
                    foursp4 = valid(odr, 9);
                    leaf = valid(odr, 10);
                    mow = valid(odr, 11);
                    number = valid(odr, 12);  //main route number
                    lname = valid(odr, 13);
                    fname = valid(odr, 14);
                    idnum = valid(odr, 15);
                    address1 = valid(odr, 16);
                    address2 = valid(odr, 17);
                    city = valid(odr, 18);
                    state = valid(odr, 19);
                    zip = valid(odr, 20);
                    freq = valid(odr, 21);
                    cost = valid(odr, 22);
                    cdollar = valid(odr, 23);
                    phone = valid(odr, 24);
                    subdiv = valid(odr, 25);
                    custtype = valid(odr, 26);
                    winterservices = valid(odr, 27);
                    springservices = valid(odr, 28);
                    summerservices = valid(odr, 29);
                    fallservices = valid(odr, 30);
                    leafinstruct = valid(odr, 31);
                    specialinstruct = valid(odr, 32);
                    fourspinstruct = valid(odr, 33);
                    gutinstruct = valid(odr, 34);
                    propmow = valid(odr, 35);
                    propfourstep = valid(odr, 36);
                    propseed = valid(odr, 37);
                    propfert = valid(odr, 38);
                    proplime = valid(odr, 39);
                    propaerate = valid(odr, 40);
                    
                    _Message = "Record = " + fname + " " + lname;
                    _recNum++;
                    backgroundWorker1.ReportProgress(0);
                    if (_stopProcess) break;

                    //if fourstep date, then set bit flag
                    if ((foursp1.Length > 2) || (foursp2.Length > 2) || (foursp3.Length > 2) || (foursp4.Length > 2))
                        bFourstepFlag = true;

                    //Here using this method we are inserting the data into the database
                    int custID = InsertToCustomerTable();
                    int propID = InsertToPropertyTable(custID);
                    int serviceID = InsertToServiceTable(propID);
                }
                oconn.Close();
            }
            catch (DataException ee)
            {
                _Message = ee.Message;
                backgroundWorker1.ReportProgress(0);
                //lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                _Message = "Data Inserted Sucessfully";
                backgroundWorker1.ReportProgress(0);
                //lblmsg.ForeColor = System.Drawing.Color.Green;
            }
        } 
    
        protected string valid(OleDbDataReader myreader, int stval)//if any columns are found null then they are replaced by zero
        {            
            object val = myreader[stval];
            if (val != DBNull.Value)
                return val.ToString();
            else                
                return Convert.ToString(0);            
        }


        public int InsertToCustomerTable()
        {
            //inserting data into the Sql Server
            SqlConnection conn = new global::System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = global::System.Windows.Forms.MMS.Properties.Settings.Default.MMSConnectionString1;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "insert into Customer(LastName,FirstName,Address,City, State,Zip, Phone1, Type, Newsletter, Active, GroupType) values(@lname,@fname,@address,@city,@state,@zip,@phone,@custtype,@nwsltr, @active, @grouptype); SELECT SCOPE_IDENTITY()";
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address1;
            cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
            cmd.Parameters.Add("@state", SqlDbType.Char).Value = state;
            cmd.Parameters.Add("@zip", SqlDbType.VarChar).Value = zip;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;            
            cmd.Parameters.Add("@custtype", SqlDbType.VarChar).Value = "not-used";
            //cmd.Parameters.Add("@nwsltr", SqlDbType.Bit).Value = (nwsltr.Length > 0);
            cmd.Parameters.Add("@nwsltr", SqlDbType.Bit).Value = false;
            cmd.Parameters.Add("@active", SqlDbType.Bit).Value = true;

            if (custtype == "C")
                cmd.Parameters.Add("@grouptype", SqlDbType.VarChar).Value = "Current";
            else
                cmd.Parameters.Add("@grouptype", SqlDbType.VarChar).Value = "InFrequent";

            cmd.CommandType = CommandType.Text;
            conn.Open();
            //cmd.ExecuteNonQuery();
            string insertedID = cmd.ExecuteScalar().ToString(); ;
            conn.Close();

            return Convert.ToInt16(insertedID);
        }

        public int InsertToPropertyTable(int custID)
        {            
            //inserting data into the Sql Server
            SqlConnection conn = new global::System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = global::System.Windows.Forms.MMS.Properties.Settings.Default.MMSConnectionString1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Property(CustomerID, Description, Address, City, State,Zip, Phone, Subdivision, Active) values(@custID, @description, @address,@city,@state,@zip,@phone,@subdiv, @active); SELECT SCOPE_IDENTITY()";
            cmd.Parameters.Add("@custID", SqlDbType.Int).Value = custID;
            //cmd.Parameters.Add("@routeID", SqlDbType.VarChar).Value = routeID;
            string desc = lname + "," + fname;
            cmd.Parameters.Add("@description", SqlDbType.VarChar).Value = desc;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address1;
            cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
            cmd.Parameters.Add("@state", SqlDbType.Char).Value = state;
            cmd.Parameters.Add("@zip", SqlDbType.VarChar).Value = zip;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@subdiv", SqlDbType.VarChar).Value = subdiv;
            cmd.Parameters.Add("@active", SqlDbType.Bit).Value = true;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            //cmd.ExecuteNonQuery();
            string insertedID = cmd.ExecuteScalar().ToString(); ;
            conn.Close();
            return Convert.ToInt16(insertedID);
        }

        public int InsertToServiceTable(int propID)
        {

            SqlDateTime sqldatenull = SqlDateTime.Null;

            //inserting data into the Sql Server
            SqlConnection conn = new global::System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = global::System.Windows.Forms.MMS.Properties.Settings.Default.MMSConnectionString1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (bFourstepFlag)
                cmd.CommandText = "insert into Service(PropertyID, Date, FourStepType, GutterType, LeafType, MowType, OtherType, Frequency, SpringServices, SummerServices, FallServices, WinterServices, PropMow, PropFourStep, PropSeed, PropFertilize, PropLime, PropAeration, ContractorCost, Cost, FourStepCost, FourStepDate1, FourStepDate2, FourStepDate3, FourStepDate4, FourStepInstruct, FourStepMat, GutterInstruct, LeafInstruct, SpecInstruct) " +
                    "values(@propId, @date, @foursteptype, @guttertype, @leaftype, @mowtype, @othertype, @frequency, @springservices, @summerservices, @fallservices, @winterservices, @propmow, @propfourstep, @propseed, @propfertilize, @proplime, @propaeration, @contractorcost, @cost, @fourstepcost, @fourstepdate1, @fourstepdate2, @fourstepdate3, @fourstepdate4, @fourstepinstruct, @fourstepmat, @gutterinstruct, @leafinstruct, @specinstruct); SELECT SCOPE_IDENTITY()";            
            else
                cmd.CommandText = "insert into Service(PropertyID, Date, FourStepType, GutterType, LeafType, MowType, OtherType, Frequency, SpringServices, SummerServices, FallServices, WinterServices, PropMow, PropFourStep, PropSeed, PropFertilize, PropLime, PropAeration, ContractorCost, Cost, FourStepCost, FourStepInstruct, FourStepMat, GutterInstruct, LeafInstruct, SpecInstruct) " +
                "values(@propId, @date, @foursteptype, @guttertype, @leaftype, @mowtype, @othertype, @frequency, @springservices, @summerservices, @fallservices, @winterservices, @propmow, @propfourstep, @propseed, @propfertilize, @proplime, @propaeration, @contractorcost, @cost, @fourstepcost, @fourstepinstruct, @fourstepmat, @gutterinstruct, @leafinstruct, @specinstruct); SELECT SCOPE_IDENTITY()";            

            cmd.Parameters.Add("@propId", SqlDbType.Int).Value = propID;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;

            if (bFourstepFlag) 
                cmd.Parameters.Add("@foursteptype", SqlDbType.Bit).Value = 1;
            else
                cmd.Parameters.Add("@foursteptype", SqlDbType.Bit).Value = 0;

            cmd.Parameters.Add("@guttertype", SqlDbType.Bit).Value = 0;
            cmd.Parameters.Add("@leaftype", SqlDbType.Bit).Value = 0;
            cmd.Parameters.Add("@mowtype", SqlDbType.Bit).Value = 0;
            cmd.Parameters.Add("@othertype", SqlDbType.Bit).Value = 0;

            if (freq == "101") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "INF";
            else if (freq == "102") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "I";
            else if (freq == "103") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "1/Mo";
            else if (freq == "104") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "2/Mo";
            else if (freq == "105") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "14-28";
            else if (freq == "105") cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = "I7-1/Mo";
            else cmd.Parameters.Add("@frequency", SqlDbType.VarChar).Value = freq;

            if (springservices == "0") springservices = "";
            if (summerservices == "0") summerservices = "";
            if (fallservices == "0") fallservices = "";
            if (winterservices == "0") winterservices = "";
            cmd.Parameters.Add("@springservices", SqlDbType.VarChar).Value = springservices;
            cmd.Parameters.Add("@summerservices", SqlDbType.VarChar).Value = summerservices;
            cmd.Parameters.Add("@fallservices", SqlDbType.VarChar).Value = fallservices;
            cmd.Parameters.Add("@winterservices", SqlDbType.VarChar).Value = winterservices;                
            cmd.Parameters.Add("@propmow", SqlDbType.Money).Value = Convert.ToDouble(propmow);
            cmd.Parameters.Add("@propfourstep", SqlDbType.Money).Value = Convert.ToDouble(propfourstep);
            cmd.Parameters.Add("@propseed", SqlDbType.Money).Value = Convert.ToDouble(propseed);
            cmd.Parameters.Add("@propfertilize", SqlDbType.Money).Value = Convert.ToDouble(propfert);
            cmd.Parameters.Add("@proplime", SqlDbType.Money).Value = Convert.ToDouble(proplime);
            cmd.Parameters.Add("@propaeration", SqlDbType.Money).Value = Convert.ToDouble(propaerate);
            cmd.Parameters.Add("@contractorcost", SqlDbType.Money).Value = Convert.ToDouble(cdollar);
            cmd.Parameters.Add("@cost", SqlDbType.Money).Value = Convert.ToDouble(cost);
            cmd.Parameters.Add("@fourstepcost", SqlDbType.Money).Value = Convert.ToDouble(fourspdollar);

            if (bFourstepFlag)
            {
                if (foursp1 == "0") cmd.Parameters.Add("@fourstepdate1", SqlDbType.DateTime).Value = sqldatenull;
                else cmd.Parameters.Add("@fourstepdate1", SqlDbType.DateTime).Value = StringToDate(foursp1);
                if (foursp2 == "0") cmd.Parameters.Add("@fourstepdate2", SqlDbType.DateTime).Value = sqldatenull;
                else cmd.Parameters.Add("@fourstepdate2", SqlDbType.DateTime).Value = StringToDate(foursp2);
                if (foursp3 == "0") cmd.Parameters.Add("@fourstepdate3", SqlDbType.DateTime).Value = sqldatenull;
                else cmd.Parameters.Add("@fourstepdate3", SqlDbType.DateTime).Value = StringToDate(foursp3);
                if (foursp4 == "0") cmd.Parameters.Add("@fourstepdate4", SqlDbType.DateTime).Value = sqldatenull;
                else cmd.Parameters.Add("@fourstepdate4", SqlDbType.DateTime).Value = StringToDate(foursp4);
            }
            
            if (fourspinstruct == "0") fourspinstruct = "";
            if (gutinstruct == "0") gutinstruct = "";
            if (leafinstruct == "0") leafinstruct = "";
            if (specialinstruct == "0") specialinstruct = "";
            cmd.Parameters.Add("@fourstepinstruct", SqlDbType.VarChar).Value = fourspinstruct;
            cmd.Parameters.Add("@fourstepmat", SqlDbType.Real).Value = Convert.ToDouble(bags);
            cmd.Parameters.Add("@gutterinstruct", SqlDbType.VarChar).Value = gutinstruct;
            cmd.Parameters.Add("@leafinstruct", SqlDbType.VarChar).Value = leafinstruct;
            cmd.Parameters.Add("@specinstruct", SqlDbType.VarChar).Value = specialinstruct;

            cmd.CommandType = CommandType.Text;
            conn.Open();
            //cmd.ExecuteNonQuery();
            string insertedID = cmd.ExecuteScalar().ToString(); ;
            conn.Close();
            
            return Convert.ToInt16(insertedID);
        }

        //Method for printing to the output window on the UI
        private void PrintToOutput(string txt)
        {
            txt = txt + "\r\n";
            OutputTxtBox.AppendText(txt);
        }

        public DateTime StringToDate(string strDate)
        {
            if (strDate.Length < 3)
            {
                return DateTime.Now;
            }
            else
            {
                string[] num = strDate.Split('/');
                DateTime theDate = new DateTime(2009, Convert.ToInt16(num[0]), Convert.ToInt16(num[1]));
                return theDate;                
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        /*              
        protected void deletedata_Click(object sender, EventArgs e)//Here we are deleting 
						    // the data from the SQL Server
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;
	        AttachDbFileName=|DataDirectory|exceltosql.mdf;Trusted_Connection=yes");
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from emp";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
            }
            catch (DataException de1)
            {
                lblmsg.Text = de1.Message;
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                lblmsg.Text = "Data Deleted Sucessfully";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
        */
       
    }
}
