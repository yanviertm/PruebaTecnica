using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Genero { get; set; }
        public int NumeroPaginas { get; set; }

        public int AutorId { get; set; }
    }
}
