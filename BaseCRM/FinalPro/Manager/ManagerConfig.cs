using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class ManagerConfig: EntityTypeConfiguration<Manager>
    {
        public ManagerConfig() 
        {
            HasKey(p => p.ManagerID);

            Property(p => p.Name).
                IsRequired().
                HasMaxLength(100).
                HasColumnName("Name");

        }
    }
}
