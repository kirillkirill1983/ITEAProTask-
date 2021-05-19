using System;
using System.IO;
using System.IO.Compression;

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

                FileStream source = File.OpenRead(path);
                FileStream destination = File.Create(@"G:\Temp_temp\archive.zip");
                using (GZipStream compressor = new GZipStream(destination, CompressionMode.Compress))
                {
                    // Заполнение архива информацией из файла.
                    int theByte = source.ReadByte();

                    while (theByte != -1)
                    {
                        compressor.WriteByte((byte)theByte);
                        theByte = source.ReadByte();
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
