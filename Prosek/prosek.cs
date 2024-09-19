using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prosek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Prosek";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int z = 0;
                int b = 0;
                StreamReader f = new StreamReader("file.txt");
                while (!f.EndOfStream)
                {
                    int br = Convert.ToInt32(f.ReadLine());
                    z = z + br;
                    b++;
                }
                z = z / b;
                textBox1.Text = Convert.ToString(z);
                f.Close();
            }
            catch(Exception izuzetak) {
                MessageBox.Show(izuzetak.Message);
            
            }
        }
    }
}
