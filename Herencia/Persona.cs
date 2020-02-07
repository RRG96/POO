﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        protected string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona() { }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0}", Nombre);
        }
        public override string ToString()
        {
            return String.Format("Mi nombre es {0} y tengo {1} años", Nombre, Edad);
        }
    }
}
