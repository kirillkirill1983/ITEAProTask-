using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class Product
    {
        public int ProductID { get; set; }
        public  string NameProduct{ get; set; }
        public int PricePosition { get; set; }
        public  virtual ICollection<Order> Orders  { get; set; }
        public Product()
        {
            Orders = new List<Order>();
        }
    }
}
