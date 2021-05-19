using System;
using System.IO;


namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string catalog = @"G:\Temp_temp";

            string fileName = "text1.txt";

            //проводим поиск в выбранном каталоге и во всех его подкаталогах
            string path = null;
            foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName,
                SearchOption.AllDirectories))
            {
                FileInfo FI= new FileInfo(findedFile);
                Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
                        " Создан: " + FI.CreationTime);
                path = FI.FullName;
            }
            
            if (path != null)
            {
                
                using (StreamReader reader = File.OpenText(path))
                {
                    string input;

                    while ((input = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
            else
            {
                Console.WriteLine("Файла нет");
            }
            Console.ReadKey();
        }
    }
}
