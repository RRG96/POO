using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tarea4
{
    class Consola
    {
        private string Directorio;
        public List<string> Historia { get; set; }
        public Consola()
        {
            Environment.CurrentDirectory = ("C:\\Windows\\System32");
            Directorio = "C:\\Windows\\System32";
            Historia = new List<string>();
        }
        public void Dir(string directorio)
        {
            try
            {
                if (directorio == "")
                {
                    foreach (string d in Directory.GetDirectories(Directorio))
                        Console.WriteLine(d);
                    foreach (string f in Directory.GetFiles(Directorio))
                        Console.WriteLine(f);
                }
                else
                {
                    foreach (string d in Directory.GetDirectories(directorio))
                        Console.WriteLine(d);
                    foreach (string f in Directory.GetFiles(directorio))
                        Console.WriteLine(f);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tiene permisos para abrir el archivo o directorio");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("La direccion es muy larga");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio no existe");
            }    
        }
        public void Cd(string target)
        {
            try
            {
                if (target == "..")
                {
                    Environment.CurrentDirectory = Directory.GetParent(Directorio).FullName;
                    Directorio = Directory.GetParent(Directorio).FullName;
                }
                else
                {
                    Environment.CurrentDirectory = (Directorio + "\\" + target);
                    Directorio += "\\" + target;
                }
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("No existe el directorio");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("No tiene permisos para acceder a ese directorio");
            }
            catch(IOException)
            {
                Console.WriteLine("La direccion es incorrecta");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Esta en el directorio root");
            }
        }
        public void Touch(string directorio)
        {
            try
            {
                if (directorio.Contains("\\"))
                    File.Create(directorio);
                else
                    File.Create(Directorio + "\\" + directorio);
            }
            catch(IOException)
            {
                Console.WriteLine("Se intento crear un archivo en una direccion donde ya exite");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("No tiene permisos para crear el archivo en esta carpeta");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("Algo inesperado sucedio");
            }
        }
        public void Move(string directorios, string directoriod)
        {
            try
            {
                Directory.Move(directoriod, directoriod);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path is a null reference.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tiene los permisos necesarios para acceder al archivo");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("El directorio es muy largo");
            }
            catch (IOException)
            {
                Console.WriteLine("Se a intentado mover el archivo y algo inesperado a sucedido");
            }
        }
        public void History()
        {
            foreach (string historia in Historia)
                Console.WriteLine(historia);
        }
        public override string ToString()
        {
            return Directorio + "> ";
        }
    }
}