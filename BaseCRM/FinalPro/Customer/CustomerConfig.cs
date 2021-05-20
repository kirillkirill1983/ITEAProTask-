using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public  class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(p => p.CustomerID);
            
            Property(p => p.Name).IsRequired().HasMaxLength(100);

            Property(p => p.PasswordID).HasColumnName("PasswordID");

            Property(p => p.Adress).HasColumnName("Adress");
           

        }
    
    }
}
