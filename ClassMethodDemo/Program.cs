using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Name = "Kenan";
            client1.Surname = "Ismayil";
            client1.Id = 991924903;
            client1.Balance = 258.50;

            Client client2 = new Client();
            client2.Name = "Engin";
            client2.Surname = "Demirog";
            client2.Id = 994526775;
            client2.Balance = 0;

            Client client3 = new Client();
            client3.Name = "Berkay";
            client3.Surname = "Bilgin";
            client3.Id = 994689949;
            client3.Balance = 450;

            Client[] clients = new Client[] { client1, client2, client3 };

            Console.WriteLine("Clients List:");
            Console.WriteLine("-----------------------");

            foreach (var client in clients)
            {
                Console.WriteLine("Name : " + client.Name);
                Console.WriteLine("Surname : " + client.Surname);
                Console.WriteLine("Id : " + client.Id);
                Console.WriteLine("Balance : " + client.Balance);

                Console.WriteLine("-----------------------");
            }

            ClientManager operation = new ClientManager();
            operation.ClientAdd("Mustafa Balkan");
            operation.ClientAdd("Arif Ozkaya");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Clients are Listing...");
            operation.ClientList(client1);
            operation.ClientList(client2);
            operation.ClientList(client3);

            Console.WriteLine("----------------------");

            operation.ClientDelete(client1);
            operation.ClientDelete(client2);
            operation.ClientDelete(client3);

            Console.WriteLine("----------------------");

            operation.OperationEnd("Operations ended");

            Console.ReadLine();
        }
    }
}
