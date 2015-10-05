using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Windows.Forms.MMS
{
    public class Item : ModelBase
    {
        private string name;
        private string description;
        private double rate;
        private ItemType itemType;
        private string quickBooksId;
        private string editSequence;
        private string account;

        public string Name
        {
            get { return name; }
            set
            {
                if (object.ReferenceEquals(name, value) != true)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
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

        public double Rate
        {
            get { return rate; }
            set
            {
                if (rate.Equals(value) != true)
                {
                    rate = value;
                    NotifyPropertyChanged("Rate");
                }
            }
        }

        public ItemType ItemType
        {
            get { return itemType; }
            set
            {
                if (itemType.Equals(value) != true)
                {
                    itemType = value;
                    NotifyPropertyChanged("ItemType");
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
        public string Account
        {
            get { return account; }
            set
            {
                if (object.ReferenceEquals(account, value) != true)
                {
                    account = value;
                    NotifyPropertyChanged("Account");
                }
            }
        }
    }

    public enum ItemType
    {
        Inventory,
        Service
    }

}
