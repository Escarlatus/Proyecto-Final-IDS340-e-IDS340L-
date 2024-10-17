using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Files
{
    public class Libro
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Año_de_publicacion { get; set; }
        public string Genero { get; set; }
        public int Numero_de_copias { get; set; }


        public Libro (string isbn, string titulo, string autor, string editorial, string año_de_publicacion, string genero, int numero_de_copias)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Año_de_publicacion = año_de_publicacion;
            Genero = genero;
            Numero_de_copias = numero_de_copias;

        }
    }

    


}
