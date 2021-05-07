using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private Model1Container model1Container;
        public Form1()
        {
            InitializeComponent();
            model1Container = new Model1Container();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            model1Container.Entity1Set.Add(new Entity1
            {
                Id = 1,
                Name = "kirill",
                City = "Gopa"
            });
            model1Container.Entity1Set.Add(new Entity1
            {
                Id = 2,
                Name = "kirill",
                City = "Gopa"
            });
            dataGridView1.DataSource = model1Container.Entity1Set.Local;
            dataGridView1.Refresh();
        }
    }
}
