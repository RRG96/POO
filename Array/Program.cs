﻿using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = new int[list.Length];
            Array.Copy(list, temp, list.Length);
            Console.WriteLine("Arreglo Original: ");
            MostrarArreglo(list);
            Array.Reverse(temp);
            Console.WriteLine("Arreglo Invertido: ");
            MostrarArreglo(temp);
            Array.Sort(list);
            Console.WriteLine("Arreglo Ordenado: ");
            MostrarArreglo(list);
            Console.WriteLine("Indice del numero 44: " + Array.IndexOf(temp, 44));
            Console.ReadKey();
        }
        static void MostrarArreglo(int[] arreglo)
        {
            foreach(int i in arreglo)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
