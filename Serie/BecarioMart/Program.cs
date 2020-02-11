using System;

namespace BecarioMart
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, opcion;
            double Precio, Efectivo;
            int control = 0;
            Carrito c = new Carrito();
            try
            {
                Console.WriteLine("Ingrese el efectivo para realizar la compra");
                Efectivo = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.WriteLine("Desea Agregar Productos a su carrito? Sí (S), No (N)");
                    opcion = Console.ReadLine();
                    switch(opcion)
                    {
                        case "S":
                            Console.Write("Nombre del Producto:");
                            Nombre = Console.ReadLine();
                            Console.Write("Precio del {0}:", Nombre);
                            Precio = Convert.ToDouble(Console.ReadLine());
                            c.Agregar_Articulo(Nombre, Precio);
                            break;
                        default:
                            Console.WriteLine("Se continua con el pago!");
                            Comprar(c.Precio_Compra(), Efectivo, c);
                            control = 1;
                            break;
                    }
                    Console.Clear();
                } while (control != 1);
            }
            catch(FormatException)
            {
                Console.WriteLine("El precio o efectivo solo deben ser números");
                Console.ReadKey();
            }
        }
        public static void Comprar(double Costo_Total, double Efectivo, Carrito carrito)
        {
            if (Costo_Total > Efectivo)
            {
                Console.WriteLine("No cuenta con efectivo suficiente\nElimine algunos productos");
                Eliminar_Productos(Costo_Total, Efectivo, carrito);
            }
            else
            {
                Console.WriteLine("Costo total: {0:c}", Costo_Total);
                Console.WriteLine("Muchas gracias por su compra\nVuelva Pronto :D");
                Console.ReadKey();
            }
        }
        public static void Eliminar_Productos(double Costo_Total, double Efectivo, Carrito carrito)
        {
            if (Costo_Total > Efectivo)
            {
                Console.WriteLine("Efectivo {0:c} < Costo de la Compra {1:c}", Efectivo, Costo_Total);
                Console.WriteLine("Que articulo desea eliminar?\n\tIngrese solo el indice del producto");
                try
                {
                    carrito.Imprime_Productos();
                    int indice = Convert.ToInt32(Console.ReadLine());
                    carrito.Quitar_Articulo(indice);
                    Costo_Total = carrito.Precio_Compra();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo ingrese el indice");
                    Eliminar_Productos(Costo_Total, Efectivo, carrito);
                }
                Console.Clear();
                Eliminar_Productos(Costo_Total, Efectivo, carrito);
            }
            else
            {
                Comprar(Costo_Total, Efectivo, carrito);
                Console.Clear();
            }
        }
    }
}