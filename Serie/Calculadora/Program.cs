using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> datos = new List<string>();
            int control;
            control = Control();
            do
            {
                Console.WriteLine("Calculadora");
                Console.Write("La operación debe estar separada por espacios\n\tEjemplo '5 + 2'\n\tIngrese la operación:");
                string operacion = Console.ReadLine();
                try
                {
                    foreach (string val in operacion.Split(" "))
                        datos.Add(val);
                    Console.WriteLine("Resultado: {0}", Operacion(Convert.ToDouble(datos[0]), Convert.ToDouble(datos[2]), datos[1]));
                    datos.Clear();
                    control = Control();
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("No ingreso el formato solicitado");
                    datos.Clear();
                    control = Control();
                    Console.Clear();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es muy grande");
                    datos.Clear();
                    control = Control();
                    Console.Clear();
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("No se ingreso el formato deseado");
                    datos.Clear();
                    control = Control();
                    Console.Clear();
                }
            } while (control == 0);
            Console.WriteLine("Adios :D");
            Console.ReadKey();
        }
        public static double Operacion(double valor1, double valor2, string operador)
        {
            try
            {
                switch (operador)
                {
                    case "+":
                        return valor1 + valor2;
                    case "-":
                        return valor1 - valor2;
                    case "*":
                        return valor1 * valor2;
                    case "/":
                        return valor1 / valor2;
                    default:
                        Console.WriteLine("No ingreso una operación valida");
                        return 0;
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;
            }
            catch(OverflowException)
            {
                Console.WriteLine("El número es muy grande");
                return 0;
            }
        }
        public static int Control()
        {
            Console.WriteLine("Desea realizar una operación? Si(S), No(N)");
            string opcion = Console.ReadLine();
            switch(opcion)
            {
                case "S":
                    return 0;
                default:
                    return 1;
            }
        }
    }
}
