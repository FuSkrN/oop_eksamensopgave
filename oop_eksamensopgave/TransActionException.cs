using System;
using System.Collections.Generic;
using System.Text;

namespace oop_eksamensopgave
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(User user, Product product){ }
    }
}
