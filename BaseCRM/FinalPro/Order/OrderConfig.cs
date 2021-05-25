using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig() 
        {
            this.HasKey<int>(s => s.OrderID);
            this.Property(p => p.TotalMount).HasColumnName("TotalMount");

           
            
            
        }

    }
}
