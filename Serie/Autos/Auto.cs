using System;
using System.Collections.Generic;
using System.Text;

namespace Autos
{
    class Auto
    {
        public double HP { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int NPuertas { get; set; }
        public double Aceleracion { get; set; }
        public Auto(double hp, string modelo, string marca, int puertas, double aceleracion)
        {
            HP = hp;
            Modelo = modelo;
            Marca = marca;
            NPuertas = puertas;
            Aceleracion = aceleracion;
        }
        public Auto()
        {
            HP = 0;
            Modelo = "Desconocido";
            Marca = "Desconocido";
            NPuertas = 0;
            Aceleracion = 0;
        }
        public void Corre()
        {
            Console.WriteLine("El vehículo {0} {1} va a toda velocidad", Marca, Modelo);
        }
        public bool Equals(Auto obj)
        {
            if (HP == obj.HP && Aceleracion == obj.Aceleracion)
                return true;
            else
                return false;
        }
        public void Arranca()
        {
            Console.WriteLine("El vehículo {0} {1} encendio exitosamente", Marca, Modelo);
        }
        public void Velocidad_Actual(double VI, double T)
        {
            VI *= 1000 / 3600;
            Console.WriteLine("La velocidad actual del vehículo es: {0} Km/h despues de {1} segundos", (VI + Aceleracion * T) * 3.6, T);
        }
    }
}
