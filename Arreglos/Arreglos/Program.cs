using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static int posicion, contador;
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            float[] notas = new float[10];
            int opcion;
            bool valid = true, validsub = true;

            while (valid)
            {
                print("\t\t\tPortal de control de notas.\n\tSelecciona la opcion según lo que quieras hacer:\n\t1.- Ingresar Notas.\n\t2.- Ver resultados.\n\t3.- Salir.");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        do
                        {
                            if (contador <= 9)
                            {
                                contador = addAlumno(nombres, notas);
                                validsub = salir();
                                Console.Clear();
                            }else
                            {
                                print("La lista de alumnos ya está llena, presiona enter para retornar al menu");
                                enter();
                                validsub = false;
                                Console.Clear();
                            }
                        } while (validsub);
                        break;
                    case 2:
                        do
                        {
                            mostrarAlumnos(nombres, notas);
                            mostrarPromedio(nombres, notas);
                            mostrarMax(nombres, notas);
                            mostrarMin(nombres, notas);
                            validsub = salir();
                            Console.Clear();
                        } while (validsub);
                        break;
                    case 3:
                        print("Presiona enter para salir.");
                        enter();
                        Console.Clear();
                        valid = false;
                        break;
                    default:
                        print("Has ingresado un valor inválido, Presiona enter para continuar.");
                        enter();
                        valid = true;
                        Console.Clear();
                        break;
                }
            }
        }
        static void print(string s)
        {
            Console.WriteLine(s);
        }
        static void enter()
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        static bool salir()
        {
            bool validsub = true;
            print("Selecciona tu opción:\n1.- Retornar a menu\n2.- Permanecer aquí.");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    print("Retornando a menu.");
                    validsub = false;
                    Console.Clear();
                    break;
                case 2:
                    validsub = true;
                    Console.Clear();
                    break;
                default:
                    print("Valor inválido, presiona enter para continuar.");
                    enter();
                    validsub = false;
                    Console.Clear();
                    break;
            }
            return validsub;
        }
        static int addAlumno(string[] nombres, float[] notas)
        {
            print("Ingresa el nombre del Alumno : ");
            string nombre = Console.ReadLine();
            print("Ingresa la nota de " + nombre + " sobre 100pts: ");
            float nota = float.Parse(Console.ReadLine());
            if(nota <= 100)
            {
                nombres[posicion] = nombre;
                notas[posicion] = nota;
                contador = contador + 1;
                posicion = posicion + 1;
            }else
            {
                print("Has ingresado una nota inválida");
                print("Contador: " + contador);
            }
            return contador;
        }
        static void mostrarAlumnos(string[] nombres, float[] notas)
        {
            print("\n\t\tNombre\t\t\tNota\n");
            for (int posicion = 0; posicion <= 9; posicion++)
            {
                print("\t" + nombres[posicion] + "\t\t" + notas[posicion]);
            }
        }
        static void mostrarPromedio(string[] nombres, float[] notas)
        {
            int i; 
            float temp, suma = 0, promedio;
            print("\n\n\t\tPromedio: ");
            for (i = 0; i <= 9; i++)
            {
                temp = notas[i];
                suma = suma + temp;
            }
            promedio = suma / i;
            print("El promedio de las notas es: " + promedio);
        }
        static void mostrarMax(string[] nombres, float[] notas)
        {
            int e, temp = 0;
            float max = 0;
            string nombre;
            for (e = 0; e <= 9; e++)
            {
                if (notas[e] > max)
                {
                    max = notas[e];
                    nombre = nombres[e];
                    temp = temp + 1;
                    if (temp == 9)
                    {
                        print("La nota más alta es: " + max + " del alumno " + nombre);
                    }
                }
            }
        }
        static void mostrarMin(string[] nombres, float[] notas)
        {
            int e, contador = 0;
            float min = 100;
            string nombre;
            for(e = 0; e <= 9; e++)
            {
                if(notas[e] < min)
                {
                    min = notas[e];
                    nombre = nombres[e];
                    contador = contador + 1;
                    if (contador == 9)
                    {
                        print("La nota más baja es: " + min + " del alumno " + nombre);
                    }else
                    {
                        print("La nota más baja es: " + min + " del alumno " + nombre);
                    }
                }
            }
        }
    }
}
