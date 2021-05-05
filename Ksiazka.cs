using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    class Ksiazka : Pozycja 
    {
        public int liczbaStron { get; set; }


        public Ksiazka() { }
        
        
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string autor)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            this.czyWypozyczona = false;
            this.autor = autor;
        }

       
    }
}
