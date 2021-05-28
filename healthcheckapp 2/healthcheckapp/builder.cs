using System;
using System.Collections.Generic;
using System.Text;

namespace healthcheckapp
{
    public class Account
    {
        private string Name;
        private string Address;
        private string Mail;
        private string Phone;
        public Account(string Name, string Address, string Mail, string Phone)
        {
            this.Name = Name;
            this.Address = Address;
            this.Mail = Mail;
            this.Phone = Phone;
        }
        public class AccountBuilder
        {
            private string Name;
            private string Address;
            private string Mail;
            private string Phone;
            public AccountBuilder(string Name)
            {
                this.Name = Name;
            }
            public AccountBuilder withAddress(string Address)
            {
                this.Address = Address;
                return this;
            }
            public AccountBuilder withMail(string Mail)
            {
                this.Mail = Mail;
                return this;
            }
            public AccountBuilder withPhone(string Phone)
            {
                this.Phone = Phone;
                return this;
            }
            public Account build()
            {
                validateUserObject();
                Account account = new Account(this.Name, this.Address, this.Mail, this.Phone);
                return account;
            }
            private void validateUserObject()
            {
                if (this.Mail == null)
                {
                    //Message mail cannot be null
                }

            }
        }
        public override string ToString()
        {
            return "Account name= " + this.Name + " account Address= " + this.Address + " account Mail= " + this.Mail + " account Phone= " + this.Phone;
        }
    }
}
