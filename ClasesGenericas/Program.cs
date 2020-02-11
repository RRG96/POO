using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(5);
            for (int i = 0; i < 5; i++)
                stack.Push(i + 1);
            int x = stack.Pop();
            int y = stack.Pop();
            Console.WriteLine("x {0}, y {1}", x, y);
            Stack<Tortilla> pila = new Stack<Tortilla>();
            pila.Push(new Tortilla());
            pila.Push(new Tortilla());
            Console.WriteLine(pila.Pop().color);
            Console.ReadKey();
        }
    }
}
