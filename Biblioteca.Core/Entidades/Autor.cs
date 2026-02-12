using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaNacimiento { get; set; }
        public string CiudadProcedencia { get; set; }
        public string CorreoElectronico { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
