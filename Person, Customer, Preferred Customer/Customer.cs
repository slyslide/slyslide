using System;
using System.Collections.Generic;
using System.Text;

namespace Person__Customer__Preferred_Customer
{
    class Customer : Person
    {
        private int _customerNumber;
        private Boolean _mailingList;

        //Default constructor, with null values
        public Customer()
        {
            _customerNumber = 0;
            _mailingList = false;
        }

        //Constructor which takes parameters, and fills in base class parameters
        public Customer(String name, String address, long number, int custNumber, Boolean mailList) 
            : base(name, address, number)
        {
            _customerNumber = custNumber;
            _mailingList = mailList;
        }

        //Customer number property getter and setter
        public int CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        //Mailing list property getter and setter
        public Boolean MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }
    }
}
