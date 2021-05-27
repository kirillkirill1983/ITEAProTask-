using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass("Kirill","Pivasovo");
            MyClass myClass2 = new MyClass("Ivan", "Pivasovo");
            MyClass myClass3 = new MyClass("Vadim", "Pivasovo");
            MyClass[] myClasses = new MyClass[] { myClass1, myClass2, myClass3 };
            Pivo pivo = new Pivo(myClasses);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pivo));

            using (FileStream fileStream = new FileStream("SerializerMyClass.xml",
                FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                Console.WriteLine("Серилизация прошла");
                xmlSerializer.Serialize(fileStream,pivo);
            }
            Pivo pivo1;
            using (FileStream fs = new FileStream("SerializerMyClass.xml", FileMode.Open
                ,FileAccess.Read,FileShare.Read))
            {
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pivo));
                pivo1 = xmlSerializer.Deserialize(fs) as Pivo;
                
                foreach (var p in pivo1.MyClass)
                {
                    Console.WriteLine($"Имя: {p.Name} --- Adress: {p.Adress}");
                }
            }
            Console.ReadKey();
        }
    }
    [Serializable]
    [XmlRoot("SeriaMyClass")]
    public class MyClass 
    {
        [XmlAttribute("AtributName")]
        public string Name { get; set; }
        [XmlAttribute("AtributAdress")]
        public string Adress { get; set; }
        
        public MyClass()
        {

        }
        
        public MyClass(string nName,string aAdress)
        {
            this.Name = nName;
            this.Adress = aAdress;
        }
       
        public void Info() 
        {
            Console.WriteLine($"{Name} живет по  {Adress} ");
        }
    }
    [XmlRoot("SeriaMyClaspPIVO")]
    public class Pivo
    {
        //[XmlAttribute("PivoClass")]
        public MyClass[] MyClass { get; set; }
        public Pivo()
        {

        }
        public Pivo(MyClass[] myClass)
        {
            this.MyClass = myClass;
        }

    }

}
