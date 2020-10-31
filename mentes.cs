using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regisztracios_alkalmazas
{
    class mentes
    {
        private string nev;
        private string nem;
        private string[] hobbi;
        private string khobbi;
        private DateTime szul;

        public mentes(string nev, string nem, string[] hobbi, string khobbi, DateTime szul)
        {
            this.nev = nev;
            this.nem = nem;
            this.hobbi = hobbi;
            this.khobbi = khobbi;
            this.szul = szul;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public string[] Hobbi { get => hobbi; set => hobbi = value; }
        public string Khobbi { get => khobbi; set => khobbi = value; }

        public DateTime Szul { get => szul; set => szul = value; }

    }
}
