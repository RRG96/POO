using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    class Cliente : IPersona
    {
        private double deuda;
        public string Nombre { get; set; }
        public double Deuda 
        {
            get { return deuda; }
            set
            {
                if (value > 0)
                    deuda = value;
                else
                    deuda = 0;
            }
        }
        public Cliente(string nombre)
        {
            Nombre = nombre;
        }
        public void Pagar(double cantidad)
        {
            Deuda += cantidad;
            Console.WriteLine("El cliente {0} deposito una cantidad de {1:c}\n\tSu saldo actual es de {2:c}", Nombre, cantidad, Deuda);
        }
    }
}
