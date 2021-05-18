using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Temperatura
    {
        private int celciy;

        public int Celciy 
        {
            get { return celciy; }
            set { celciy = value; }
        }
        public int Faringeit { get; set; }

        public double ResultFaringeit(int celciy ) 
        {
            
            return (celciy*9/5)+32;

        }
    }
}
