using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models
{
    public static class Gym
    {
        private static List<Client> clients;
        
        private static double price;

        static Gym()
        {
            Gym.price = 7500;
            Gym.clients = new List<Client>();       
        }

        public static string MonthIncomes { get { return price.ToString(); } }
        public static string TotalIncomes { get { return CalculateTotalIncomes().ToString(); } }

        public static double TotalClients { get { return ClientBusiness.GetClients().Count(); } }

        public static double CalculateTotalIncomes() => Gym.price * TotalClients;         

        public static void enterClient(Client client)
        {           
            if (!clients.Contains(client))
            {
                clients.Add(client);
            }
        } 
    }
}
