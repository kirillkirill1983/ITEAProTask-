using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate double MyDeligate(int a, int v, int c);

        static void Main(string[] args)
        {
            int aInt = 1;
            int bInt = 1;
            int cInt = 2;
            double result = 0;
            MyDeligate myDeligate = delegate (int a, int b, int c) { return ((double)a + (double)b +(double) c) / 3; };
            result = myDeligate(aInt,bInt,cInt);
            Console.WriteLine($"{(double)result:F2}");

            Console.ReadKey();
        }
    }
}
