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


            context.Customers.Add(new Customer { CustomerID = 1, Name = "Ivan2", Adress = 69125, PasswordID = 2 });
            context.Managers.Add(new Manager { ManagerID = 1, Name = "maneger1", OrderLineID = 1 });
            context.Passwords.Add(new Password { PasswordID = 1, Name = "Kirill", PasswordEnter = 123 });
            context.Orders.Add(new Order
            {
                OrderID = 1,
                ManagerName = "maneger1",
                CustomerName = "Ivan",
                TotalMount = 5
            });
            context.Products.Add(new Product
            {
                ProductID = 1,
                Name = "Chips",
                Price = 12
            });
            context.SaveChanges();
        }

    }

    
}
