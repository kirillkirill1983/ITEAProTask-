using System;

using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        DateTime date1 = new DateTime(0, 0);
        public Form1()
        {
            InitializeComponent();
            
            timer1.Tick += timer1_Tick;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddMilliseconds(1);
            textBox1.Text = date1.ToString("mm:ss:ff");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            date1 = new DateTime(0, 0);
            textBox1.Text = date1.ToString("mm:ss:ff");
            timer1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
