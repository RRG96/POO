using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    class Circulo : IFigura
    {
        public double Radio { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public Circulo(double Radio)
        {
            this.Radio = Radio;
        }
        public double Calcular_Area()
        {
            Area = (Math.PI * Math.Pow(Radio, 2));
            return Area;
        }
        public double Calcular_Perimetro()
        {
            Perimetro = (2 * Math.PI * Radio);
            return Perimetro;
        }
    }
}
