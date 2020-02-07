using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales =
            {
                new Carnivoro("Leon"),
                new Hervivoro("Jirafa"),

            };
            Console.WriteLine("Lista de Animales");
            foreach (Animal anima in animales)
                Console.WriteLine(anima);
            Lobo lobo = new Lobo("Lobezno");
            lobo.Cazar();
            (lobo as Carnivoro).Cazar();
            Pinguino pinguino = new Pinguino("Tux");
            pinguino.Cazar();
            (pinguino as Carnivoro).Cazar();
            Console.ReadKey();
        }
    }
}
