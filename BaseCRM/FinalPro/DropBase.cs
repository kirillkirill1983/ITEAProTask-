using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropBase :DropCreateDatabaseAlways<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            context.Passwords.Add(new Password { PasswordID = 1, Name = "Kirill", PasswordEnter = 123 });

            context.Customers.Add(new Customer { CustomerID = 1, Name = "Ivan2", Adress = 69125});

            context.Managers.Add(new Manager { ManagerID = 1, Name = "maneger1", });
            
            context.Orders.Add(new Order
            {
                OrderID = 1,
                TotalMount = 5
            });
            context.Products.Add(new Product
            {
                ProductID = 1,
                NameProduct = "Chips",
                PricePosition = 12
            });
            context.SaveChanges();
        }

    }

    
}
