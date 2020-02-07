using System;

namespace TiposAnonimos {
	class Program {
		static void Main() { // Son de sólo lectura
			var anonimo  = new {
				Modelo = "Bocho",
				Precio = 80000,
				Placas = "45RT65"
			};

			Console.WriteLine("Datos del objeto anonimo:");
			Console.WriteLine(anonimo.Modelo);
			Console.WriteLine(anonimo.Precio);
			Console.WriteLine(anonimo.Placas);

			Console.ReadKey();
		}
	}
}