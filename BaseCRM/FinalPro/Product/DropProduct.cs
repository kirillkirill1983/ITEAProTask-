﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPro
{
    class DropProduct : DropCreateDatabaseIfModelChanges<BaseDB>
    {
        protected override void Seed(BaseDB context)
        {
            base.Seed(context);

            //context.Passwords.Add(new Password { PasswordID = 2, Name = "Ira", PasswordEnter = 1567 });
            context.Products.Add(new Product
            {
                ProductID = 1,
                Name = "Chips",
                Price = 12
            });
            context.Products.Add(new Product
            {
                ProductID = 2,
                Name = "ChipsTops",
                Price = 17
            });
        }
    }
}