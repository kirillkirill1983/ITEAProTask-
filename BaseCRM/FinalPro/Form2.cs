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
            //Database.SetInitializer(new DropCreateDatabaseAlways<BaseDB>());
            //Database.SetInitializer(new DropPassword());
            //Database.SetInitializer(new DropCustomer());
            //Database.SetInitializer(new DropManager());
            //Database.SetInitializer(new DropOrder());
            //Database.SetInitializer(new DropProduct());
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

        public static IEnumerable<object> GetResulr()
        {
            BaseDB baseDB =new BaseDB();
            var result = (from order in baseDB.Orders
                          join products in baseDB.Products on order.OrderID equals products.ProductID

                          select new
                          {
                              Orders = order.OrderID,
                              Name = products.Name,
                              price = products.Price,
                              Maneger = order.ManagerName,
                          }).ToList(); 


            return result;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =GetResulr();
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
                GetResulr();
                dataGridView1.DataSource = GetResulr();
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
    }
}
