using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Temperatura
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        public int Result() 
        {
            return MyProperty1 + MyProperty2;
        }
    }
}
