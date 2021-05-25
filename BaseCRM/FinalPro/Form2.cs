using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPro
{
    public partial class Form2 : Form
    {
        //private BaseDB BaseDB;
        public Form2()
        {
            InitializeComponent();
           
        }

        public static IEnumerable<object> GetResulr(string client)
        {
            BaseDB baseDB =new BaseDB();
            //var result = (
            //    from order in baseDB.Orders
            //              join products in baseDB.Products on order.OrderID equals products.ProductID

            //              select new
            //              {
            //                  Orders = order.OrderID,
            //                  Name = products.Name,
            //                  price = products.Price,
            //                  Maneger = order.ManagerName,
            //              }).ToList(); 
            
            var result = (from customer in baseDB.Customers
                          join order in baseDB.Orders on customer.CustomerID equals order.OrderID 
                          join product in baseDB.Products on order.OrderID equals product.ProductID
                          where (customer.Name==client)
                select new
                {
                    Customer=customer.Name,
                    Orders = order.OrderID,
                    Name = product.NameProduct,
                    price = product.PricePosition
                    
                }).ToList();

            return result;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string client = textBox4.Text;
            dataGridView1.DataSource =GetResulr(client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            using (var db=new BaseDB())
            {
                Product product = new Product 
                {    NameProduct = textBox1.Text , 
                     PricePosition =Convert.ToInt32 (textBox2.Text)
                };

                db.Products.Add(product );
                db.SaveChanges();
                
                Customer customer = new Customer
                {
                    Name = textBox3.Text,
                };

                db.Customers.Add(customer);
                db.SaveChanges();
                
                Order order = new Order()
                {
                    TotalMount = Convert.ToInt32(textBox5.Text)

                };

                string client = textBox4.Text;
                db.Orders.Add(order);
                db.SaveChanges();
                GetResulr(client);
                dataGridView1.DataSource = GetResulr(client);
                dataGridView1.Refresh();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string file = "c:\\mygrid.txt";
            FileStream file = File.Open(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter bw = new StreamWriter(file))
            {
                //bw.Write(dataGridView1.Columns.Count);
                bw.Write(dataGridView1.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridView1.Rows)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string client = textBox4.Text;
            dataGridView1.DataSource = GetResulr(client);
        }
    }
}
