using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Smart : IPhone
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Smart(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void Llamar()
        {
            Console.WriteLine("Desea llamar por:\n\tLlamada Celular (C)\n\tLLamada VoIP (I)\n\tVideoLlamada (V)");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "C":
                    Console.WriteLine("Biip..... Biiipp....");
                    break;
                case "I":
                    Console.WriteLine("No hay internet...... :(");
                    break;
                case "V":
                    Console.WriteLine("Conectando......");
                    break;
            }
        }
        public void Escribir_Textos()
        {
            Console.WriteLine("Desea mandar el texto por:\n\tWhatsApp (W)\n\tTelegram (T)\n\tSms (S)");
            string opcion = Console.ReadLine();
            switch(opcion)
            {
                case "W":
                    Console.WriteLine("Mandando whats.....");
                    break;
                case "T":
                    Console.WriteLine("Mandando telegram......");
                    break;
                case "S":
                    Console.WriteLine("Mandando sms..... :(");
                    break;
                default:
                    Console.WriteLine("No se envio nada!");
                    break;
            }
        }
        public override string ToString()
        {
            return String.Format("Soy un {0} {1}", Marca, Modelo);
        }
    }
}
