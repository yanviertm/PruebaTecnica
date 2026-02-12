using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Core.DTOs
{
    public class LibroDto
    {
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Año { get; set; }

        [Required]
        public string Genero { get; set; }

        public int NumeroPaginas { get; set; }

        [Required]
        public int AutorId { get; set; }
    }
}
