using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic[] logic = new Logic[3];

            logic[0] = new Manager();
            logic[1] = new Programmer();
            logic[2] = new Director();

            for (int i = 0; i < logic.Length; i++)
            {
                Console.WriteLine("Проверка доступа Работника: {0} к секретному методу", logic[i].GetType().Name);
                Type type = logic[i].GetType();
                object[] attributes = type.GetCustomAttributes(false);

                foreach (AccessLevelAttribute att in attributes)
                {
                    if (att.Level == 0) Console.WriteLine("Отказано");
                    if (att.Level == 1) Console.WriteLine("Неполный доступ");
                    if (att.Level == 2)
                    {
                        Console.WriteLine("Доступ разрешен");
                        logic[i].TopSecret();
                    }
                }
                Console.WriteLine(new string('*', 80));
            }
            Console.ReadKey();
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class AccessLevelAttribute : Attribute
    {

        public int Level { get; set; }
        public AccessLevelAttribute(int level)
        {
            this.Level = level;
        }
    }
    public class Logic
    {
        public void TopSecret()
        {
            Console.WriteLine("Доступ есть");
        }
    }
    [AccessLevel(0)]
    class Manager : Logic { }

    [AccessLevel(level: 1)]
    class Programmer : Logic { }

    [AccessLevel(level: 2)]
    class Director : Logic { }
}
