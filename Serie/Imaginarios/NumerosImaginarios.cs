using System;
using System.Collections.Generic;
using System.Text;

namespace Imaginarios
{
    class NumerosImaginarios
    {
        public int Real { get; set; }
        public int Imaginario { get; set; }
        public NumerosImaginarios(int real, int imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }
        public NumerosImaginarios()
        {
            Real = 0;
            Imaginario = 0;
        }
        public static NumerosImaginarios operator +(NumerosImaginarios obj1, NumerosImaginarios obj2)
        {
            obj2.Real += obj1.Real;
            obj2.Imaginario += obj1.Imaginario;
            return obj2;
        }
        public override string ToString()
        {
            return String.Format("{0} + {1}i", Real, Imaginario);
        }
    }
}
