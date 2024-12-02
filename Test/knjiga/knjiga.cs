using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Knjiga
{
    class knjiga
    {
        //atributi
        string autor, naziv, izdavac;
        int god;

        //konstruktori 
        public knjiga()
        {
            autor = naziv = izdavac = string.Empty;
            god = 0;
        }

        public knjiga(string autor, string naziv, string izdavac, int god)
        {
            this.naziv = naziv;
            this.autor = autor;
            this.izdavac = izdavac;
            this.god = god;
        }

        public knjiga(knjiga k)
        {
            this.naziv = k.naziv;
            this.autor = k.autor;
            this.izdavac = k.izdavac;
            this.god = k.god;
        }
        
        //metode
        public void Citaj(StreamReader f)
        {
            naziv = f.ReadLine();
            autor = f.ReadLine();
            izdavac = f.ReadLine();
            god = Convert.ToInt32(f.ReadLine());
        }

        public bool imeAutoraPocinjeNa(string s)
        {
            return autor.ToLower().StartsWith(s.ToLower()); 
        }

        public bool nazivRomanaPocinjeNa(string s)
        {
            return naziv.ToLower().StartsWith(s.ToLower());
        }

        public bool nazivIzdavacaPocinjeNa(string s)
        {
            return izdavac.ToLower().StartsWith(s.ToLower());
        }

        public bool godinaIzdanjaJednakaJe(int god)
        {
            return (this.god == god);
        }

        public override string ToString()
        {
            return autor + ":" + naziv;
        }

        public void Pisi(ListBox lb)
        {
            lb.Items.Add(ToString());
            lb.Items.Add(izdavac);
            lb.Items.Add(god.ToString());
            lb.Items.Add("----------------------");
        }

    }
}
