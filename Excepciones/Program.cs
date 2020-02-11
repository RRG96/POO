using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa el numerador: ");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());
                double resultado = numerador / denominador;
                Console.WriteLine("\nResultado: {0} / {1} = {2}", numerador, denominador, resultado);
            }
            catch (DivideByZeroException zeroexception)
            {
                Console.WriteLine("\n" + zeroexception.Message);
                Console.WriteLine("El denominador no puede ser cero");
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine("\n" + formatexception.Message);
                Console.WriteLine("Las datos ingresados deben ser numeros, no letras");
            }
            Console.ReadKey();
        }
    }
}
