using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalPro
{
    public class Password
    {
        public int PasswordID { get; set; }
        public string Name { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
