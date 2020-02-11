using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa valor para calcular raiz cuadrada ");
                double dato = Convert.ToInt32(Console.ReadLine());
                double resultado = RaizCuadrada(dato);
                Console.WriteLine("La raiz cuadrada de {0} es {1}\n", dato, resultado);
            }
            catch(FormatException formatexception)
            {
                Console.WriteLine(formatexception.Message);
            }
            catch(NegativeNumberException negative)
            {
                Console.WriteLine(negative.Message);
            }
            Console.ReadKey();
        }
        public static double RaizCuadrada(double value)
        {
            if (value < 0)
                throw new NegativeNumberException("No ingresar numeros negativos");
            else
                return Math.Sqrt(value);
        }
    }
}
