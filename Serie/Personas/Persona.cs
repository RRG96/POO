using System;
using System.Collections.Generic;
using System.Text;

namespace Personas
{
    class Persona
    {   //Se crean los atributos de persona encapsulados
        public string Nombre { get; set; }
        public double Estatura { get; set; }
        public double Peso { get; set; }
        //Se crea constructor para inicializar las variables de la clase
        public Persona(string nombre, double estatura, double peso)
        {
            Nombre = nombre;
            Estatura = estatura;
            Peso = peso;
        }
        //Sobre carga de constructor vacío, inicializa estancia con valores nulos
        public Persona()
        {
            Nombre = "";
            Estatura = 0;
            Peso = 0;
        }
        //Funcion que calcula el Indice de Masa Corporal de una Persona
        public double IMC()
        {
            return Peso / Math.Pow(Estatura, 2);
        }
        //Función que calcula los caballos de fuerza que puede generar una persona promedio si escalara su altura en 4 Segundos
        public double HP()
        {
            return ((Peso * 9.81 * Estatura) / 4) / 746;
        }
        //Calcula la energia cinetica de una persona en movimiento, valor de la velocidad en km/h
        public double Energia_Cinetica(double V)
        {
            return (Peso * Math.Pow((V * 10 / 36), 2)) / 2;
        }
    }
}
