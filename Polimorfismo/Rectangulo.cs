using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Rectangulo : IFigura
    {
        public int Altura { get; set; }
        public int Base { get; set; }
        public double CalcularArea()
        {
            return Altura * Base;
        }
        public void DatosRectangulo()
        {
            Console.WriteLine("Base: {0}, Altura {1}", Base, Altura);
        }
    }
}
