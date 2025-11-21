using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro                        // Classe Libro
    {
        public string Titolo { get; set; }                                            
        public string Autore { get; set; }
        public string Editore { get; set; }
        public int AnnoDiPubblicazione{ get; set; }
        public int NumeroPagine { get; set; }

        public Libro(string titolo, int numeroPagine, string autore, int annoDiPubblicazione, string editore)  // Costruttore con tutti i parametri 
        {
            Titolo = titolo;
            Autore = autore;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }
        public override string ToString()
        {
            return $"{Titolo} by {Autore}, Published in {AnnoDiPubblicazione}, {Editore}, {NumeroPagine}";
        }
    }
}
