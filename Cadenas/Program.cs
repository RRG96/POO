using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hola, " + "Mundo\n");
            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);
            Console.WriteLine("Mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("Minúsculas: " + cadena.ToLower());
            Console.WriteLine("Replace: " + cadena.Replace(" ", ""));
            Console.WriteLine("Caracter en indice 0: " + cadena[0]);
            Console.WriteLine("SubStrings: " + cadena.Substring(0, 5));
            Console.WriteLine("Cadena contiene 'es' " + cadena.Contains("es"));
            Console.ReadKey();
        }
    }
}
