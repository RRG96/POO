using System;

namespace Imaginarios
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosImaginarios im1 = new NumerosImaginarios(5, 10);
            NumerosImaginarios im2 = new NumerosImaginarios(10, 9);
            NumerosImaginarios im3 = new NumerosImaginarios();
            im3 = im1 + im2;
            Console.WriteLine(im3.ToString());
            Console.ReadKey();
        }
    }
}
