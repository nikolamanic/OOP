using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            try
            {
                int r = x / y;
                textBox3.Text = Convert.ToString(r);
            }
            catch
            {
                textBox3.Text = "GRESKA";
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int r = x + y;
            textBox3.Text = Convert.ToString(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
                int r = x - y;
                textBox3.Text = Convert.ToString(r);
            

       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int r = x * y;
            textBox3.Text = Convert.ToString(r);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
