using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App
{
    class Contact
    {
        private string nameInput;
        private string phoneNumber;

        public Contact(string nameInput, string phoneNumber)

        {
            this.nameInput = nameInput;
            this.phoneNumber = phoneNumber;
        }
        public string NameInput
        {
            get
            {
                return nameInput;
            }
            set
            {
                nameInput = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
  

    }
}
