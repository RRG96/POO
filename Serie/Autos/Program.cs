using System;

namespace Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto(150, "Volkswagen", "Tiwan", 5, 10);
            Auto a2 = new Auto();
            Auto a3 = new Auto(150, "Honda", "CRV", 5, 10);
            Console.WriteLine(a2.Marca + " " + a2.Modelo);
            a2.Modelo = "Iqonic";
            a2.Marca = "Hyundai";
            a2.NPuertas = 5;
            a2.HP = 140;
            a2.Aceleracion = 10;
            Console.WriteLine("El vehiculo {0} es igual al vehiculo {1}: {2}", a1.Modelo, a2.Modelo, a1.Equals(a2));
            Console.WriteLine("El vehiculo {0} es igual al vehiculo {1}: {2}", a1.Modelo, a3.Modelo, a1.Equals(a3));
            a1.Corre();
            a1.Arranca();
            a2.Velocidad_Actual(30, 50);
            Console.ReadKey();
        }
    }
}
