using System;

namespace Interfaz
{
    class Program
    {
        //Ya que cada una de las clases a los que les hereda la interfaz posee metodos alternos que son necesarios
        //pero solo para esa figura, los unicos que se mantienen constantes son el area y el perimetro
        //Con este modelo podriamos crear clases para todas las figuras y asi calcular su area y su perimetro
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(10, 5);
            Triangulo triangulo = new Triangulo(5, 3);
            Circulo circulo = new Circulo(10);
            Console.WriteLine("El rectángulo tiene un área de {0} y su perímetro es de {1}", rectangulo.Calcular_Area(), rectangulo.Calcular_Perimetro());
            Console.WriteLine("El triángulo tiene un área de {0} y su perímetro es de {1}", triangulo.Calcular_Area(), triangulo.Calcular_Perimetro());
            Console.WriteLine("El círculo tiene un área de {0} y su perímetro es de {1}", circulo.Calcular_Area(), circulo.Calcular_Perimetro());
            Console.ReadKey();
        }
    }
}
