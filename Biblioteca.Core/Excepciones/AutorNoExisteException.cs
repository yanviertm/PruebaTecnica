using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Excepciones
{
    public class AutorNoExisteException : Exception
    {
        public AutorNoExisteException()
            : base("El autor no está registrado")
        {
        }
    }
}
