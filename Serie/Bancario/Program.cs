using System;

namespace Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cb1 = new CuentaBancaria("rodrigo", 5000);
            CuentaBancaria cb2 = new CuentaBancaria();
            cb1.Deposito(10000);
            cb2.Mostrar_Informacion();
            cb2.Nombre = "Manuel";
            cb2.Deposito(50000);
            cb1.Mostrar_Informacion();
            cb1.Retiro(1000);
            cb1.Mostrar_Informacion();
            cb2.Mostrar_Informacion();
            Console.ReadKey();
        }
    }
}
