using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Excepciones
{
    public class MaximoLibrosException : Exception
    {
        public MaximoLibrosException()
            : base("No es posible registrar el libro, se alcanzó el máximo permitido.")
        {
        }
    }
}
