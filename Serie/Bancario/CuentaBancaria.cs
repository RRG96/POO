using System;
using System.Collections.Generic;
using System.Text;

namespace Bancario
{
    class CuentaBancaria
    {
        public string Nombre { get; set; }
        private int Saldo;
        public CuentaBancaria(string nombre, int saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }
        public CuentaBancaria()
        {
            Nombre = "Unavailable";
            Saldo = 0;
        }
        public void Deposito(int deposito)
        {
            Saldo += deposito;
        }
        public void Retiro(int retiro)
        {
            if (Saldo < retiro)
                Console.WriteLine("Sin saldo suficiente!");
            else
                Saldo -= retiro;
        }
        public void Mostrar_Informacion()
        {
            Console.WriteLine("{0} tiene {1:c}", Nombre, Saldo);
        }
    }
}
