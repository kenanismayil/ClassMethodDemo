using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void ClientAdd(string client)
        {
            Console.WriteLine("Clients are added : " + client);
        }

        public void ClientList(Client clientName)
        {
            Console.WriteLine(clientName.Name);
        }

        public void ClientDelete(Client delete)
        {
            Console.WriteLine("Clients are deleted : " + delete.Name);
        }

        public void OperationEnd(string end)
        {
            Console.WriteLine(end);
        }
    }
}
