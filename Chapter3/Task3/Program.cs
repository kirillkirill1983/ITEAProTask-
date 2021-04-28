using System;


namespace Task3
{
    class Program
    {
        public delegate int Mydeligate();
        public delegate double ArrayDeligate(Mydeligate[] mydeligates);
        static void Main(string[] args)
        {
            Mydeligate mydeligate1 = new Mydeligate(Method1);
            Mydeligate mydeligate2 = new Mydeligate(Method2);
            Mydeligate mydeligate3 = new Mydeligate(Method3);

            Mydeligate[] mydeligates = new Mydeligate[] { mydeligate1, mydeligate2, mydeligate3 };

            ArrayDeligate arrayDeligate = delegate (Mydeligate[] mydeligates1) 
            {
                int iter = 0;
                int sum= 0;
                for (int i = 0; i < mydeligates1.Length; i++)
                {
                    iter = mydeligates1[i].Invoke();
                    Console.WriteLine($"Число метода {iter}");
                    sum += iter;     // mydeligates1[i].Invoke();
                    Console.WriteLine($"Сумма метода {sum}");
                }
                double len = mydeligates1.Length;
                Console.WriteLine($"Среднее значение {(double)sum/(double)len:f3}");
                return sum / len;
            };
            double result = 0;
            result = arrayDeligate(mydeligates);
            Console.WriteLine($"{result:F3}");

            Console.ReadKey();
        }

        public static int Method1() 
        {
            Random random = new Random();
            int result = random.Next(1, 10);
            return result;
        }

        public static int Method2()
        {
            Random random = new Random();
            int result = random.Next(1, 15);
            return result;
        }

        public static int Method3()
        {
            Random random = new Random();
            int result = random.Next(1, 20);
            return result;
        }
    }
}
