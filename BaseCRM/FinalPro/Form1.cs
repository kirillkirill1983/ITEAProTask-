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
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            Database.SetInitializer(new DropPassword());
            using (var db = new BaseDB())
            {
                var query = from paswword in db.Passwords
                            select paswword;
                Console.WriteLine(query);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int password = Convert.ToInt32( textBox1.Text);
            string login = textBox2.Text;
            int count = 0;
            int count1 = 0;
            using (var db = new BaseDB())
            {
                var item = db.Passwords.Where(p => p.PasswordEnter == password);
                //count = item.Count();
                //var item2 = db.Passwords.Where(p => p.Name == login);
                //count1 = item2.Count();
                var item2 = item.Where(p => p.Name == login);
                count = item2.Count();
                if (count == 1  )
                {
                    MessageBox.Show("Пользователь Есть");
                    Form2 newForm = new Form2();
                    
                    newForm.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Пользователь НЕТ");
                }
            }
        }
    }
}
