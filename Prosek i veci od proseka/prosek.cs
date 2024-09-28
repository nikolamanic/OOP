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

namespace Ispis_plata_radnika_vecih_od_proseka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<Double> L = new List<double>();
            try
            {
                StreamReader f = new StreamReader("TextFile1.txt");
                int b = 0;
                double P = 0, a;
                while (!f.EndOfStream)
                {
                    a = Convert.ToDouble(f.ReadLine());
                    L.Add(a);
                    listBox1.Items.Add(Convert.ToString(a));
                    P = P + a;
                    b++;
                }

                P = P / b;
                textBox1.Text = Convert.ToString(P);
                for (int i = 0; i < L.Count; i++)
                {
                    if (L[i] > P) listBox2.Items.Add(Convert.ToString(L[i]));
                }
                f.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
