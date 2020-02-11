using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa el numero de valores para la serie de Fibonacci");
                Fibonacci(Convert.ToInt32(Console.ReadLine()));
            } 
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            Console.ReadKey();
        }
        public static void Fibonacci(int final, int anterior = 0, int actual = 1, int contador = 0)
        {
            if (contador < final)
            {
                Console.WriteLine(anterior);
                Fibonacci(final, actual, anterior + actual, ++contador);
            }
        }
    }
}
