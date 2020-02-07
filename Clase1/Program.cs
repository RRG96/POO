using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Rodrigo", 23);
            Persona p2 = new Persona("Whatevs", 20);
            Persona p3 = new Persona("Ajio ajio", 15);
            Persona p4 = new Persona("Rodrigo", 23);
            //Comparación de referencias
            Console.WriteLine("Referencias p1 y p2 son iguales?");
            Console.WriteLine(p1 == p2);
            Console.WriteLine("Referencias p1 y p3 son iguales?");
            Console.WriteLine(p1 == p3);
            Console.WriteLine("Referencias p1 y p4 son iguales?");
            Console.WriteLine(p1 == p4);
            //Compración de objetos
            Console.WriteLine("Objetos p1 y p2 son iguales?");
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine("Objetos p1 y p3 son iguales?");
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine("Objetos p1 y p4 son iguales?");
            Console.WriteLine(p1.Equals(p4));
            Console.ReadLine();
        }
    }
}
