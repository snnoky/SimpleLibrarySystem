using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    abstract class Uzytkownik
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int nrKarty { get; set; }
        public int wiek { get; set; }
        


        public Uzytkownik()
        {
        }
        public Uzytkownik(string imie, string nazwisko, int nrKarty, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrKarty = nrKarty;       
            this.wiek = wiek;
            
        }

        abstract public string Dane(); 
    }
}
