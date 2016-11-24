using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de una dimension
             int[] numbers = new int[];
            // Arreglo de 2 dimensiones
             int[,] notas = new[5,6];
             notas[2,1] = 10;
            //Jagged(Irregulares) Arrays
             int sales[,] = new int[12,30];
                jagged[0,0] = 23;
                jagged[0,1] = 13;
        }
        static void print(string s)
        {
            Console.WriteLine(s);
        }
    }
}
/*
    PROPIEDADES DE ARREGLOS
    Length
    GetLength()
    Rank      > Da el numero de dimensiones del arreglo.-
    GetType
*/