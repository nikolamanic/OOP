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

namespace Knjiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        knjiga[] k = new knjiga[100];
        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("knjige.txt");
                while (!f.EndOfStream)
                {
                    k[n] = new knjiga();
                    k[n].Citaj(f);
                    k[n].Pisi(listBox1);
                    n++;
                }
                f.Close();
            }
            catch
            {
                MessageBox.Show("GRESKA");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                //pretraga po godini
                if (radioButton4.Checked)
                {
                    if (!textBox1.Text.Equals(string.Empty))
                    {
                        int god = Convert.ToInt32(textBox1.Text);
                        for(int i = 0; i < n; i++)
                        {
                            if (k[i].godinaIzdanjaJednakaJe(god)) k[i].Pisi(listBox1);
                        }
                    }
                }
                else
                {
                    string s = textBox1.Text;
                    if (radioButton1.Checked)
                    {
                        for(int i = 0; i < n; i++)
                        {
                            if (k[i].imeAutoraPocinjeNa(s)) 
                                k[i].Pisi(listBox1);
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        for(int i = 0; i < n; i++)
                        {
                            if (k[i].nazivIzdavacaPocinjeNa(s))
                                k[i].Pisi(listBox1);
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        for(int i = 0; i < n; i++)
                        {
                            if (k[i].nazivRomanaPocinjeNa(s))
                                k[i].Pisi(listBox1);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("GRESKA");
            }
        }
    }
}
