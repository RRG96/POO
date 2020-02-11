using System;
using System.Collections.Generic;
using System.Text;

namespace Geometricos
{
    class Circulo
    {
        public double Radio { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
