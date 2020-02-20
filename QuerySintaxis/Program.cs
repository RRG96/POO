using System;
using System.Linq;
using System.Collections.Generic;

namespace QuerySintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 9, 5, 0, 3, 7, 4, 8, 5 };
            Console.WriteLine("Arreglo original");
            Imprime(numeros);
            var filtered =
                from n in numeros
                where n > 4
                select n;
            Console.WriteLine("Arreglo filtrado numeros mayores a 4");
            Imprime(filtered);
            var sorted =
                from n in numeros
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado ascendentemente");
            Imprime(sorted);
            var sortDesc =
                from n in numeros
                orderby n descending
                select n;
            Console.WriteLine("Arreglo ordenado descendentemente");
            Imprime(sortDesc);
            var sortFiltered =
                from n in filtered
                orderby n
                select n;
            Console.WriteLine("Arreglo filtrado ordenado ascendentemente");
            Imprime(sortFiltered);
            string[] paises = { "México", "Rusia", "Austria", "Cuba" };
            IEnumerable<string> query =
                from p in paises
                where p.Contains("a")
                orderby p.Length
                select p.ToUpper();
            Console.WriteLine("Países que contienen a");
            Imprime(query);
            IEnumerable<string> mayor5 =
                from p in paises
                where p.Length > 5
                select p.ToUpper();
            Console.WriteLine("Paises con mas de 5 letras");
            Imprime(mayor5);
            IEnumerable<char> query3 =
                from p in paises
                orderby p.Length
                select p[0];
            Console.ReadKey();
        }
        static void Imprime<T>(IEnumerable<T> ts)
        {
            foreach (var dato in ts)
                Console.WriteLine(" {0} ", dato);
        }
    }
}