using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int, int> calculator = new Calculator<int, int>() { InitOne = 2, InitTwo = 3 };
            Console.WriteLine(calculator.ToString());
            double resultPlus = calculator.Plus();
            Console.WriteLine("Plus {0}", resultPlus.ToString());
            double resultMinus = calculator.Minus();
            Console.WriteLine("Minus {0}", resultMinus.ToString());
            Console.WriteLine("Div {0:F3}", calculator.Div());
            Console.WriteLine("Mult {0}", calculator.Mult());
            Console.WriteLine("_________________");
            Calculator<double, double> calculator1 = new Calculator<double, double>(3.5, 2.5);
            Console.WriteLine(calculator1.ToString());
            Console.WriteLine("Minus {0}", calculator1.Minus());
            Console.WriteLine("Div {0:F3}", calculator1.Div());
            Console.WriteLine("Mult {0}", calculator1.Mult());

            Console.ReadKey();
        }
    }

    class Calculator<T1, T2>
    {

        public T1 InitOne { get; set; }
        public T2 InitTwo { get; set; }
        public Calculator() { }
        public Calculator(T1 init1, T2 init2)
        {
            this.InitOne = init1;
            this.InitTwo = init2;
        }

        public double Plus()
        {
            return Convert.ToDouble(InitOne) + Convert.ToDouble(InitTwo);
        }

        public double Minus()
        {
            return Convert.ToDouble(InitOne) - Convert.ToDouble(InitTwo);
        }

        public double Div()
        {
            return Convert.ToDouble(InitOne) / Convert.ToDouble(InitTwo);
        }

        public double Mult()
        {
            return Convert.ToDouble(InitOne) * Convert.ToDouble(InitTwo);
        }


        public override string ToString()
        {
            return $"{InitOne} + {InitTwo}";
        }
    }
}
