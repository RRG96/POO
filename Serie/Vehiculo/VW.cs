using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class VW : Carro
    {
        private bool Turbo;
        public string Modelo { get; set; }
        public VW(double altura, double peso, bool turbo, string modelo) : base(altura, peso)
        {
            Turbo = turbo;
            Modelo = modelo;
        }
        public override string ToString()
        {
            return string.Format("El Volkswagen {0}, tiene un peso de {1} kg y una altura de {2} m", Modelo, Peso, Altura);
        }
        public void Tiene_Turbo()
        {
            if (Turbo)
                Console.WriteLine("Tengo Turbo");
            else
                Console.WriteLine("No tengo Turbo");
        }
    }
}
