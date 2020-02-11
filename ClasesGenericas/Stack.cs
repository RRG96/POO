using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesGenericas
{
    class Stack <T>
    {
        private int posicion;
        private T[] datos;
        public Stack()
        {
            datos = new T[10];
        }
        public Stack(int tamanio)
        {
            datos = new T[tamanio];
        }
        public void Push(T objeto)
        {
            datos[posicion++] = objeto;
        }
        public T Pop()
        {
            return datos[--posicion];
        }
    }
}
