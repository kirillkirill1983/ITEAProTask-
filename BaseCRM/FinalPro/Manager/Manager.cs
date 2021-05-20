using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public int OrderLineID { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
