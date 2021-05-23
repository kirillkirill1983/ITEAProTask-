using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropOrder: DropCreateDatabaseIfModelChanges<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            //context.Passwords.Add(new Password { PasswordID = 2, Name = "Ira", PasswordEnter = 1567 });
            context.Orders.Add(new Order { OrderID=1, ManagerName= "maneger1",
                CustomerName ="Ivan" , TotalMount=5});
            context.Orders.Add(new Order
            {
                OrderID = 2,
                ManagerName = "maneger2",
                CustomerName = "Kirill",
                TotalMount = 7,
            }); ;
            context.SaveChanges();
        }
    
    }
}
