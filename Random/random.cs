using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novirandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "random";
            Width = 500;
            Height = 500; 
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Width = r.Next(300, 500);
            Height = r.Next(200, 500);
            this.Text = "Koordinate su (" + e.X + "," + e.Y + ")";
        }
    }
}
