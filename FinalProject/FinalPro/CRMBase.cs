using FinalPro.CRMServise;
using System;
using System.Data.Entity;
using System.Linq;

namespace FinalPro
{
    public class CRMBase : DbContext
    {
        
        public CRMBase()
            : base("name=CRMBase")
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