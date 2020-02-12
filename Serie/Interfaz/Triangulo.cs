using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    class Triangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double LadoA { get; set; }
        public double LadoC { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public Triangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.LadoA = LadoA;
            this.LadoC = LadoC;
        }
        public double Calcular_Area()
        {
            Area = (Base * Altura) / 2;
            return Area;
        }
        public double Calcular_Perimetro()
        {
            Calcular_Lados();
            Perimetro = Base + LadoA + LadoC;
            return Perimetro;
        }
        public void Calcular_Lados()
        {
            LadoA = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            LadoC = LadoA;
        }
    }
}
