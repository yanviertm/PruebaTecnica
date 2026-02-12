using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Core.Excepciones
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }
    }
}
