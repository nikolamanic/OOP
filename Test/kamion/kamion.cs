using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace kamion
{
    class kamion
    {
        int reg, tezina, duzina;
        string marka;
       

        //konstruktori
        public kamion()
        {
            reg = tezina = duzina = 0;
            marka = string.Empty;
        }

        public kamion(int reg, int tezina, int duzina, string marka)
        {
            this.reg = reg;
            this.tezina = tezina;
            this.duzina = duzina;
            this.marka = marka;

        }

        public kamion(kamion k)
        {
            this.reg = k.reg;
            this.tezina = k.tezina;
            this.duzina = k.duzina;
            this.marka = k.marka;
        }


        //metode
        public void Citaj(StreamReader f)
        {
            reg = Convert.ToInt32(f.ReadLine());
            tezina = Convert.ToInt32(f.ReadLine());
            duzina = Convert.ToInt32(f.ReadLine());
            marka = f.ReadLine();
        }

        public void Pisi(ListBox lb)
        {
            lb.Items.Add(reg);
            lb.Items.Add(tezina);
            lb.Items.Add(duzina);
            lb.Items.Add(marka);
            lb.Items.Add("----------------");
        }


        public int Tezina()
        {
            return tezina;
        }


        public int Duzina()
        {
            return duzina;
        }

     /*   public override string ToString()
        {
            return base.ToString();
        }
     */

    }
}
