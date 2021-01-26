using System;
using System.Collections.Generic;
using System.Text;

namespace GameOperitons
{
    class CustomerManager
    {
        public void Add(Customer customer1)
        {
            Console.WriteLine(customer1.CustomerNumber, customer1.CustomerName,customer1.CustomerLastName,customer1.CustomerSocialSecurity + "Kullanıcı Sisteme Eklendi");
        }
    }
}
