using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cell t1 = new Cell("Nokia", "1220");
            Smart t2 = new Smart("Huawei", "P30");
            Console.WriteLine(t1.ToString());
            t1.Llamar();
            t1.Escribir_Textos();
            Console.WriteLine(t2.ToString());
            t2.Llamar();
            t2.Escribir_Textos();
            Console.ReadKey();
        }
    }
}
