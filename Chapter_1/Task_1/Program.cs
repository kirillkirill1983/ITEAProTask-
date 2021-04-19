using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<int> book = new Book<int>("Book1", 12);
            book.Show();

            Book<double> book1 = new Book<double>("Book2", 15.7);
            book1.Show();

            Console.ReadKey();
        }
    }

    class Book<T>
    {
        private string name;
        private T price;

        public Book(string nName, T pPrice)
        {
            this.name = nName;
            this.price = pPrice;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public T Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Show()
        {
            Console.WriteLine($"{Name} book {Price} price");
        }
    }
}
