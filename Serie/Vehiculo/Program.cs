using System;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            VW carro1 = new VW(1.8, 2000, true, "Jetta");
            BMW carro2 = new BMW(2, 2500, false, "i8");
            carro1.Apagado();
            carro1.Encendido();
            carro1.Estado();
            carro1.Tiene_Turbo();
            Console.WriteLine(carro1.ToString());
            carro2.Apagado();
            carro2.Encendido();
            carro2.Estado();
            carro2.Tiene_Turbo();
            Console.WriteLine(carro2.ToString());
            Console.ReadKey();
        }
    }
}
