using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Rodrigo");
            c1.Edad = 30;
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.Cuenta);
            Console.WriteLine(c1.Dinero);
            c1.Depositar(5000);
            Console.WriteLine(c1.Dinero);
            Console.WriteLine(Cliente.Mensaje());
            Console.ReadKey();
        }
    }
}
