using System;

namespace GameOperitons
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerNumber = "1";
            customer1.CustomerName = "Dilan";
            customer1.CustomerLastName = "Duman";
            customer1.CustomerSocialSecurity = "12345678910";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }
    }
}
