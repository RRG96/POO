using System;
using System.Collections.Generic;
using System.Text;

namespace Matrices
{
    class Matriz<T>
    {
        public int Tamanio { get; set; }
        private T[,] M;
        public Matriz(int tamanio)
        {
            Tamanio = tamanio;
            M = new T[Tamanio, Tamanio];
        }
        public void Lee()
        {
            try
            {
                for (int i = 0; i < Tamanio; i++)
                {
                    for (int j = 0; j < Tamanio; j++)
                    {
                        Console.Write("Ingrese el valor Matriz[{0}][{1}]: ",i, j);
                        M[i, j] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    }
                }
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
        public void Imprime()
        {
            for (int i = 0; i < Tamanio; i++)
            {
                for (int j = 0; j < Tamanio; j++)
                {
                    Console.Write("{0} ", M[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static Matriz<T> operator +(Matriz<T> m1, Matriz<T> m2)
        {
            Matriz<T> m3 = new Matriz<T>(m1.Tamanio);
            dynamic d1 = m1;
            dynamic d2 = m2;
            if (m1.Tamanio == m2.Tamanio)
            {
                for (int i = 0; i < m1.Tamanio; i++)
                {
                    for (int j = 0; j < m1.Tamanio; j++)
                        m3.M[i, j] = d1.M[i, j] + d2.M[i, j];
                }
                return m3;
            }
            else
            {
                Console.WriteLine("No se puede realizar la suma, las matrices no son del mismo tamaño");
                return m3;
            }
        }
        //Hacemos una sobrecarga de operadores
        public static Matriz<T> operator -(Matriz<T> m1, Matriz<T> m2)
        {
            Matriz<T> m3 = new Matriz<T>(m1.Tamanio);
            //Declaramos la variables d1 y d2 como dynamic y los igualamos a m1 y m2 para realizar la suma
            dynamic d1 = m1;
            dynamic d2 = m2;
            if (m1.Tamanio == m2.Tamanio)
            {
                for (int i = 0; i < m1.Tamanio; i++)
                {
                    for (int j = 0; j < m1.Tamanio; j++)
                        m3.M[i, j] = d1.M[i, j] - d2.M[i, j];
                }
                return m3;
            }
            else
            {
                Console.WriteLine("No se puede realizar la resta, las matrices no son del mismo tamaño");
                return m3;
            }
        }
        public static Matriz<T> operator *(Matriz<T> m1, Matriz<T> m2)
        {
            Matriz<T> m3 = new Matriz<T>(m1.Tamanio);
            dynamic d1 = m1;
            dynamic d2 = m2;
            if (m1.Tamanio == m2.Tamanio)
            {
                for (int i = 0; i < m1.Tamanio; i++)
                {
                    for (int j = 0; j < m1.Tamanio; j++)
                    {
                        for (int k = 0; k < m1.Tamanio; k++)
                            m3.M[i, j] += d1.M[i, k] * d2.M[k, j];
                    }
                }
                return m3;
            }
            else
            {
                Console.WriteLine("No se puede realizar la multiplicación, las matrices no son del mismo tamaño");
                return m3;
            }
        }
    }
}
