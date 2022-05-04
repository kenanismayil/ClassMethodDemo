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

        public void CustomerList(params Customer[] customer)
        {
            foreach (var item in customer)
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }

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
