using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    public class DropPassword: DropCreateDatabaseIfModelChanges<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            //context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Ivanov" });
            context.Passwords.Add(new Password { PasswordID =1, Name="Kirill" });

            context.SaveChanges();
        }
    
    }
}
