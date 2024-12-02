using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace student
{
    class student
    {
        //atributi
        int brIn, ocena;
        string ime, prezime, predmet;
        

        //konstruktori

        public student()
        {
            ime = prezime = predmet = string.Empty;
            brIn = ocena = 0;
        }

        public student(string ime, string prezime, string predmet, int ocena, int brIn)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.predmet = predmet;
            this.ocena = ocena;
            this.brIn = brIn;
        }

        public student(student s)
        {
            this.ime = s.ime;
            this.prezime = s.prezime;
            this.predmet = s.predmet;
            this.ocena = s.ocena;
            this.brIn = s.brIn;
        }



        //metode
        /*    public void Citaj(StreamReader f)
          {
               ime = f.ReadLine();
               prezime = f.ReadLine();
               predmet = f.ReadLine();
               ocena = Convert.ToInt32(f.ReadLine());
               brIn = Convert.ToInt32(f.ReadLine());
           }*/
        public void Citaj(StreamReader f)
        {
            brIn = Convert.ToInt32(f.ReadLine());
            ime = f.ReadLine();
            prezime = f.ReadLine();
            predmet = f.ReadLine();
            ocena = Convert.ToInt32(f.ReadLine());
        }


        public void Pisi(ListBox lb)
        {
            lb.Items.Add(ime);
            lb.Items.Add(prezime);
            lb.Items.Add(predmet);
            lb.Items.Add(Convert.ToString(ocena));
            lb.Items.Add(Convert.ToString(brIn));
        }


        public int Ocena()
        {
            return ocena;
        }



        public bool IstiIndex(int index)
        {
            return brIn == index;
        }

    }
}
