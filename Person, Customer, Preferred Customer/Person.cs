using System;
using System.Collections.Generic;
using System.Text;

namespace Person__Customer__Preferred_Customer
{
    class Person
    {
        private string _name, _address;
        private long _phoneNumber;

        //Default constructor, with null values
        public Person()
        {
            _name = null;
            _address = null;
            _phoneNumber = 0;
        }

        //Constructor with user defined values
        public Person(String name, String address, long number)
        {
            _name = name;
            _address = address;
            _phoneNumber = number;
        }
        
        //Name property getter and setter
        public String Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        //Address property getter and setter
        public String Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        //Phone number property getter and setter
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }

    }
}
