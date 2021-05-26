using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Tomi");
            dog.Info();
            DogMini dogMini = new DogMini("MomDog");
            Console.ReadKey();
        }
    }

    [Obsolete("Устаревший метод, лучше использовать что-нибудь поновее :)")]
    class Dog 
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dog( string valuename) 
        {
            name = valuename;
        }

        public void Info()
        {
            Console.WriteLine( $"кличка => {this.Name} ");
        }
    }
    //[Obsolete("Устаревший метод, лучше использовать что-нибудь поновее :)", true)]
    class DogMini
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DogMini(string valuename)
        {
            name = valuename;
        }

        public void Info()
        {
            Console.WriteLine($"кличка => {this.Name} ");
        }
    }

}
