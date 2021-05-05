using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektBiblioteka
{
    class ZarzadzanieKsiazki 
    {
        
        public ObservableCollection<Pozycja> pozycje { get; } = new ObservableCollection<Pozycja>();
        public Ksiazka ksiazka;
        public ZarzadzanieKsiazki()
        {
            pozycje = new ObservableCollection<Pozycja>();
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string autor)
        {
            int licznik = 1;
           
            for (int i = 0; i < pozycje.Count; i++)
            {
                id = licznik;
                licznik++;
            }

            ksiazka = new Ksiazka(tytul, id, wydawnictwo, rokWydania, liczbaStron, autor);
            pozycje.Add(ksiazka);
            
        }

        public void WypozyczKsiazke(int id)
        {

            for (int i = 0; i < pozycje.Count; i++)
            {
                if (pozycje[i].id == id)
                {
                    if (pozycje[i].czyWypozyczona == false)
                    {
                        pozycje[i].czyWypozyczona = true;
                    }
                }
            }
        }

        public void OddajKsiazke(int id)
        {
            for (int i = 0; i < pozycje.Count; i++)
            {
                if (pozycje[i].id == id)
                {
                    if (pozycje[i].czyWypozyczona == true)
                    {
                        pozycje[i].czyWypozyczona = false;
                    }
                }
            }
        }
        
    }
}
