using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            while(valid)
            {
                operadores();
            }
        }
        //----------------------------------------------------------------------------------------------
        public static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        static bool salir()
        {
            bool validsub = true;

            Console.WriteLine("¿Quieres intentarlo de nuevo?\n 1. Si\n 2. No");
            int salida = int.Parse(Console.ReadLine());

            switch (salida)
            {
                case 1:
                    Console.WriteLine("Presiona enter para retornar.");
                    enter();
                    Console.Clear();
                    validsub = true;
                    break;
                case 2:
                    Console.WriteLine("Presiona enter para salir.");
                    enter();
                    Console.Clear();
                    validsub = false;
                    break;
                default:
                    Console.WriteLine("Valor invalido, presiona enter para continuar");
                    enter();
                    Console.Clear();
                    validsub = true;
                    break;
            }
            return validsub;
        }
        public static void operadores()
        {
            int opcion;
            print("\n\n\t\tIngresa la opcion que desees realizar:\n\n\t\t\t 1.- Suma\n\t\t\t 2.- Resta\n\t\t\t 3.- Multiplicación\n\t\t\t 4.- Division\n\t\t\t 5.- SALIR");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            int numero1, numero2, suma, resta, multi, division;
            switch (opcion)
            {
                case 1:
                    print("Ingresa el primer numero para sumar: ");
                    numero1 = int.Parse(Console.ReadLine());
                    print("Ingresa el segundo numero para sumar: ");
                    numero2 = int.Parse(Console.ReadLine());
                    suma = numero1 + numero2;
                    print("\n\tEl resultado de " + numero1 + " y " + numero2 + " es: " + suma);
                    print("Presiona enter para continuar.");
                    enter();
                    Console.Clear();
                    break;
                case 2:
                    print("Ingresa el primer numero para restar: ");
                    numero1 = int.Parse(Console.ReadLine());
                    print("Ingresa el segundo numero para restar: ");
                    numero2 = int.Parse(Console.ReadLine());
                    resta = numero1 - numero2;
                    print("\n\tEl resultado de " + numero1 + " y " + numero2 + " es: " + resta);
                    print("Presiona enter para continuar.");
                    enter();
                    Console.Clear();
                    break;
                case 3:
                    print("Ingresa el primer numero para multiplicar: ");
                    numero1 = int.Parse(Console.ReadLine());
                    print("Ingresa el segundo numero para multiplicar: ");
                    numero2 = int.Parse(Console.ReadLine());
                    multi = numero1 * numero2;
                    print("\n\tEl resultado de " + numero1 + " y " + numero2 + " es: " + multi);
                    print("Presiona enter para continuar.");
                    enter();
                    Console.Clear();
                    break;
                case 4:
                    print("Ingresa el primer numero para dividir: ");
                    numero1 = int.Parse(Console.ReadLine());
                    print("Ingresa el segundo numero para dividir: ");
                    numero2 = int.Parse(Console.ReadLine());
                    division = numero1 / numero2;
                    print("\n\tEl resultado de " + numero1 + " y " + numero2 + " es: " + division);
                    print("Presiona enter para continuar.");
                    enter();
                    Console.Clear();
                    break;
                case 5:
                    salir();
                    break;
                default:
                    print("Valor invalido, presione enter para continuar.");
                    enter();
                    break;
            }
        }
        public static void print(String s)
        {
            Console.WriteLine(s);
        }
    }
}
