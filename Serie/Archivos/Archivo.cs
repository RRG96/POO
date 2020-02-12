using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Archivos
{
    class Archivo
    {
        public List<string> Datos { get; set; }
        private string directorio = Directory.GetCurrentDirectory();
        public void Escribe()
        {
            try
            {
                File.Create(directorio + "\\Data.txt");
                StreamWriter sw = new StreamWriter(directorio + "\\Data.txt");
                foreach (string linea in Datos)
                    sw.WriteLine(linea);
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public override string ToString()
        {
            return directorio + "\\Data.txt";
        }
    }
}
