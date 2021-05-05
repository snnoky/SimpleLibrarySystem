using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    abstract class Pozycja
    {
        public string tytul { get; set; }
        public string wydawnictwo { get; set; }
        public string autor { get; set; }
        public int id { get; set; }
        public int rokWydania { get; set; }
        public bool czyWypozyczona { get; set; }

        
        public Pozycja()
        {

        }
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania, string autor)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.czyWypozyczona = false;
        }

        

    }
}
