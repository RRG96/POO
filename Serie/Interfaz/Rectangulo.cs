using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    class Rectangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public Rectangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public double Calcular_Area()
        {
            Area = Base * Altura;
            return Area;
        }
        public double Calcular_Perimetro()
        {
            Perimetro = (2 * Base) + (2 * Perimetro);
            return Perimetro;
        }
    }
}
