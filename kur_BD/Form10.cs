using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kur_BD
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private Form11 b;
        private void button1_Click(object sender, EventArgs e)
        {
            b = new Form11();
            b.Visible = true;
        }
        private Form12 a;
        private void button2_Click(object sender, EventArgs e)
        {
            a = new Form12();
            a.Visible = true;
        }
        private Form13 c;
        private void button3_Click(object sender, EventArgs e)
        {
            c = new Form13();
            c.Visible = true;
        }
        private Form14 d;
        private void button4_Click(object sender, EventArgs e)
        {
            d = new Form14();
            d.Visible = true;
        }
    }
}
