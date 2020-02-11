
using System;

namespace SumaNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el número natural:");
                Console.WriteLine(SumaNaturales(Convert.ToInt32(Console.ReadLine())));
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe);
            }
            Console.ReadKey();
        }
        public static int SumaNaturales(int dato)
        {
            int suma = 0;
            for (int i = 0; i <= dato; i++)
                suma += i;
            return suma;
        }
    }
}
