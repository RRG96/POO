using System;

namespace Clap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el primer número:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                int b = Convert.ToInt32(Console.ReadLine());
                ImprimeClap(a, b);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
            }
            Console.ReadKey();
        }
        public static void ImprimeClap(int a, int b)
        {
            string x = Convert.ToString(a);
            string y = Convert.ToString(b);
            for (int i = 0; i < 100; i++)
            {
                if ((i % a == 0 && i % b == 0) || i % a == 0 || i % b == 0 || (Convert.ToString(i)).Contains(x) || (Convert.ToString(i).Contains(y)))
                    Console.WriteLine("CLAP");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
