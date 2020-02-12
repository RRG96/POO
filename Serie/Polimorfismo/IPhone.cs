using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    interface IPhone
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public void Llamar();
        public void Escribir_Textos();
    }
}
