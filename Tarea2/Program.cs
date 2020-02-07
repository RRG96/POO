using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellidop, apellidom;
            double cp;
            int nt, np;
            Console.WriteLine("Cuantos Alumnos desea calificar?");
            int numAlumnos = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[numAlumnos];
            for(int i = 0; i < numAlumnos; i++) 
            {
                Console.WriteLine("Nombre del Alumno:");
                nombre = Console.ReadLine();
                Console.WriteLine("Apellido Paterno:");
                apellidop = Console.ReadLine();
                Console.WriteLine("Apellido Materno:");
                apellidom = Console.ReadLine();
                Console.WriteLine("Calificación del Proyecto:");
                cp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de Tareas Entregadas:");
                nt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de Participaciones:");
                np = Convert.ToInt32(Console.ReadLine());
                alumnos[i] = new Alumno(nombre, apellidop, apellidom, cp, nt, np);
            }
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
            Console.ReadKey();
        }
    }
}
