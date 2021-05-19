using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropCreatePassword: DropCreateDatabaseIfModelChanges<BaseCRM>
    {
        protected override void Seed(BaseCRM context)
        {
            base.Seed(context);

            context.Passwords.Add(new Password { PasswordID = 1, Name = "Kirill" });
            context.Passwords.Add(new Password { PasswordID = 2, Name = "Kirill" });
            context.SaveChanges();
        }

    }
}
