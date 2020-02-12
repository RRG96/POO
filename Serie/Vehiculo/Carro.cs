using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Carro
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        private bool encendido = false;
        public Carro(double altura, double peso)
        {
            Altura = altura;
            Peso = peso;
        }
        public void Encendido()
        {
            encendido = true;
            Console.WriteLine("El vehículo se encendió");
        }
        public void Apagado()
        {
            encendido = false;
            Console.WriteLine("El vehículo se apagó");
        }
        public void Estado()
        {
            if (encendido)
                Console.WriteLine("El vehículo esta encendido");
            else
                Console.WriteLine("El vehículo esta apagado");
        }
        public override string ToString()
        {
            return String.Format("El vehículo tiene un peso de {0} kg y una altura de {1} m", Peso, Altura);
        }
    }
}
