using System;
using System.Data.Entity;
using System.Linq;

namespace FinalPro
{
    public class BaseCRM : DbContext
    {
       
        public BaseCRM()
            : base("name=BaseCRM")
        {
        }

        
    }

}