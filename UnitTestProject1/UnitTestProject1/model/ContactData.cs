using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{//mkmkmkm
    public class ContactData
    {
        private string firstname;
        private string lastname = "";
        private string mobile = "";
        private string email = "";
        private string address = "";

        //private string firstname;
        //private string lastname;
        //private string mobile;
        //private string email;
        //private string address;

        public ContactData(string name)
        {
            this.firstname = name;
        }
        public ContactData(string firstname, string lastname, string mobile, string email, string address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.mobile = mobile;
            this.email = email;
            this.address = address;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }

        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

    }
}






