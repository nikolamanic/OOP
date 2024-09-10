using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stranicaKvadrataa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox3.Text), 2) + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox4.Text), 2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(4 * Math.Sqrt(Math.Pow(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox3.Text), 2) + Math.Pow(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox4.Text), 2)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
