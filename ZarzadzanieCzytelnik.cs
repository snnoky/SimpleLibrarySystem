using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProjektBiblioteka
{
    class ZarzadzanieCzytelnik : IZarzadzanieCzytelnik
    {
        public ObservableCollection<Uzytkownik> uzytkownicy { get; } = new ObservableCollection<Uzytkownik>();
        public Czytelnik czytelnik;
        public ZarzadzanieCzytelnik()
        {
            uzytkownicy = new ObservableCollection<Uzytkownik>();
        }

        public void DodajCzytelnika(string imie, string nazwisko, int nrKarty, int wiek)
        {
            int licznik = 1;

            for (int i = 0; i < uzytkownicy.Count; i++)
            {
                nrKarty = licznik;
                licznik++;
            }

            czytelnik = new Czytelnik(imie,nazwisko,nrKarty,wiek);
            uzytkownicy.Add(czytelnik);

        }

        public string WyszukajCzytelnika(int id)
        {
            int i = 0;
            foreach(var uzytkownik in uzytkownicy)
            {
                if (uzytkownicy[i].nrKarty == id)
                {
                    return uzytkownik.Dane();
                }
                i++;
            }
            return "Nie ma takiego uzytkownika!";
        }
    }
}
