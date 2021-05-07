using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Order
    {
        public int Id { get; set; }
        public string Quantity{ get; set; }
        public ICollection<Customer> Customers { get; set; }

        public Order()
        {
            Customers = new List<Customer>();

                 
        }
    }

}
