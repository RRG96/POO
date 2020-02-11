using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el tamaño de la matriz 1");
                Matriz<int> m1 = new Matriz<int>(Convert.ToInt32(Console.ReadLine()));
                m1.Lee();
                Console.WriteLine("Ingrese el tamaño de la matriz 2");
                Matriz<int> m2 = new Matriz<int>(Convert.ToInt32(Console.ReadLine()));
                m2.Lee();
                Matriz<int> m3 = new Matriz<int>(m1.Tamanio);
                Console.WriteLine("Que desea hacer?\n\tSuma (S)\n\tResta (R)\n\tMultiplicación (M)\n\tSalir");
                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "S":
                        m1.Imprime();
                        Console.WriteLine("+");
                        m2.Imprime();
                        Console.WriteLine("=");
                        m3 = m1 + m2;
                        m3.Imprime();
                        break;
                    case "R":
                        m1.Imprime();
                        Console.WriteLine("-");
                        m2.Imprime();
                        Console.WriteLine("=");
                        m3 = m1 - m2;
                        m3.Imprime();
                        break;
                    case "M":
                        m1.Imprime();
                        Console.WriteLine("X");
                        m2.Imprime();
                        Console.WriteLine("=");
                        m3 = m1 * m2;
                        m3.Imprime();
                        break;
                    default:
                        Console.WriteLine("Adios :D");
                        break;
                }
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            Console.ReadKey();
        }
    }
}
