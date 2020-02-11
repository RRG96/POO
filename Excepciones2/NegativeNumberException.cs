using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones2
{
    class NegativeNumberException  : Exception
    {
        public NegativeNumberException() : base("Attempt to use a negative number for operation") { }
        public NegativeNumberException(string message) : base(message) { }
    }
}
