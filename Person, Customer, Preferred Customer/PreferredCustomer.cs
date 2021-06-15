using System;
using System.Collections.Generic;
using System.Text;

namespace Person__Customer__Preferred_Customer
{
    class PreferredCustomer : Customer
    {
        private double _purchases;
        private decimal _discount;

        //Default constructor, with null values
        public PreferredCustomer()
        {
            _purchases = 0;
            _discount = 0;
        }

        //Constructor which takes parameters, and fills in base class parameters
        public PreferredCustomer(String name, String address, long number, int custNumber, Boolean mailList, double purchases)
            : base (name, address, number, custNumber, mailList)
        {
            _purchases = purchases;
            _discount = calculateDiscount(purchases);
        }

        //Purchases property getter and setter. Also recalculates the new applicable discount level
        public double Purchases
        {
            get { return _purchases; }
            set 
            {
                _purchases = value;
                _discount = calculateDiscount(value);
            }
        }
        
        //Creates a read only Discount property (only altered when Purchases property is altered)
        public decimal Discount
        {
            get { return _discount; }
        }

        //Method used to calculate the applicable discount level, to increase modularity
        public decimal calculateDiscount(double purchases) 
       
        {
            if (purchases >= 500)
            {
                if (purchases >= 1000)
                {
                    if (purchases >= 1500)
                    {
                        if (purchases >= 2000)
                        {
                            return 0.1m;
                        }
                        else
                        {
                            return 0.07m;
                        }
                    }
                    else
                    {
                        return 0.06m;
                    }
                }
                else
                {
                    return 0.05m;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
