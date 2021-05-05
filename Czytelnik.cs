using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    class Czytelnik: Uzytkownik
    {
        public Czytelnik() { }

        public Czytelnik(string imie, string nazwisko, int nrKarty, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrKarty = nrKarty;
            this.wiek = wiek;
        }

        public override string Dane()
        {
            return "Dane: \n"+"Nr Karty: "+nrKarty+"\nImie: "+imie+"\nNazwisko: "+nazwisko+"\nWiek: "+wiek;
        }
    }
}
