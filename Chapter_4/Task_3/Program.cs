using System;
using System.Linq;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRangr = { -2,1, 2, 3, 4, 5, 2, 34, -2, 5656, 212, 4, 5, -67, 34, -6 ,4,5};

            var positiveNums = arrayRangr.Where(i => i >= 0);
            var negativeNums = arrayRangr.Where(i => i < 0);
            var first = positiveNums.First();
            var last = negativeNums.Last();

            Console.WriteLine($"первый положительный {first} " +
                $"последний отрицательный {last}");

            Console.ReadKey();
        }
    }
}
