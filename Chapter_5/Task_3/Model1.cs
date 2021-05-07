using System;
using System.Data.Entity;
using System.Linq;

namespace Task_3
{
    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }


        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer>  Customers { get; set; }

    }
}

    