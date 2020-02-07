using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Rodrigo", 23);
            p.Saludar();
            Console.WriteLine(p.ToString());
            Empleado e = new Empleado("Rodrigo", 23, "Estudiante", 10000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());
            Persona p1 = new Persona("Xotla", 22);
            Persona p2 = new Persona("Baruch", 22);
            Persona[] gente = new Persona[4];
            gente[0] = p;
            gente[1] = p1;
            gente[2] = p2;
            gente[3] = e;
            Console.WriteLine();
            Console.WriteLine("lista de Personas que son Empleados");
            foreach(var per in gente)
                if (per is Empleado)
                    Console.WriteLine(per.ToString());
            Console.ReadKey();
        }
    }
}
