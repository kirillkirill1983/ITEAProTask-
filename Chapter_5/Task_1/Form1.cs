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

namespace Task_1
{
    public partial class Form1 : Form
    {
        private Model1Entities model1Entities;

        public Form1()
        {
            InitializeComponent();
            model1Entities = new Model1Entities();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model1Entities.MyTable.Load();
            dataGridView1.DataSource = model1Entities.MyTable.Local.ToBindingList();
            
        }
    }
}
