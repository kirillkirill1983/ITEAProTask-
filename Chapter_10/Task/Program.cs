using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kirill",38);
            person.AgeNew();

            FileStream stream = File.Create("MyData.dat");
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, person);
            stream.Close();

            // Открывает существующий файл для чтения.
            stream = File.OpenRead("MyData.dat");

            // Десериализация.
            Person personDeserialize = formatter.Deserialize(stream) as Person;

            Console.WriteLine(personDeserialize.Age);
            Console.WriteLine(personDeserialize.Name);
            personDeserialize.AgeNew();
            

            Console.ReadKey(); 
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        
        public Person()
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void AgeNew() 
        {
            Console.WriteLine($"{Convert.ToByte(Age)}");
        }
       
    }
}
