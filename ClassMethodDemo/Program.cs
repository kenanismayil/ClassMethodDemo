using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musterileri ornekleri(instance) olusturmak
            Customer customer1 = new Customer();
            customer1.Iban = 13812841841;
            customer1.Name = "Tofiq";
            customer1.Surname = "Mammadov";
            customer1.Gender = "Erkek";
            customer1.TcNo = 991432524;
            customer1.Balance = 175.80;

            Customer customer2 = new Customer();
            customer2.Iban = 359825829;
            customer2.Name = "Kenan";
            customer2.Surname = "Ismayil";
            customer2.Gender = "Erkek";
            customer2.TcNo = 99123098292;
            customer2.Balance = 1075.00;

            Customer customer3 = new Customer();
            customer3.Iban = 98235832956;
            customer3.Name = "Kenan";
            customer3.Surname = "Eyvazli";
            customer3.Gender = "Erkek";
            customer3.TcNo = 991424524;
            customer3.Balance = 2005.80;

            //Musterilerin Her Birini Dizi Tanimlayip Icinde Tutmak
            Customer[] customers = new Customer[]
            {
                customer1,
                customer2,
                customer3
            };

            //Her Bir Musterinin Bilgilerini Sirayla Gostermek
            Console.WriteLine("Her Bir Musterinin Bilgilerini Sirayla Gostermek:");
            Console.WriteLine("**************************************************");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Iban);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Gender);
                Console.WriteLine(customer.TcNo);
                Console.WriteLine(customer.Balance);
                Console.WriteLine("--------------------------------------------------");
            }

            //Musterilerin Bankaya Eklenmesi
            Console.WriteLine("Musterilerin Bankaya Eklenmesi");
            Console.WriteLine("*********************************");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("--------------------------------------------------");

            //Musterilerin Listelenmesi
            Console.WriteLine("Musterilerin Listelenmesi:");
            Console.WriteLine("**************************************************");
            foreach (var item in customers)
            {
                customerManager.CustomerList(item);
            }

            Console.WriteLine("--------------------------------------------------");

            //Musterilerin Bankadan Silinmesi
            Console.WriteLine("Musterilerin Bankadan Silinmesi:");
            Console.WriteLine("**************************************************");
            customerManager.Delete(customer3);
            customerManager.Delete(customer1);

            Console.WriteLine("--------------------------------------------------");

            //Operasyonun Sonlanmasi
            Console.WriteLine("Operasyonun Sonlanmasi:");
            Console.WriteLine("**************************************************");
            customerManager.OperationEnd("Operasyon Sonlandi!!!");

            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
        }
    }
}
