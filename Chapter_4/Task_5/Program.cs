using System;


namespace Task_5
{
    delegate dynamic ArraDeligate(dynamic dynamic);
    class Program
    {
        static void Main(string[] args)
        {
            dynamic[] numbers = { "Auto-Aвто","Driver-Водитель","Beer-Пиво","Color-Цвет"};

            ArraDeligate MoreThanTen = delegate (dynamic i) { return i ; };

            var result = (MoreThanTen(numbers));

            foreach (dynamic i in result)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
