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

        public void AggiungiLibro(Libro libro) // Metodo per aggiungere un libro alla biblioteca
        {
            Libri.Add(libro);
        }
        public void RimuoviLibro(Libro libro) // Metodo per rimuovere un libro dalla biblioteca
        {
            Libri.Remove(libro);
        }
        
        public void NumeroLibri() // Metodo per contare il numero di libri presenti nella biblioteca
        {
            Console.WriteLine($"Numero dei libri presenti nella biblioteca: {Libri.Count}");
        }
    }
}
