using FinalPro;
using System;
using System.Data.Entity;
using System.Linq;

namespace FinalPro
{
    public class BaseCRM : DbContext
    {
       
        public BaseCRM()
            : base("name=BaseCRM")
        {
        }
        public virtual DbSet<Password> Passwords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ServisePassword());
        }

    }

}