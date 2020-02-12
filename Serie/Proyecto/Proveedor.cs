using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class Proveedor
    {
        private double deuda;
        public string Nombre { get; set; }
        public double Deuda
        {
            get { return deuda; }
            set
            {
                if (value < 0)
                    deuda = value * (-1);
                else
                    deuda = value;
            }
        }
        public Proveedor(string nombre)
        {
            Nombre = nombre;
        }
        public void Pagar(double cantidad)
        {
            Deuda -= cantidad;
            Console.WriteLine("Se le deposito al proveedor {0} la cantidad de {1:c}\n\tNuestra deuda actual es de {2:c}", Nombre, cantidad, Deuda);
        }
    }
}
