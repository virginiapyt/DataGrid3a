using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid3a
{
    public class Produkt
    {
        public string Symbol { get; set; }
        public string Nazwa { get; set; }
        public string Magazyn { get; set; }
        public int LiczbaSztuk { get; set; }

        public bool Dostepne { get; set; }
        public Uri Zdjecie { get; set; }

        public Produkt(string symbol, string nazwa, string magazyn, 
            int liczbaSztuk, Uri zdjecie)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Magazyn = magazyn;
            LiczbaSztuk = liczbaSztuk;
            Dostepne = true;
            Zdjecie = zdjecie;
        }
    }
}
