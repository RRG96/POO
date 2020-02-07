using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno
    {
        private string Nombre, ApellidoP, ApellidoM;
        private double CalificacioP, calificacionfinal;
        private int NumT, NumP;
        public double CalifiacionFinal
        {
            get { return calificacionfinal; }
            set 
            {
                if (value > 10)
                    calificacionfinal = 10;
                else if (value < 5)
                    calificacionfinal = 5;
                else
                    calificacionfinal = value;
            }
        }
        public Alumno(string nombre, string apellidop, string apellidom, double calificacionp, int numt, int nump)
        {
            Nombre = nombre;
            ApellidoP = apellidop;
            ApellidoM = apellidom;
            CalificacioP = calificacionp;
            NumT = numt;
            NumP = nump;
            CalifiacionFinal = Calculadora(calificacionp, numt, nump);
        }
        public override string ToString()
        {
            return String.Format("El alumno {0} {1} {2} tiene una calificación de: {3}", Nombre, ApellidoP, ApellidoM, CalifiacionFinal);
        }
        public static double Calculadora(double cp, int np, int nt)
        {
            if (nt > 5)
                nt = 5;
            if (np > 5)
                return (cp * 0.6 + nt * 0.8) * 1.08;
            else
                return (cp * 0.6 + nt * 0.8);
        }
    }
}
