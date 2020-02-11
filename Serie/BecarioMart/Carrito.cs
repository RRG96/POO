using System;
using System.Collections.Generic;
using System.Text;

namespace BecarioMart
{
    class Carrito
    {
        public List<string> Producto = new List<string>();
        public List<double> Precio = new List<double>();
        public void Agregar_Articulo(string producto, double precio)
        {
            Producto.Add(producto);
            Precio.Add(precio);
        }
        public void Quitar_Articulo(int indice)
        {
            Producto.RemoveAt(indice);
            Precio.RemoveAt(indice);
        }
        public double Precio_Compra()
        {
            double costo_total = 0;
            foreach (double precio in Precio)
            {
                costo_total += precio;
            }
            return costo_total;
        }
        public void Imprime_Productos()
        {
            for (int i = 0; i < Producto.Count; i++)
                Console.WriteLine("Indice {0} Articulo {1} precio: {2:c}", i, Producto[i], Precio[i]);
        }
    }
}
