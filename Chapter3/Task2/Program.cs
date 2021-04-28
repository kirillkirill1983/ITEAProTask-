using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public delegate int MyDeligateInt(int a, int b);
        public delegate double MyDeligteDounle(double a,double b);
        static void Main(string[] args)
        {
            MyDeligateInt myDeligateInt;
            MyDeligteDounle myDeligteDouble;
            int resultInt = 0;
            double resultDouble = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("введите первое число");
                    int oneInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    int twoInput = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите операцию + - / * или Е для выхода" );
                    string s = Console.ReadLine();

                    switch (s)
                    {
                        case "+":
                            myDeligateInt=(x,y)=>x + y;
                            resultInt = myDeligateInt(oneInput, twoInput);
                            Console.WriteLine(resultInt.ToString());
                            break;
                        case "-":
                            myDeligateInt = (x, y) => x - y;
                            resultInt = myDeligateInt(oneInput, twoInput);
                            Console.WriteLine(resultInt.ToString());
                            break;
                        case "*":
                            myDeligateInt = (x, y) => x * y;
                            resultInt = myDeligateInt(oneInput, twoInput);
                            Console.WriteLine(resultInt.ToString());
                            break;
                        case "/":
                            if (oneInput!=0 || twoInput!=0)
                            {
                                double aDouble = (double)oneInput;
                                double bDouble = (double)twoInput;
                                myDeligteDouble = (x, y) => x / y;
                                resultDouble = myDeligteDouble(aDouble, bDouble);
                                Console.WriteLine($"{resultDouble:f3}");
                            }
                            break;
                        case "E":
                            goto Exit;
                        default:
                            Console.WriteLine("Нет такой фугкции");
                            break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Введите число");
                }

            }
        Exit:
            Console.WriteLine("Завершение рабты");

            Console.ReadKey();
        }
        
    }
}
