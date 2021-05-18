using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = null;

            try
            {
                // Assembly.Load() - метод для загрузки сборки.
                assembly = Assembly.Load("Task_1");
                // LoadFrom(...) - Загрузить по пути
                Console.WriteLine("Сборка CarLibrary - успешно загружена.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            GetInfoAboutAllTypes(assembly);

            //Задержка
            Console.ReadKey();
        }

        #region GetInfoAboutAllTypes - Получения информации о всех типах в сборке.
        /// <summary>
        /// Получения информации о всех типах в сборке.
        /// </summary>
        public static void GetInfoAboutAllTypes(Assembly assembly)
        {
            Console.WriteLine(new string('_', 10));
            Console.WriteLine("\nТипы в: {0} \n", assembly.FullName);

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Полное Имя:             {0}", type.FullName);
                Console.WriteLine("Это class:              {0}", type.IsClass);
            }
        }
        #endregion
    }
}
