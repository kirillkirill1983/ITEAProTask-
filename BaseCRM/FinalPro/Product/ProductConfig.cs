using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class ProductConfig: EntityTypeConfiguration<Product>
    {
        public ProductConfig() 
        {
            this.HasKey<int>(p => p.ProductID);
            this.Property(p => p.NameProduct).HasMaxLength(50).HasColumnName("NameProduct");
            this.Property(p => p.PricePosition).HasColumnName("PricePosition");

            this.HasMany<Order>(s => s.Orders).
                WithMany(c => c.Products).
                Map(cs =>
                {
                    cs.MapLeftKey("ProductID");
                    cs.MapRightKey("OrderID");
                    cs.ToTable("ProductOrder");
                });


              
        }
    }
}
