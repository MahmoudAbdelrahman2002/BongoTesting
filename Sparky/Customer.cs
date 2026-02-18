using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    public interface ICustomer
    { 
        int Discount { get; set; }  
        public int OrderTotal { get; set; }
        public bool IsPlatinum { get; set; }
        
        public string GreatMessage { get; set; }
        public string GreatAndCombineNames(string firstName, string lastName);

        public CustomerType GetCustomerType();
       


    }
    public class Customer : ICustomer
    {
        public int Discount { get; set; } = 15;
        public int OrderTotal { get; set; }
        public bool IsPlatinum { get; set; }
        public Customer()
        {
            Discount = 15;
            IsPlatinum = false;


        }
        public string GreatMessage { get; set; }
        public string GreatAndCombineNames(string firstName, string lastName)
        {
            Discount = 20;
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty.");


            }
            
            GreatMessage = $"Hello, {firstName} {lastName}";
            return GreatMessage;
        }
        public CustomerType GetCustomerType()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            else
            {
                return new PlatinumCustomer();
            }
        }
    }
    public class CustomerType { }
    public class BasicCustomer : CustomerType { }
    public class PlatinumCustomer : CustomerType { }
}
