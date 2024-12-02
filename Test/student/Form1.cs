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

namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        student[] S = new student[100];
        StreamReader f = new StreamReader("studenti.txt");
        int n = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (!f.EndOfStream)
            {
                S[n] = new student();
                S[n].Citaj(f);
                n++;
            }
            f.Close();
            for (int i = 0; i < n; i++)
            {
                S[i].Pisi(listBox1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for(int i = 0; i < n; i++)
            {
                if (S[i].Ocena() > 5) S[i].Pisi(listBox3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            for(int i = 0; i < n; i++)
            {
                S[i].IstiIndex(Convert.ToInt32(textBox1.Text)); 
                S[i].Pisi(listBox4);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int index;
            if (textBox1.Text.Equals(String.Empty)) index = 0;
            else index = Convert.ToInt32(textBox1.Text);

            for(int i = 0; i < n; i++)
            {
                if(S[i].IstiIndex(index));
                S[i].Pisi(listBox2);
            }
        }
    }
}
