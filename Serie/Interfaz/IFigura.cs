using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaz
{
    //El objetivo principal de esta interfaz es normalizar la implementación de figuras geometricas
    //ya que todas poseen estos dos atributos y dos metodos se implementan de maneras diferentes
    //y es imperativo que las contengan.
    interface IFigura
    {
        //Se creean los atributos encapsulados de el area y el perimetro
        public double Perimetro { get; set; }
        public double Area { get; set; }
        //Se declaran los metodos para calcular los atributos
        public double Calcular_Area();
        public double Calcular_Perimetro();
    }
}
