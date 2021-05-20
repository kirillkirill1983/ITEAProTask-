using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class PasswordConfig: EntityTypeConfiguration<Password>
    {
        public PasswordConfig()
        {
            HasKey(p => p.PasswordID);
            Property(p => p.Name).IsRequired().HasMaxLength(100);
            Property(p => p.PasswordEnter);            
            HasOptional(p => p.Customer).WithRequired(ad => ad.Password);
            
        }
    
    }
}
