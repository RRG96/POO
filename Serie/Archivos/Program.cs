using System.IO.Ports;
using System;

namespace Archivos
{
    class Program
    {
        //Programa monitorea los puertos series y que se conecta en ellos
        //Genera una bitacora en el directorio actual de trabajo donde almacena los nombres de los sistemas
        //de archivos conectados al equipo
        static void Main(string[] args)
        {
            Archivo archivo = new Archivo();
            SerialPort serial = new SerialPort();
            Console.WriteLine("El archivo se almacenrá en {0}", archivo.ToString());
            while(true)
            {
                if (SerialPort.GetPortNames()! is null)
                {
                    foreach (string s in SerialPort.GetPortNames())
                        archivo.Datos.Add(s);
                }
            }
        }
    }
}
