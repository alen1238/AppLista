using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLista
{
    internal class ListaBiblioteca
    {
        // Propiedades de la clase
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public bool Disponible { get; set; }

        // Constructor
        public ListaBiblioteca(string isbn, string titulo, string autor, string genero, bool disponible)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Disponible = disponible;
        }
    }
    
}
