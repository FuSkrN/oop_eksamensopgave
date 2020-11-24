using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    public class ProductNotAvailableException : Exception
    {
        public ProductNotAvailableException(string message) : base(message) { }
    }
}
