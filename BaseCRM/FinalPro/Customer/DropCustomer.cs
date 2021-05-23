using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropCustomer: DropCreateDatabaseIfModelChanges<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            //context.Passwords.Add(new Password { PasswordID = 2, Name = "Ira", PasswordEnter = 1567 });
            context.Customers.Add(new Customer { CustomerID=1, Name="Ivan", Adress=69124, PasswordID=1  });
            context.Customers.Add(new Customer { CustomerID = 1, Name = "Ivan2", Adress = 69125, PasswordID = 2 });
            context.SaveChanges();
        }
    
    }
}
