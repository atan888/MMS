using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interop.QBFC11;

namespace System.Windows.Forms.MMS
{
    public partial class QBBatchInvoiceDialog : Form
    {
        private List<Item> pQBitems1 = new List<Item>();
  
        public string DescText1
        {
            get { return DescTextBox1.Text; }
            set
            {
                if (object.ReferenceEquals(DescText1, value) != true)
                {
                    DescTextBox1.Text = value;
                }
            }
        }
        
        public string GetSelectedItem
        {
            get { return ItemComboBox1.Text; }
        }

        public bool AppendAddress
        {
            get { return AppendAddressCheckBox.Checked; }
        }
                
        public QBBatchInvoiceDialog(List<Item> QBitems1)
        {
            InitializeComponent();

            pQBitems1 = QBitems1;

            ItemComboBox1.DataSource = pQBitems1;
            ItemComboBox1.DisplayMember = "Name";

        }

        public void AddToListBox(string szLine)
        {
            CustomerInoviceListBox.Items.Add(szLine);
            TotalLabel.Text = "Total: " + CustomerInoviceListBox.Items.Count.ToString();
        }
        
        public string AddModQBInvoice(string szCustomerName, string szInvoiceQuickbookID, InvoiceItem invoiceItem1, DateTime jobDate, string itemA_ID)
        {
            bool sessionBegun = false;
            bool connectionOpen = false;
            QBSessionManager sessionManager = null;
            string invoiceID = "";
            bool bItemInvoice1 = false;

            try
            {
                //DateTime curDate = DateTime.Now;
                DateTime curDate = jobDate;

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
                    //MessageBox.Show("Cannot find customer in QB!\nPlease check QB for Customer Name.");
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

                    if (invoiceRetList1 != null)
                    {
                        notFound = false;
                    }
                }

                // there is no existing invoice based on id, then search for invoice on date
                if (notFound)
                {
                    //get the from prevmonth to curmonth invoice
                    if ((curDate.Day >= 1) && (curDate.Day <= 19))
                    {
                        fromDate = new DateTime(year, curMonth, 1);
                        toDate = new DateTime(year, curMonth, 20);
                    }
                    //get curmonth to nextmonth invoice
                    else
                    {
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

                //if need new invoice 
                if ((invoiceRetList == null) || (numIndex == -1))
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
                        };
                    }

                    invoiceAddRq.TxnDate.SetValue(invoiceDate);
                    invoiceAddRq.CustomerRef.ListID.SetValue(invoice.Customer.QuickBooksID);

                    /////////////////////////////////////////////////////////////////////////////////
                    if (invoiceItem1.Amount >= 0)
                    {
                        if (invoiceItem1.Amount == 0)
                        {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "", "AddModQBInvoice", 0, "QBBatchInvoiceDialog");
                        }

                        IORInvoiceLineAdd orInvoiceLineAdd1 = invoiceAddRq.ORInvoiceLineAddList.Append();
                        orInvoiceLineAdd1.InvoiceLineAdd.ItemRef.ListID.SetValue(item1.QuickBooksID);
                        orInvoiceLineAdd1.InvoiceLineAdd.ServiceDate.SetValue(invoiceItem1.Date);
                        orInvoiceLineAdd1.InvoiceLineAdd.Amount.SetValue(invoiceItem1.Amount);
                        orInvoiceLineAdd1.InvoiceLineAdd.Quantity.SetValue(invoiceItem1.Quantity);
                        orInvoiceLineAdd1.InvoiceLineAdd.Desc.SetValue(invoiceItem1.Description);
                        bItemInvoice1 = true;
                    }
                    //Send the request and get the response from QuickBooks 
                    responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                    response = responseMsgSet.ResponseList.GetAt(0);
                    IInvoiceRet invoiceRet = (IInvoiceRet)response.Detail;

                    if (bItemInvoice1)
                        invoiceItem1.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(0).InvoiceLineRet.TxnLineID.GetValue();                   

                    invoice.QuickBooksID = invoiceRet.TxnID.GetValue();
                    invoiceID = invoice.QuickBooksID;
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
                    //invoiceRet.TxnNumber.GetValue();

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

                            if (itemA_ID != ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue())
                            {
                                IORInvoiceLineMod ORinvoicemod1 = invoiceModRq.ORInvoiceLineModList.Append();
                                ORinvoicemod1.InvoiceLineMod.TxnLineID.SetValue(ORInvoiceLineRet.InvoiceLineRet.TxnLineID.GetValue());
                            }
                        }
                    }

                    //this add the new line
                    if (invoiceItem1.Amount >= 0)
                    {
                        if (invoiceItem1.Amount == 0) {
                            string msg = "Warning: Invoice = $0 for" + szCustomerName;
                            MMSUtility.LogFile(msg, "", "AddModQBInvoice", 0, "QBBatchInvoiceDialog");
                        }

                        IORInvoiceLineMod ORinvoicemod1 = invoiceModRq.ORInvoiceLineModList.Append();
                        ORinvoicemod1.InvoiceLineMod.TxnLineID.SetValue("-1");
                        ORinvoicemod1.InvoiceLineMod.ServiceDate.SetValue(invoiceItem1.Date);
                        ORinvoicemod1.InvoiceLineMod.ItemRef.ListID.SetValue(item1.QuickBooksID);
                        ORinvoicemod1.InvoiceLineMod.Amount.SetValue(invoiceItem1.Amount);
                        ORinvoicemod1.InvoiceLineMod.Quantity.SetValue(invoiceItem1.Quantity);
                        ORinvoicemod1.InvoiceLineMod.Desc.SetValue(invoiceItem1.Description);
                        bItemInvoice1 = true;

                    }
                   

                    //Send the request and get the response from QuickBooks 
                    responseMsgSet = sessionManager.DoRequests(requestMsgSet);
                    response = responseMsgSet.ResponseList.GetAt(0);
                    invoiceRet = (IInvoiceRet)response.Detail;

                    invoice.QuickBooksID = invoiceRet.TxnID.GetValue();
                    invoiceID = invoice.QuickBooksID;

                    int nIndex = invoiceRet.ORInvoiceLineRetList.Count - 1;
                    if (bItemInvoice1)
                        invoiceItem1.QuickBooksID = invoiceRet.ORInvoiceLineRetList.GetAt(nIndex).InvoiceLineRet.TxnLineID.GetValue();

                }

            }
            catch (Exception ex)
            {
                MMSUtility.LogFile(ex.Message, "", "AddModQBInvoice", ex.LineNumber(), "QBBatchInvoiceDialog");
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


    }
}
