using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Rodrigo");
            Proveedor p1 = new Proveedor("Manuel");
            c1.Deuda = 1000;
            p1.Deuda = 35000;
            c1.Pagar(5000);
            p1.Pagar(10000);
            Console.ReadKey();
        }
    }
}
