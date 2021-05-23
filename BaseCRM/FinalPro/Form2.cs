using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPro
{
    public partial class Form2 : Form
    {
        private BaseDB BaseDB;
        public Form2()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseAlways<BaseDB>());
            Database.SetInitializer(new DropPassword());
            Database.SetInitializer(new DropCustomer());
            Database.SetInitializer(new DropManager());
            Database.SetInitializer(new DropOrder());
            Database.SetInitializer(new DropProduct());
            //BaseDB = new BaseDB();
            //using (var db = new BaseDB())
            //{
            //    var queryOrder = from order in BaseDB.Orders
            //                select order;
            //    var queryProduct = from product in BaseDB.Products
            //                       select product;
            //    //Console.WriteLine(queryProduct);
            //    //Console.WriteLine(queryOrder);
            //    foreach (var item in queryOrder)
            //    {
            //        Console.WriteLine(item.Products);
            //    }
            //    foreach (var item in queryProduct)
            //    {
            //        Console.WriteLine(item.Orders);
            //    }
            //}

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
           
            BaseDB conn = new BaseDB();

            var result = from order in conn.Orders
                         join products in conn.Products on order.OrderID equals products.ProductID

                         select new
                         {
                             Orders = order.OrderID,
                             Name = products.Name,
                             price = products.Price,
                             Maneger = order.ManagerName,
                         };

            dataGridView1.DataSource = result.ToList();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            using (var db=new BaseDB())
            {
                Product product = new Product 
                {   Name = textBox1.Text , 
                    Price =Convert.ToInt32 (textBox2.Text)
                };

                db.Products.Add(product );
                db.SaveChanges();
                

                Order order = new Order()
                {
                    CustomerName = textBox3.Text,
                    ManagerName = textBox4.Text,
                    TotalMount = Convert.ToInt32(textBox5.Text)

                };
                
                db.Orders.Add(order);
                db.SaveChanges();
                dataGridView1.Refresh();
            }
        }
    }
}
