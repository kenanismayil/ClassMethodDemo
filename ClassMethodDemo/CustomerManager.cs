using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} Bankaya Eklendi.");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.Name} {customer.Surname} Bankadan Silindi! ");
        }

        public void OperationEnd(string endMessage)
        {
            Console.WriteLine(endMessage);
        }
    }
}
