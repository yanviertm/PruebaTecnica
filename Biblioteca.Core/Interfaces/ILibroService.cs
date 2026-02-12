using Biblioteca.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Interfaces
{
    public interface ILibroService
    {
        void RegistrarLibro(LibroDto libroDto);
    }
}
