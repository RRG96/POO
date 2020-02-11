using System;
using System.Collections.Generic;
using System.Text;

namespace Geometricos
{
    class TrianguloRectangulo
    {
        private double Altura { get; set; }
        private double Base { get; set; }
        public TrianguloRectangulo(double altura, double base_)
        {
            Altura = altura;
            Base = base_;
        }
        public double Hipotenusa()
        {
            //Math.Sqrt obtiene la raiz cuadrada del número dado 
            //Math.Pow te devuelve la potencia de un numero, pide dos parámetros el número a elevar y la potencia
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Base, 2));
        }
        public double Angulo(string angulo = "beta")
        {
            //Math.Atan devuelve el angulo del que se especifica el número
            if (angulo.ToLower().CompareTo("beta") == 0)
                return Math.Atan(Altura / Base);
            else
                return Math.Atan(Base / Altura);
        }
    }
}
