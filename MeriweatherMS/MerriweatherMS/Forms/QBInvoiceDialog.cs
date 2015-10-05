using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interop.QBFC11;
using System.Windows.Forms.MMS;
//using System.Text.RegularExpressions;

namespace System.Windows.Forms
{
    public partial class QBInvoiceDialog : Form
    {
        private List<Item> pQBitems1 = new List<Item>();
        private List<Item> pQBitems2 = new List<Item>(); 
        private List<Item> pQBitems3 = new List<Item>();
        private List<Item> pQBitems4 = new List<Item>();

        private long nCustJobId = 0;
        public bool bNewInvoiceCreated = false;


        public string GetSelectedItem
        {
            get { return ItemComboBox1.Text; }
        }
        public string GetSelectedDescription
        {
            get { return DescTextBox1.Text; }
        }

        public QBInvoiceDialog(string szCustomerName, long nJobID, List<Item> QBitems1, List<Item> QBitems2, List<Item> QBitems3, List<Item> QBitems4)
        {
            InitializeComponent();
            nCustJobId = nJobID;
            CustomerNameTextBox.Text = szCustomerName;

            pQBitems1 = QBitems1;
            pQBitems2 = QBitems2;
            pQBitems3 = QBitems3;
            pQBitems4 = QBitems4;

            ItemComboBox1.DataSource = pQBitems1;
            ItemComboBox1.DisplayMember = "Name";
            ItemComboBox2.DataSource = pQBitems2;
            ItemComboBox2.DisplayMember = "Name";
            ItemComboBox3.DataSource = pQBitems3;
            ItemComboBox3.DisplayMember = "Name";
            ItemComboBox4.DataSource = pQBitems4;
            ItemComboBox4.DisplayMember = "Name";

            ItemGroupBox2.Enabled = false;
            ItemGroupBox3.Enabled = false;
            ItemGroupBox4.Enabled = false;

        }

        private void customerJobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerJobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);
        }

        private void QBInvoiceDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMSDataSet.Property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter.Fill(this.mMSDataSet.Property);
            // TODO: This line of code loads data into the 'mMSDataSet.CustPropertyJobs' table. You can move, or remove it, as needed.
            this.custPropertyJobsTableAdapter.FillByJobID2(this.mMSDataSet.CustPropertyJobs, nCustJobId);
            // TODO: This line of code loads data into the 'mMSDataSet.CustomerJob' table. You can move, or remove it, as needed.
            this.customerJobTableAdapter.FillBy(this.mMSDataSet.CustomerJob, nCustJobId);
            //bool bStatus = GetQBItems();

            ItemBCheckBox.Checked = false;
            ItemCCheckBox.Checked = false;
            ItemDCheckBox.Checked = false;
            
            if (costTextBox.Text.Length > 0)
            {
                string cost = costTextBox.Text;
                if (Convert.ToDouble(cost) > 0)  
                {
                    ItemBCheckBox.Checked = false;
                    ItemGroupBox2.Enabled = false;
                }
            }
            /*
            if (costBTextBox.Text.Length > 0)
            {
                string costb = costBTextBox.Text;
                //costb = costb.Substring(1);
                if (Convert.ToDouble(costb) > 0)
                {
                    ItemCCheckBox.Checked = false;
                    ItemGroupBox3.Enabled = true;                    
                }
            }
            ItemCCheckBox.Enabled = ItemBCheckBox.Checked;
            if (costCTextBox.Text.Length > 0)
            {
                string costc = costCTextBox.Text;
                //costb = costb.Substring(1);
                if (Convert.ToDouble(costc) > 0)
                {
                    ItemDCheckBox.Checked = false;
                    ItemGroupBox4.Enabled = true;
                }
            }
            ItemDCheckBox.Enabled = ItemCCheckBox.Checked;
            */

        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var invoiceItem1 = new InvoiceItem()
            {
                Amount = Convert.ToDouble(costTextBox.Text),
                Description = DescTextBox1.Text,
                QuickBooksID = qbItemIDTextBox.Text,
                Quantity = 1,

            };            

            var invoiceItem2 = new InvoiceItem()
            {
                Amount = Convert.ToDouble(costBTextBox.Text),
                Description = DescTextBox2.Text,
                QuickBooksID = qbItemIDBTextBox.Text,
                Quantity = 1,

            };
            var invoiceItem3 = new InvoiceItem()
            {
                Amount = Convert.ToDouble(costCTextBox.Text),
                Description = DescTextBox3.Text,
                QuickBooksID = qbItemIDCTextBox.Text,
                Quantity = 1,

            };
            var invoiceItem4 = new InvoiceItem()
            {
                Amount = Convert.ToDouble(costDTextBox.Text),
                Description = DescTextBox4.Text,
                QuickBooksID = qbItemIDDTextBox.Text,
                Quantity = 1,

            };

            if (AppendAddressCheckBox.Checked)
            {
                invoiceItem1.Description = DescTextBox1.Text + " - (" + addressTextBox.Text + ")";
                invoiceItem2.Description = DescTextBox2.Text + " - (" + addressTextBox.Text + ")";
                invoiceItem3.Description = DescTextBox3.Text + " - (" + addressTextBox.Text + ")";
                invoiceItem4.Description = DescTextBox4.Text + " - (" + addressTextBox.Text + ")";
            }

            //get item account
            //int index = ItemComboBox1.SelectedIndex; 
            //Item item1 = pQBitems1[index];

            qBInvoiceIDTextBox.Text = AddModQBInvoice(CustomerNameTextBox.Text, qBInvoiceIDTextBox.Text, invoiceItem1, invoiceItem2, invoiceItem3, invoiceItem4);            
            qbItemIDTextBox.Text = invoiceItem1.QuickBooksID;
            qbItemIDBTextBox.Text = invoiceItem2.QuickBooksID;
            qbItemIDCTextBox.Text = invoiceItem3.QuickBooksID;
            qbItemIDDTextBox.Text = invoiceItem4.QuickBooksID;

            this.customerJobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMSDataSet);

            Cursor.Current = Cursors.Default;
        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        ///        

        private string AddModQBInvoice(string szCustomerName, string szInvoiceQuickbookID, InvoiceItem invoiceItem1, InvoiceItem invoiceItem2, InvoiceItem invoiceItem3, InvoiceItem invoiceItem4)
        {
            bool sessionBegun = false;
            bool connectionOpen = false;
            QBSessionManager sessionManager = null;
            string invoiceID = "";
            bool bItemInvoice1 = false;
            bool bItemInvoice2 = false;
            bool bItemInvoice3 = false;
            bool bItemInvoice4 = false;

            try
            {
                //DateTime curDate = DateTime.Now;
                DateTime curDate = JobdateDateTimePicker.Value;

                //otherwise find for the lastest one
                /*
                int prevMonth = DateTime.Today.AddMonths(-1).Month;
                int curMonth = DateTime.Today.Month;
                int nextMonth = DateTime.Today.AddMonths(1).Month;
                int year = DateTime.Today.Year;
                */

                //int prevMonth = curDate.AddMonths(-1).Month;
                int curMonth = curDate.Month;
                int nextMonth = curDate.AddMonths(1).Month;
                int year = curDate.Year;           
                int nextyear = curDate.AddYears(1).Year;


                DateTime fromDate;
                DateTime toDate;
                Item item1 = pQBitems1[ItemComboBox1.SelectedIndex];
                Item item2 = pQBitems2[ItemComboBox2.SelectedIndex];
                Item item3 = pQBitems3[ItemComboBox3.SelectedIndex];
                Item item4 = pQBitems4[ItemComboBox4.SelectedIndex];

                //Create the session Manager object
                sessionManager = new QBSessionManager();

                //Create the message set request object to hold our request
                IMsgSetRequest requestMsgSet = sessionManager.CreateMsgSetRequest("US", 8, 0);
                requestMsgSet.Attributes.OnError = ENRqOnError.roeContinue;
                sessionManager.OpenConnection(MMSUtility.QBAppID, MMSUtility.QBAppName);

                connectionOpen = true;
                sessionManager.BeginSession("", ENOpenMode.omDontCare);
                sessionBegun = true;

                //find the customer information
                ICustomerQuery search = requestMsgSet.AppendCustomerQueryRq();
                search.ORCustomerListQuery.CustomerListFilter.ORNameFilter.NameFilter.MatchCriterion.SetValue(ENMatchCriterion.mcStartsWith);
                search.ORCustomerListQuery.CustomerListFilter.ORNameFilter.NameFilter.Name.SetValue(szCustomerName);

                IMsgSetResponse responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                IResponse response = responseMsgSet.ResponseList.GetAt(0);
                ICustomerRetList customerRetList = (ICustomerRetList)response.Detail;
                if (customerRetList == null)
                {
                    MessageBox.Show("Cannot find customer in QB!\nPlease check QB for Customer Name.");
                    return invoiceID;
                }

                ICustomerRet customerRet = customerRetList.GetAt(0);
                Customer customer = new Customer();
                customer.Name = customerRet.Name.GetValue();
                customer.QuickBooksID = customerRet.ListID.GetValue();
                customer.EditSequence = customerRet.EditSequence.GetValue();
                if (customerRet.FirstName != null) customer.FirstName = customerRet.FirstName.GetValue();
                if (customerRet.LastName != null) customer.LastName = customerRet.LastName.GetValue();


                bool notFound = true;
                if (szInvoiceQuickbookID.Length > 0)
                {
                    //get the lastest associated invoices for the particular customer
                    requestMsgSet.ClearRequests();
                    IInvoiceQuery invoiceQueryRq = requestMsgSet.AppendInvoiceQueryRq();
                    invoiceQueryRq.IncludeLineItems.SetValue(true);

                    //if invoiceID exist, use that                    
                    invoiceQueryRq.ORInvoiceQuery.TxnIDList.Add(szInvoiceQuickbookID);
                    //Send the request and get the response from QuickBooks
                    responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                    response = responseMsgSet.ResponseList.GetAt(0);
                    IInvoiceRetList invoiceRetList1 = (IInvoiceRetList)response.Detail;
                    
                    if (invoiceRetList1 != null) {
                        notFound = false;
                    }
                }

                // there is no existing invoice based on id, then search for invoice on date
                if (notFound)
                {         
                    //get the from prevmonth to curmonth invoice
                    if ((curDate.Day >= 1)&&(curDate.Day <= 19)) {
                        fromDate = new DateTime(year, curMonth, 1);
                        toDate = new DateTime(year, curMonth, 20);                    
                    }
                    //get curmonth to nextmonth invoice
                    else {
                        if (nextMonth == 1)
                        {
                            fromDate = new DateTime(year, curMonth, 21);
                            toDate = new DateTime(nextyear, nextMonth, 20);
                        }
                        else
                        {
                            //if next month is jan, then account for next year
                            fromDate = new DateTime(year, curMonth, 21);
                            toDate = new DateTime(year, nextMonth, 20);
                        }
                  
                    }

                    //get the lastest associated invoices for the particular customer
                    requestMsgSet.ClearRequests();
                    IInvoiceQuery invoiceQueryRq = requestMsgSet.AppendInvoiceQueryRq();
                    invoiceQueryRq.IncludeLineItems.SetValue(true);

                    invoiceQueryRq.ORInvoiceQuery.InvoiceFilter.EntityFilter.OREntityFilter.FullNameList.Add(szCustomerName);
                    invoiceQueryRq.ORInvoiceQuery.InvoiceFilter.ORDateRangeFilter.TxnDateRangeFilter.ORTxnDateRangeFilter.TxnDateFilter.FromTxnDate.SetValue(fromDate);
                    invoiceQueryRq.ORInvoiceQuery.InvoiceFilter.ORDateRangeFilter.TxnDateRangeFilter.ORTxnDateRangeFilter.TxnDateFilter.ToTxnDate.SetValue(toDate);
                    //ENPaidStatus status = ENPaidStatus.psNotPaidOnly;
                    //invoiceQueryRq.ORInvoiceQuery.InvoiceFilter.PaidStatus.SetValue(status);

                }

                //Send the request and get the response from QuickBooks
                responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                response = responseMsgSet.ResponseList.GetAt(0);
                IInvoiceRetList invoiceRetList = (IInvoiceRetList)response.Detail;

                //check for FC
                int numIndex = -1;
                if (invoiceRetList != null)
                {
                    numIndex = 0;
                    IInvoiceRet invoiceRet1 = invoiceRetList.GetAt(numIndex);
                    string refNum = invoiceRet1.RefNumber.GetValue();
                    if (refNum.StartsWith("FC"))
                    {
                        //get the next one
                        if (invoiceRetList.Count > 1) numIndex = 1;
                        else numIndex = -1;
                    }                    
                }

                //if need - create  new invoice 
                if ((invoiceRetList == null)||(numIndex == -1))
                {
                    Invoice invoice = new Invoice();
                    invoice.Customer = customer;
                    requestMsgSet.ClearRequests();
                    IInvoiceAdd invoiceAddRq = requestMsgSet.AppendInvoiceAddRq();

                    //get the current month
                    DateTime invoiceDate;
                    if ((curDate.Day >= 1) && (curDate.Day <= 19))
                    {
                        invoiceDate = new DateTime(year, curMonth, 20);
                    }
                    //get next month
                    else
                    {
                        if (nextMonth == 1)
                        {
                            invoiceDate = new DateTime(nextyear, nextMonth, 20);
                        }
                        else
                        {
                            //if next month is jan, then account for next year
                            invoiceDate = new DateTime(year, nextMonth, 20);
                        }
     
                    }

                    invoiceAddRq.TxnDate.SetValue(invoiceDate);
                    invoiceAddRq.CustomerRef.ListID.SetValue(invoice.Customer.QuickBooksID);                    

                    /////////////////////////////////////////////////////////////////////////////////
                    if (invoiceItem1.Amount > 0)
                    {
                        if (invoiceItem1.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem1", "AddModQBInvoice", 0, "QBInvoiceDialog");                            
                        }

                        IORInvoiceLineAdd orInvoiceLineAdd1 = invoiceAddRq.ORInvoiceLineAddList.Append();
                        orInvoiceLineAdd1.InvoiceLineAdd.ItemRef.ListID.SetValue(item1.QuickBooksID);
                        orInvoiceLineAdd1.InvoiceLineAdd.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        orInvoiceLineAdd1.InvoiceLineAdd.Amount.SetValue(invoiceItem1.Amount);
                        orInvoiceLineAdd1.InvoiceLineAdd.Quantity.SetValue(invoiceItem1.Quantity);
                        orInvoiceLineAdd1.InvoiceLineAdd.Desc.SetValue(invoiceItem1.Description);
                        bItemInvoice1 = true;
                    }
                
                    ///////////////////////////////////////////////////////////////////////////////// 
                    if ((ItemBCheckBox.Checked) && (invoiceItem2.Amount > 0))
                    {
                        if (invoiceItem2.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem2", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }
                        IORInvoiceLineAdd orInvoiceLineAdd2 = invoiceAddRq.ORInvoiceLineAddList.Append();
                        orInvoiceLineAdd2.InvoiceLineAdd.ItemRef.ListID.SetValue(item2.QuickBooksID);
                        orInvoiceLineAdd2.InvoiceLineAdd.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        orInvoiceLineAdd2.InvoiceLineAdd.Amount.SetValue(invoiceItem2.Amount);
                        orInvoiceLineAdd2.InvoiceLineAdd.Quantity.SetValue(invoiceItem2.Quantity);
                        orInvoiceLineAdd2.InvoiceLineAdd.Desc.SetValue(invoiceItem2.Description);
                        bItemInvoice2 = true;
                    }

                    /////////////////////////////////////////////////////////////////////////////////
                    if ((ItemCCheckBox.Checked)&&(invoiceItem3.Amount > 0))
                    {
                        if (invoiceItem3.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem3", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }

                        IORInvoiceLineAdd orInvoiceLineAdd3 = invoiceAddRq.ORInvoiceLineAddList.Append();
                        orInvoiceLineAdd3.InvoiceLineAdd.ItemRef.ListID.SetValue(item3.QuickBooksID);
                        orInvoiceLineAdd3.InvoiceLineAdd.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        orInvoiceLineAdd3.InvoiceLineAdd.Amount.SetValue(invoiceItem3.Amount);
                        orInvoiceLineAdd3.InvoiceLineAdd.Quantity.SetValue(invoiceItem3.Quantity);
                        orInvoiceLineAdd3.InvoiceLineAdd.Desc.SetValue(invoiceItem3.Description);
                        bItemInvoice3 = true;
                    }

                    /////////////////////////////////////////////////////////////////////////////////
                    if ((ItemDCheckBox.Checked)&&(invoiceItem4.Amount > 0))
                    {
                        if (invoiceItem4.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem4", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }

                        IORInvoiceLineAdd orInvoiceLineAdd4 = invoiceAddRq.ORInvoiceLineAddList.Append();
                        orInvoiceLineAdd4.InvoiceLineAdd.ItemRef.ListID.SetValue(item4.QuickBooksID);
                        orInvoiceLineAdd4.InvoiceLineAdd.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        orInvoiceLineAdd4.InvoiceLineAdd.Amount.SetValue(invoiceItem4.Amount);
                        orInvoiceLineAdd4.InvoiceLineAdd.Quantity.SetValue(invoiceItem4.Quantity);
                        orInvoiceLineAdd4.InvoiceLineAdd.Desc.SetValue(invoiceItem4.Description);
                        bItemInvoice4 = true;
                    }

                    //Send the request and get the response from QuickBooks 
                    responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                    response = responseMsgSet.ResponseList.GetAt(0);
                    IInvoiceRet invoiceRet = (IInvoiceRet)response.Detail;

                    if (bItemInvoice1)
                        invoiceItem1.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(0).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice2)
                        invoiceItem2.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(1).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice3)
                        invoiceItem3.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(2).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice4)
                        invoiceItem4.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(3).InvoiceLineRet.TxnLineID.GetValue();

                    invoice.QuickBooksID = invoiceRet.TxnID.GetValue();
                    invoiceID = invoice.QuickBooksID;
                    bNewInvoiceCreated = true;
                }
                else
                {
                    //get the latest invoice
                    IInvoiceRet invoiceRet = invoiceRetList.GetAt(numIndex);
                    var invoice = new Invoice
                    {
                        Customer = customer,
                        QuickBooksID = invoiceRet.TxnID.GetValue(),
                        EditSequence = invoiceRet.EditSequence.GetValue()
                    };

                    requestMsgSet.ClearRequests();
                    IInvoiceMod invoiceModRq = requestMsgSet.AppendInvoiceModRq();
                    invoiceModRq.TxnID.SetValue(invoice.QuickBooksID);
                    invoiceModRq.EditSequence.SetValue(invoice.EditSequence);

                    //if no assocated item, then add new item to the current invoice //andy change this                    
                    if (invoiceRet.ORInvoiceLineRetList != null)
                    {
                        for (int j = 0; j < invoiceRet.ORInvoiceLineRetList.Count; j++)
                        {
                            IORInvoiceLineRet ORInvoiceLineRet = invoiceRet.ORInvoiceLineRetList.GetAt(j);
                            //if there is an item, don't add it (it will act as a delete)

                            if ((qbItemIDTextBox.Text != ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue()) &&
                                (qbItemIDBTextBox.Text != ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue()) &&
                                (qbItemIDCTextBox.Text != ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue()) &&
                                (qbItemIDDTextBox.Text != ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue()))
                            {
                                IORInvoiceLineMod ORinvoicemod1 = invoiceModRq.ORInvoiceLineModList.Append();
                                ORinvoicemod1.InvoiceLineMod.TxnLineID.SetValue(ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue());
                            }                            
                        }
                    }

                    //this add the new line
                    if (invoiceItem1.Amount >= 0)
                    {
                        if (invoiceItem1.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem1", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }
                        IORInvoiceLineMod ORinvoicemod1 = invoiceModRq.ORInvoiceLineModList.Append();
                        ORinvoicemod1.InvoiceLineMod.TxnLineID.SetValue("-1");
                        ORinvoicemod1.InvoiceLineMod.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        ORinvoicemod1.InvoiceLineMod.ItemRef.ListID.SetValue(item1.QuickBooksID);
                        ORinvoicemod1.InvoiceLineMod.Amount.SetValue(invoiceItem1.Amount);
                        ORinvoicemod1.InvoiceLineMod.Quantity.SetValue(invoiceItem1.Quantity);
                        ORinvoicemod1.InvoiceLineMod.Desc.SetValue(invoiceItem1.Description);
                        bItemInvoice1 = true;

                    }
                    if ((ItemBCheckBox.Checked)&&(invoiceItem2.Amount > 0))
                    {
                        if (invoiceItem2.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem2", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }
                        IORInvoiceLineMod ORinvoicemod2 = invoiceModRq.ORInvoiceLineModList.Append();
                        ORinvoicemod2.InvoiceLineMod.TxnLineID.SetValue("-1");
                        ORinvoicemod2.InvoiceLineMod.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        ORinvoicemod2.InvoiceLineMod.ItemRef.ListID.SetValue(item2.QuickBooksID);
                        ORinvoicemod2.InvoiceLineMod.Amount.SetValue(invoiceItem2.Amount);
                        ORinvoicemod2.InvoiceLineMod.Quantity.SetValue(invoiceItem2.Quantity);
                        ORinvoicemod2.InvoiceLineMod.Desc.SetValue(invoiceItem2.Description);
                        bItemInvoice2 = true;
                    }
                    if ((ItemCCheckBox.Checked)&&(invoiceItem3.Amount > 0))
                    {
                        if (invoiceItem3.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem3", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }
                        IORInvoiceLineMod ORinvoicemod3 = invoiceModRq.ORInvoiceLineModList.Append();
                        ORinvoicemod3.InvoiceLineMod.TxnLineID.SetValue("-1");
                        ORinvoicemod3.InvoiceLineMod.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        ORinvoicemod3.InvoiceLineMod.ItemRef.ListID.SetValue(item3.QuickBooksID);
                        ORinvoicemod3.InvoiceLineMod.Amount.SetValue(invoiceItem3.Amount);
                        ORinvoicemod3.InvoiceLineMod.Quantity.SetValue(invoiceItem3.Quantity);
                        ORinvoicemod3.InvoiceLineMod.Desc.SetValue(invoiceItem3.Description);
                        bItemInvoice3 = true;
                    }
                    if ((ItemDCheckBox.Checked)&&(invoiceItem4.Amount > 0))
                    {
                        if (invoiceItem4.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "invoiceItem4", "AddModQBInvoice", 0, "QBInvoiceDialog");
                        }
                        IORInvoiceLineMod ORinvoicemod4 = invoiceModRq.ORInvoiceLineModList.Append();
                        ORinvoicemod4.InvoiceLineMod.TxnLineID.SetValue("-1");
                        ORinvoicemod4.InvoiceLineMod.ServiceDate.SetValue(JobdateDateTimePicker.Value);
                        ORinvoicemod4.InvoiceLineMod.ItemRef.ListID.SetValue(item4.QuickBooksID);
                        ORinvoicemod4.InvoiceLineMod.Amount.SetValue(invoiceItem4.Amount);
                        ORinvoicemod4.InvoiceLineMod.Quantity.SetValue(invoiceItem4.Quantity);
                        ORinvoicemod4.InvoiceLineMod.Desc.SetValue(invoiceItem4.Description);
                        bItemInvoice4 = true;
                    }

                    //Send the request and get the response from QuickBooks 
                    responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                    response = responseMsgSet.ResponseList.GetAt(0);
                    invoiceRet = (IInvoiceRet)response.Detail;

                    invoice.QuickBooksID = invoiceRet.TxnID.GetValue();
                    invoiceID = invoice.QuickBooksID;
                    
                    int nIndex = invoiceRet.ORInvoiceLineRetList.Count - 1;
                    if (bItemInvoice4)
                        invoiceItem4.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(nIndex-3).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice3)
                        invoiceItem3.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(nIndex-2).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice2)
                        invoiceItem2.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(nIndex-1).InvoiceLineRet.TxnLineID.GetValue();
                    if (bItemInvoice1)
                        invoiceItem1.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(nIndex).InvoiceLineRet.TxnLineID.GetValue();

                    bNewInvoiceCreated = false;
                }
            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, "", "AddModQBInvoice", ex.LineNumber(), "QBInvoiceDialog");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                //End the session and close the connection to QuickBooks
                if (sessionBegun)
                {
                    sessionManager.EndSession();
                }
                if (connectionOpen)
                {
                    sessionManager.CloseConnection();
                }
            }
            return invoiceID;
        }

        private void costTextBox_TextChanged_1(object sender, EventArgs e)
        {      
            /*
            ItemGroupBox2.Enabled = false;
            ItemGroupBox3.Enabled = false;
            if (costTextBox.Text.Length > 0)
            {
                string cost = costTextBox.Text;
                if (Convert.ToDouble(cost) > 0)  
                {
                    ItemGroupBox2.Enabled = true;
                }
            }
            if (costBTextBox.Text.Length > 0)
            {
                string costb = costBTextBox.Text;
                //costb = costb.Substring(1);
                if (Convert.ToDouble(costb) > 0)
                {
                    ItemGroupBox3.Enabled = true;
                }
            }*/             
        }

        private void ItemBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ItemGroupBox2.Enabled = ItemBCheckBox.Checked;
            if (ItemBCheckBox.Checked)
                ItemCCheckBox.Enabled = true;
            else
                ItemCCheckBox.Enabled = false;
        }

        private void ItemCCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ItemGroupBox3.Enabled = ItemCCheckBox.Checked;
            if (ItemCCheckBox.Checked)
                ItemDCheckBox.Enabled = true;
            else
                ItemDCheckBox.Enabled = false;

        }

        private void ItemDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ItemGroupBox4.Enabled = ItemDCheckBox.Checked;
        }
    }
}
