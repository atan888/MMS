using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace System.Windows.Forms.MMS
{
    public class Invoice : ModelBase
    {
        private Customer customer;
        private Collection<InvoiceItem> invoiceItems = new Collection<InvoiceItem>();
        private string quickBooksId;
        private string editSequence;

        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (object.ReferenceEquals(customer, value) != true)
                {
                    customer = value;
                    NotifyPropertyChanged("Customer");
                }
            }
        }

        public Collection<InvoiceItem> InvoiceItems
        {
            get { return invoiceItems; }
            set
            {
                if (object.ReferenceEquals(invoiceItems, value) != true)
                {
                    invoiceItems = value;
                    NotifyPropertyChanged("InvoiceItems");
                }
            }
        }

        public string QuickBooksID
        {
            get { return quickBooksId; }
            set
            {
                if (object.ReferenceEquals(quickBooksId, value) != true)
                {
                    quickBooksId = value;
                    NotifyPropertyChanged("QuickBooksID");
                }
            }
        }

        public string EditSequence
        {
            get { return editSequence; }
            set
            {
                if (object.ReferenceEquals(editSequence, value) != true)
                {
                    editSequence = value;
                    NotifyPropertyChanged("EditSequence");
                }
            }
        }
    }
}
