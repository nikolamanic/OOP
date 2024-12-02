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

namespace klasaProizvod1
{
    public partial class Form1 : Form
    {
        proizvod[] p = new proizvod[100];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader f = new StreamReader("spisak.txt");
                while (!f.EndOfStream)
                {
                    p[n] = new proizvod();
                    p[n].Citaj(f);
                    listBox1.Items.Add(p[n].ToString());
                    n++;
                }
                f.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message, "GRESKA");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = textBox1.Text;
            for(int i = 0; i < n; i++)
            {
                if (p[i].NazivPocinjeNa(s))
                    listBox1.Items.Add(p[i].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            double pr = 0;
            for (i = 0; i < n; i++)
            {
                pr = pr + p[i].PrikaziCenu();
            }
            pr = pr / n;
            textBox2.Text = "prosecna cena je" + pr.ToString("0.00");
            //textBox2.Text = Convert.ToString(pr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int i;
            double cena1;

            for(i = 0; i < n; i++) 
                if(p[i].PrikaziCenu() > 150)
                {
                    cena1 = 0.9 * p[i].PrikaziCenu();
                    p[i].PromeniCenu(cena1);
                    listBox2.Items.Add(p[i].ToString());
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ukupna = 0, min, max;
            min = max = p[0].PrikaziCenu();
            int i, imin, imax;
            imin = imax = 0;

            for(i = 0; i < n; i++)
            {
                ukupna = ukupna + p[i].PrikaziCenu();
                if (p[i].PrikaziCenu() > max)
                { max = p[i].PrikaziCenu(); imax = i; }
                if (p[i].PrikaziCenu() < min)
                { min = p[i].PrikaziCenu();imin = i; }
            }
            textBox3.Text = "Maksimalna cena je" + max.ToString("0.00") + "a to je proizvod--" + p[imax].PrikaziCenu();
            textBox4.Text = "Minimalna cena je " + min.ToString("0.00") + "a to je proizvod--" + p[imin].PrikaziCenu();
            textBox5.Text = "Ukupna cena je " + ukupna.ToString("0.00");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, br = 0;
            for (i = 0; i < n; i++)
            {
                if (p[i].PrikaziCenu() > 100) br++;
            }
            textBox6.Text = Convert.ToString(br);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string barKod, naziv;
                double cena;
                proizvod p;
                StreamWriter f;
                barKod = textBox7.Text;
                naziv = textBox8.Text;
                cena = Convert.ToDouble(textBox9.Text);
                p = new proizvod(barKod, naziv, cena);
                f = new StreamWriter("spisak1.txt", true);
                p.Pisi(f);
                f.Close();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();

            }

            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                proizvod p, max;
                StreamReader f;
                listBox1.Items.Clear();
                f = new StreamReader("spisak1.txt");
                max = new proizvod();
                listBox1.Items.Add(max.ToString());
                while(!f.EndOfStream)
                {
                    p = new proizvod();
                    p.Citaj(f);
                    listBox1.Items.Add(p.ToString());

                    if(p.SkupljiOd(max)) max = new proizvod (p);
                }
                textBox10.Text = max.ToString();
                f.Close();
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, j;
            proizvod pom;
            listBox3.Items.Clear();
            for(i = 0; i < n - 1; i++)
                for(j = i + 1; j < n; j++)
                    if (p[i].SkupljiOd(p[j]))
                    {
                        pom = p[i];
                        p[i] = p[j];
                        p[j] = pom;
                    }
            for(i = 0; i < n; i++)
            {
                listBox3.Items.Add(p[i].ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
