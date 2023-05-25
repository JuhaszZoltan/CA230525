using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA230525
{
    internal class Eredmeny
    {
        public int Helyezes { get; set; }
        public int SportolokSzama { get; set; }
        public string Sportag { get; set; }
        public string Versenyszam { get; set; }

        //public int OlimpiaiPont
        //{
        //    get
        //    {
        //        if (Helyezes == 1) return 7;
        //        else return 7 - Helyezes;
        //    }
        //}

        public int OlimpiaiPont => Helyezes == 1 ? 7 : 7 - Helyezes;

        public Eredmeny(string sor)
        {
            string[] darabok = sor.Split(' ');
            Helyezes = int.Parse(darabok[0]);
            SportolokSzama = int.Parse(darabok[1]);
            Sportag = darabok[2];
            Versenyszam = darabok[3];
        }
    }
}
