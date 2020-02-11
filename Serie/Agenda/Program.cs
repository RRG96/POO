using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            string key;
            Int64 value;
            AgendaTelefonica a = new AgendaTelefonica();
            do
            {
                Console.WriteLine("Que desea hacer?\n\tIngresar un contacto (I)\n\tEliminar un contacto (E)\n\tBuscar un contacto (B)\n\tSalir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "I":
                        try
                        {
                            Console.WriteLine("Ingresa el Nombre");
                            key = Console.ReadLine();
                            Console.WriteLine("Ingresa el Número");
                            value = Convert.ToInt64(Console.ReadLine());
                            a.Agregar_Contacto(key, value);
                        }
                        catch(FormatException fe)
                        {
                            Console.WriteLine(fe.Message);
                        }
                        catch(OverflowException)
                        {
                            Console.WriteLine("Número no valido, intente de nuevo");
                        }
                        break;
                    case "E":
                        Console.WriteLine("Ingresa el Nombre");
                        key = Console.ReadLine();
                        a.Eliminar_Contacto(key);
                        break;
                    case "B":
                        Console.WriteLine("Ingresa el Nombre");
                        key = Console.ReadLine();
                        a.Mostrar_Contacto(key);
                        break;
                    default:
                        Console.WriteLine("Adios :D");
                        x = 1;
                        Console.ReadKey();
                    break;
                }
            } while (x != 1);
        }
    }
}
