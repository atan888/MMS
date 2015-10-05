using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Windows.Forms.MMS
{
    public class InvoiceItem : ModelBase
    {
        private Item item;
        private double amount;
        private int quantity;
        private string description;
        private string quickBooksId;
        private DateTime date;

        public Item Item
        {
            get { return item; }
            set
            {
                if (object.ReferenceEquals(item, value) != true)
                {
                    item = value;
                    NotifyPropertyChanged("Item");
                }
            }
        }
        public double Amount
        {
            get { return amount; }
            set
            {
                if (amount.Equals(value) != true)
                {
                    amount = value;
                    NotifyPropertyChanged("Amount");
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
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (object.ReferenceEquals(item, quantity) != true)
                {
                    quantity = value;
                    NotifyPropertyChanged("Quantity");
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (object.ReferenceEquals(description, value) != true)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (object.ReferenceEquals(date, value) != true)
                {
                    date = value;
                    NotifyPropertyChanged("Date");
                }
            }
        }
    }
}
