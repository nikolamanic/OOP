using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace klasaProizvod1
{
    class proizvod
    {
        #region atributi
        string barKod, naziv;
        double cena;
        #endregion

        #region konstruktori
       public proizvod()
        {
            barKod = naziv = String.Empty;
            cena = 0;
        }

        public proizvod(string batKod, string naziv, double cena)
        {
            this.barKod = barKod;
            this.naziv = naziv;
            this.cena = cena;
        }

        public proizvod(proizvod p)
        {
            this.barKod = p.barKod;
            this.naziv = p.naziv;
            this.cena = p.cena;
        }
        #endregion

        #region metode
        public void Citaj(StreamReader f)
        {
            barKod = f.ReadLine();
            naziv = f.ReadLine();
            cena = Convert.ToDouble(f.ReadLine());
        }

        public bool NazivPocinjeNa(string s)
        {
            return naziv.StartsWith(s);
        }

        public override string ToString()
        {
            return barKod + ":" + naziv + ":" + cena.ToString()+"din";
        }

        public double PrikaziCenu()
        {
            return cena;
        }

        public void PromeniCenu(double nova)
        {
            if (nova < 0)
                throw new Exception("greska");
            else
                cena = nova;
        }

        public void Pisi(StreamWriter f)
        {
            f.WriteLine(barKod);
            f.WriteLine(naziv);
            f.WriteLine(cena.ToString());
        }

        public bool SkupljiOd(proizvod p)
        {
            return cena > p.cena;
        }

        #endregion
    }
}
