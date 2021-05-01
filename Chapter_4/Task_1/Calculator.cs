using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Calculator
    {
       
        public Calculator()
        { }
        

        public dynamic Add(int var1, int var2)
        {
            Console.WriteLine($"{var1} + {var2} = {var1 + var2}");
            return  var1 + var2;
        }
        public dynamic Sub(int var1, int var2)
        {
            Console.WriteLine($"{var1} - {var2} = {var1 - var2}");
            return var1 - var2;
        }
        public dynamic Mult(int var1, int var2)
        {
            Console.WriteLine($"{var1} * {var2} = {var1 * var2}");
            return var1 * var2;
        }
        public dynamic Division(double var1, double var2)
        {
            dynamic result = 0;
            if (var1 != 0 && var2 != 0)
            {
                result = var1 / var2;
                return result;
                Console.WriteLine("{0:F3}", result);
                
            }
            else
                Console.WriteLine("Деление на ноль ");
                return 0;            

        }
    }

}

