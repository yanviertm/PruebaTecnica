using Biblioteca.Core.Entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Biblioteca.Core.DTOs
{
    public class AutorDto
    {
        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string FechaNacimiento { get; set; }

        public string CiudadProcedencia { get; set; }

        [Required]
        public string CorreoElectronico { get; set; }
    }
}
