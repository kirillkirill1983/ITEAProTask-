using System;
using System.IO;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 150;
            DirectoryInfo directory = new DirectoryInfo(@"G:\Temp_temp");
            if (directory.Exists)
            {
                // Cоздает подкаталог
                // CreateSubdirectory - создает подкаталог по указанному пути
                for (int i = 0; i < 10; i++)
                {
                    string directory_new = $"Folder_{i.ToString()}";
                    DirectoryInfo directoryInfoSubdir = directory.CreateSubdirectory(directory_new);

                    if (directoryInfoSubdir.Exists)
                    {
                        Console.WriteLine(string.Format(@"Директория {0} успешно создана", directoryInfoSubdir.Name));
                        Console.Write(Environment.NewLine);

                        Console.WriteLine("FullName    : {0}", directoryInfoSubdir.FullName);
                        Console.WriteLine("Name        : {0}", directoryInfoSubdir.Name);
                        Console.WriteLine("Parent      : {0}", directoryInfoSubdir.Parent);
                        Console.WriteLine("CreationTime: {0}", directoryInfoSubdir.CreationTime);
                        Console.WriteLine("Attributes  : {0}", directoryInfoSubdir.Attributes.ToString());
                        Console.WriteLine("Root        : {0}", directoryInfoSubdir.Root);

                        Console.Write(Environment.NewLine);
                        Console.WriteLine(new string('-', 30));
                    }
                }
            }
            else
            {
                Console.WriteLine("Директория с именем: {0}  не существует.", directory.FullName);
            }
            Console.WriteLine("Delete Folder");
            Console.ReadKey();
            for (int i = 0; i < 10; i++)
            {
                string directory_new = $"G:\\Temp_temp\\Folder_{i.ToString()}";
                Directory.Delete(directory_new);
            }
            Console.WriteLine("Delete all");
            // Задержка.
            Console.ReadKey();
        }
    }
}
