using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class AgendaTelefonica
    {
        private Dictionary<string, Int64> agenda = new Dictionary<string, Int64>();
        public void Agregar_Contacto(string Key, Int64 Value)
        {
            if (agenda.ContainsKey(Key))
                agenda.Add(Key.ToLower(), Value);
            else
                Console.WriteLine("El contacto ya existe");
        }
        public void Eliminar_Contacto(string Key)
        {
            if (agenda.ContainsKey(Key.ToLower()))
                agenda.Remove(Key.ToLower());
            else
                Console.WriteLine("No existe el usuario!");
        }
        public void Mostrar_Contacto(string Key)
        {
            if (agenda.ContainsKey(Key.ToLower()))
                Console.WriteLine("{0}: {1}", Key, agenda[Key.ToLower()]);
            else
                Console.WriteLine("Ese usuario no existe");
        }
    }
}
