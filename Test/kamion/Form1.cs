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

namespace kamion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        kamion[] k = new kamion[100];
        StreamReader f = new StreamReader("kamion.txt");
        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("kamion.txt");
            while (!f.EndOfStream)
            {
                k[n] = new kamion();
                k[n].Citaj(f);
                n++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
           /* for(int i = 0; i < n - 1; i++)
            {
                if(Convert.ToInt32(k[i].Tezina) > Convert.ToInt32())
            }
            */

           
            for(int i = 0; i < n; i++)
            {
                k[i].Pisi(listBox1);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox2.Items.Clear();
                for (int i = 0; i < n; i++)
                {
                    if (Convert.ToInt32(k[i].Tezina()) > 5) k[i].Pisi(listBox2);
                }
            }
            else if (radioButton2.Checked)
            {
                listBox2.Items.Clear();
                for(int i = 0; i < n; i++)
                {
                    if (Convert.ToInt32(k[i].Duzina()) > 10) k[i].Pisi(listBox2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
