using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Math.Abs(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text));
            int b = Math.Abs(Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox4.Text));
            double stranica = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double obim = 4 * stranica;
            double povrsina = stranica * stranica;
            textBox5.Text = Convert.ToString(obim);
            textBox6.Text = Convert.ToString(povrsina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
