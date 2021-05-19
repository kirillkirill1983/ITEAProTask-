using System;
using System.IO;
using System.Text;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"G:\Temp_temp\text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.Unicode)
)
            {
                writer.WriteLine("Привет");

                writer.WriteLine("Мир )) ");

            }

            Console.WriteLine("Файл Text.txt создан и в него записан текст.");

            
            Console.WriteLine("Содержимое файла Text.txt:\n");

            using (StreamReader reader = File.OpenText(@"G:\Temp_temp\text.txt"))
            {
                string input;

                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
           
            Console.ReadKey();
        }
    }
}
