using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Windows.Forms.MMS
{
    public class Customer : ModelBase
    {
        private string name = "";
        private string firstname = "";
        private string lastname = "";
        private string address = "";
        private string city = "";
        private string state = "";
        private string zip = "";
        private string email = "";
        private string phone = "";
        private string company = "";
        private string terms = "Net 30";
        private string quickBooksId = "";
        private string editSequence = "";
        private bool active = true;

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
        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (object.ReferenceEquals(firstname, value) != true)
                {
                    firstname = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return lastname; }
            set
            {
                if (object.ReferenceEquals(lastname, value) != true)
                {
                    lastname = value;
                    NotifyPropertyChanged("LastName");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (object.ReferenceEquals(address, value) != true)
                {
                    address = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (object.ReferenceEquals(city, value) != true)
                {
                    city = value;
                    NotifyPropertyChanged("City");
                }
            }
        }
        public string State
        {
            get { return state; }
            set
            {
                if (object.ReferenceEquals(state, value) != true)
                {
                    state = value;
                    NotifyPropertyChanged("State");
                }
            }
        }
        public string Zip
        {
            get { return zip; }
            set
            {
                if (object.ReferenceEquals(zip, value) != true)
                {
                    zip = value;
                    NotifyPropertyChanged("Zip");
                }
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (object.ReferenceEquals(phone, value) != true)
                {
                    phone = value;
                    NotifyPropertyChanged("Phone");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (object.ReferenceEquals(email, value) != true)
                {
                    email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }
        public string Company
        {
            get { return company; }
            set
            {
                if (object.ReferenceEquals(company, value) != true)
                {
                    company = value;
                    NotifyPropertyChanged("Company");
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
        public bool Active
        {
            get { return active; }
            set
            {
                if (object.ReferenceEquals(active, value) != true)
                {
                    active = value;
                    NotifyPropertyChanged("Active");
                }
            }
        }
        public string Terms
        {
            get { return terms; }
            set
            {
                if (object.ReferenceEquals(terms, value) != true)
                {
                    terms = value;
                    NotifyPropertyChanged("Terms");
                }
            }
        }
    }
}
