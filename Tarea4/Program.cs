using System;
using System.Collections.Generic;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola();
            List<string> cmd = new List<string>();
            int control = 0;
            string opcion = "";
            do
            {
                try
                {
                    Console.Write(consola.ToString());
                    opcion = Console.ReadLine();
                    consola.Historia.Add(opcion);
                    foreach (string cmdlets in opcion.Split(" "))
                        cmd.Add(cmdlets);
                    switch (cmd[0])
                    {
                        case "dir":
                            if (cmd.Count < 2)
                            {
                                consola.Dir("");
                                cmd.Clear();
                            }
                            else
                            {
                                consola.Dir(cmd[1]);
                                cmd.Clear();
                            }
                            break;
                        case "cd":
                            consola.Cd(cmd[1]);
                            cmd.Clear();
                            break;
                        case "touch":
                            consola.Touch(cmd[1]);
                            cmd.Clear();
                            break;
                        case "move":
                            consola.Move(cmd[1], cmd[2]);
                            cmd.Clear();
                            break;
                        case "history":
                            consola.History();
                            cmd.Clear();
                            break;
                        case "cls":
                            Console.Clear();
                            cmd.Clear();
                            break;
                        case "exit":
                            control = 1;
                            break;
                        default:
                            cmd.Clear();
                            break;
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("El comando {0} necesita argumentos", opcion);
                    cmd.Clear();
                }
            } while (control == 0);
        }
    }
}