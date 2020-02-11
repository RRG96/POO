using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        private static readonly string[] colors = { "Magenta", "Cyan", "Amarillo", "Rojo", "Azul", "Negro" };
        private static readonly string[] removeColors = { "Rojo", "Azul", "Negro" };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            foreach (var color in colors)
                list.Add(color);
            List<string> removeList = new List<string>();
            foreach (var color in removeColors)
                removeList.Add(color);
            MostrarLista(list);
            Console.ReadKey();
        }
        public static void MostrarLista(List<string> list)
        {
            foreach (var elemento in list)
                Console.Write(elemento + " ");
        }
    } 
}
