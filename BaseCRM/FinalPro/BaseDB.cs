using System;
using System.Data.Entity;
using System.Linq;

namespace FinalPro
{
    public class BaseDB : DbContext
    {
       
        public BaseDB()
            : base("name=BaseDB")
        {
        }


        public virtual DbSet<Password>  Passwords { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Manager>  Managers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new PasswordConfig());
            modelBuilder.Configurations.Add(new CustomerConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new ManagerConfig());
        }
    }

    
}