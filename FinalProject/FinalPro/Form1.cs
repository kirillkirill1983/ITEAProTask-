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
        private BaseCRM db;
        public Form1()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseAlways<BaseCRM>());
            db = new BaseCRM();
        }
    }
}
