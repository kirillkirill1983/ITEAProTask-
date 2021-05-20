using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class Order
    {
        public int OrderID { get; set; }
        public virtual ICollection<Product> Products  { get; set; }
        public int? ManagerID { get; set; }
        public int? CustomerID { get; set; }
        public  int TotalMount { get; set; }
        public  Customer Customer  { get; set; }
        public Manager Manager { get; set; }


        public Order()
        {
            Products = new List<Product>();
        }
    }
}
