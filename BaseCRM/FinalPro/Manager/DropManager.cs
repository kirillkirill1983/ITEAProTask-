using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropManager: DropCreateDatabaseIfModelChanges<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            //context.Passwords.Add(new Password { PasswordID = 2, Name = "Ira", PasswordEnter = 1567 });
            context.Managers.Add(new Manager { ManagerID=1, Name="maneger1",OrderLineID=1 });
            context.Managers.Add(new Manager { ManagerID = 2, Name = "maneger2", OrderLineID = 2 });
            context.SaveChanges();
        }
        
    }
}
