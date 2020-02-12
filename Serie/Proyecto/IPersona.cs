using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto
{
    interface IPersona
    {
        public string Nombre { get; set; }
        public double Deuda { get; set; }
        public void Pagar(double cantidad);
    }
}
