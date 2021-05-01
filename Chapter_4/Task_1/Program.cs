using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); 
            Console.WriteLine("Введите выполяемую арифметическую операцию");
            var operatorEnter = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите первый оператор => ");
            var operatorOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второй оператор => ");
            var operatorTwo = Convert.ToInt32(Console.ReadLine());

            switch (operatorEnter)
            {
                case "+":
                    Console.WriteLine("Операция сложение ");
                    calculator.Add(operatorOne, operatorTwo);
                    break;
                case "-":
                    Console.WriteLine("Операция вычетания ");
                    calculator.Sub(operatorOne, operatorTwo);
                    break;
                case "*":
                    Console.WriteLine($"Операция умножения ");
                    calculator.Mult(operatorOne, operatorTwo);
                    break;
                case "/":
                    Console.WriteLine($"Операция деление");
                    double opoperatorOneDoble = (double)operatorOne;
                    double opoperatorTwoDoble = (double)operatorTwo;
                    calculator.Division(opoperatorOneDoble, opoperatorTwoDoble);

                    break;

                default:
                    Console.WriteLine("Такой операции нет ");
                    break;
            }
            Console.ReadKey();
        }

        
    }
}
