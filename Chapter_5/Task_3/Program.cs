using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<Model1>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Model1>());
            
            using (Model1 db=new Model1())
            {
                Customer customer1 = new Customer { Id = 1, Name="Kirill", City="Zp"};
                Customer customer2 = new Customer { Id = 2, Name = "Ivan", City = "Zp" };
                Customer customer3 = new Customer { Id = 3, Name = "Sergey", City = "Zp" };
                Customer customer4 = new Customer { Id = 3, Name = "Gleb", City = "Zp" };
                db.Customers.AddRange(new List<Customer> { customer1, customer2, customer3,customer4 });
                db.SaveChanges();
                var customers = db.Customers.ToList();
                foreach (var item in customers)
                {
                    Console.WriteLine("{0}  {1} {2}", item.Id, item.Name,item.City, item.Order );
                }

                Order order1 = new Order { Id = 1, Quantity = "200", Customers = new List<Customer> { customer1, customer3 } };
                Order order2 = new Order { Id = 2, Quantity = "300", Customers = new List<Customer> { customer2, customer4 } };
                db.Orders.AddRange(new List<Order> { order1, order2 });
                db.SaveChanges();
                var orders = db.Orders.ToList();
                foreach (var itemOrder in orders)
                {
                    Console.WriteLine($"{itemOrder.Id} {itemOrder.Quantity}");
                    foreach (var item in itemOrder.Customers)
                    {
                        Console.WriteLine($"{item.Id} {item.Name} {item.City}");
                    }
                }
                Console.ReadKey();
            }

        }

    }
}
