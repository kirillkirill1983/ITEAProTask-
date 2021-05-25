using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Adress { get; set; }
        //public int PasswordID { get; set; }
        //public virtual Password Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
