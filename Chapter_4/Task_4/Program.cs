using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client> 
            {
                new Client {ID_Client =1,Year=1983,Month_number =3, Time_occupation=30 },
                new Client { ID_Client =2,Year=1984, Month_number =5, Time_occupation=60 },
                new Client { ID_Client =3,Year=1983, Month_number =12, Time_occupation=20 },
                new Client { ID_Client =4,Year=1982, Month_number =9, Time_occupation=67 },
            };

            var result = from client in clients
                        select new
                         {
                             time = client.Time_occupation,
                             ID = client.ID_Client, 
                         };
            int min = result.Min(e=>e.time);
            foreach (var item in result)
            {
                if (item.time==min)
                {
                    Console.WriteLine($"Минимальное время {item.time},ID клиента {item.ID}");
                }
            }
           
            Console.ReadKey();
        }
    }
    class Client
    {
        public int ID_Client { get; set; }
        public int Year { get; set; }
        public int Month_number { get; set; }
        public int Time_occupation { get; set; }
    }
}
