using System;

namespace VocalF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena");
            vocalF(Console.ReadLine());
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void vocalF(string x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].CompareTo('a') == 0 || x[i].CompareTo('e') == 0 || x[i].CompareTo('i') == 0 || x[i].CompareTo('o') == 0 || x[i].CompareTo('u') == 0)
                    Console.Write("f" + x[i]);
                else
                    Console.Write(x[i]);
            }
        }
    }
}
