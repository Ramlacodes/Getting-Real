using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerPhone { get; set; }


        public Customer(string customerName, string customerEmail, int customerPhone)
        {
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
        }
    }
}
