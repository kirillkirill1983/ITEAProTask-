using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassTest myClassTest = new MyClassTest();
            MyClass<MyClassTest> myClass = new MyClass<MyClassTest>();
            MyClassTest obj = MyClass<MyClassTest>.FacthoryMethod();
            Console.WriteLine($"{obj.GetType()}");
            
            obj.Name = "beer";
            Console.WriteLine(obj.Name);

            Console.ReadKey();
        }
    }
    class MyClass<T> where T: new()
    {
        public static T FacthoryMethod() 
        {
            return new T() ;
        }
    }

    class MyClassTest
    {
        public MyClassTest() { }
        public string Name { get; set; }
    }
}
