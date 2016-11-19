using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            while(valid)
            {
                string cadena1 = string.Empty, cadena2 = string.Empty;

                Console.WriteLine("Ingresa un nombre: ");
                cadena1 = Console.ReadLine();
                Console.WriteLine("Ingresa un segundo nombre: ");
                cadena2 = Console.ReadLine();

                Console.WriteLine("\n\tPresiona enter para continuar.");

                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();

                if (cadena1 == cadena2)
                {
                    Console.WriteLine(cadena1 + " es igual que " + cadena2);
                    Console.WriteLine("presiona enter para terminar el programa.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    valid = false;
                }else
                {
                    Console.WriteLine(cadena1 + " no es igual a " +  cadena2);
                    Console.WriteLine("Preiona enter para terminar el programa");
                    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                    Console.Clear();
                    valid = false;
                }
            }
        }
    }
}
