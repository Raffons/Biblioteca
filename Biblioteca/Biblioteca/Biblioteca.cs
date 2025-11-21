using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public string Nome { get; set; }   
        public string Indirizzo { get; set; }
        public int OrariApertura { get; set; }
        public int OrariChiusura { get; set; }
        public List<Libro> Libri { get; set; } // Lista che contiene i libri della biblioteca 
        public Biblioteca(string nome, string indirizzo, int orariApertura, int orariChiusura) // Costruttore con i parametri nome, indirizzo, orari apertura e chiusura
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrariApertura = orariApertura;
            OrariChiusura = orariChiusura;
            Libri = new List<Libro>();
        }

       
    }
}
