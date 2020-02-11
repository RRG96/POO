using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p2 = new Persona();
            try
            {
                Console.WriteLine("Ingrese el nombre de la persona");
                p2.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la estatura  de {0}", p2.Nombre);
                p2.Estatura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el peso de {0}", p2.Nombre);
                p2.Peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El IMC de {0} es de {1}", p2.Nombre, p2.IMC());
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
    }
}
