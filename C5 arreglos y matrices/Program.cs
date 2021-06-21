using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace C5_arreglos_y_matrices
{
    class Program
    {
        static void mostrarVec(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void mostrarMatriz(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++) //GetLength(n) me trae la logitud del array en su dimension
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3, 4, 5, 6 };
            int[,] matriz = new int[4, 5]; //para declarar una matriz, si o si debo pones una coma "[,]" y luego en el NEW determinar las filas y columnas
            mostrarVec(vector);

            Console.WriteLine("El elemento maximo es {0}, y el elemento minimo es {1}", vector.Max(),vector.Min());  //con min y max , obtengo los valores minimos y maximos de los elementos del array

            Console.WriteLine("El promedio del vector es: {0}", vector.Average()); //con Average obtengo el promedio del vector (la suma de los valores de los elementos / la cantidad de elementos del array


            ///////////////////////////////////CARGO LA MATRIZ DE DATOS/////////////////////////////////
            for (int i = 0; i < matriz.GetLength(0); i++) //GetLength(n) me trae la logitud del array en su dimension
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = (i + j) % 10;
                }
            }
            mostrarMatriz(matriz);


            ///MOVER EL PRIMER ELEMENTO DEL VECTOR, AL ULTIMO///
            int prov = vector[0];
            for (int i = 0; i < vector.Length-1; i++)
            {
                vector[i] = vector[i + 1];
            }
            vector[vector.Length - 1] = prov;

            Console.WriteLine("Res: ");
            mostrarVec(vector);
        }
    }
}
