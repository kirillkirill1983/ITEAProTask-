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
            BaseDB = new BaseDB();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BaseDB.Passwords.Load();
            dataGridView1.DataSource = BaseDB.Passwords.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db=new BaseDB())
            {
                Product product = new Product 
                {   Name = textBox1.Text , 
                    Price =Convert.ToInt32 (textBox2.Text)
                };

                db.Products.Add(product );
                //db.SaveChanges();
                //dataGridView1.Refresh();

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
