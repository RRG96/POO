using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Cell : IPhone
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Cell(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void Llamar()
        {
            Console.WriteLine("Llamando por línea telefonica.....");
        }
        public void Escribir_Textos()
        {
            Console.WriteLine("Mandando texto sms....");
        }
        public override string ToString()
        {
            return String.Format("Soy un {0} {1}", Marca, Modelo);
        }
    }
}
