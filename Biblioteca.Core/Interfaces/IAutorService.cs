using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Interfaces
{
    public interface IAutorService
    {
        void RegistrarAutor(AutorDto autorDto);
        bool ExisteAutor(int autorId);
        IEnumerable<Autor> ObtenerAutores();
    }
}
