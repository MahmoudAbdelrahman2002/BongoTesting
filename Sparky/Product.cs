using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public double GetPrice(Customer customer)
        {
            if (customer.IsPlatinum)
            {
                return price * 0.8; // Platinum customers get a 20% discount
            }
            return price;
        }
        public double GetPrice(ICustomer customer)
        {
            if (customer.IsPlatinum)
            {
                return price * 0.8; // Platinum customers get a 20% discount
            }
            return price;
        }



    }
}
