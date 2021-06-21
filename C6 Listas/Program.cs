using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace C6_Listas
{
    class Program
    {
        static void mostrarLista(List<int> lista)
        {
            foreach (int x in lista)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            List<int> Lista1 = new List<int>();
            List<int> Lista2 = new List<int>();
            Lista1.Add(5);
            Lista1.Add(7);
            Lista1.Add(1);
            Lista1.Add(3);
            Lista1.Add(9);
            Lista1.Add(5);

            Lista2.Add(8);
            Lista2.Add(6);
            Lista2.Add(2);
            Lista2.Add(4);
            Lista2.Add(0);

            Console.WriteLine("Lista 1:");
            mostrarLista(Lista1);
            Console.WriteLine("Lista 2:");
            mostrarLista(Lista2);

            //Agrego un elemento a la lista en una posicion X
            Lista2.Insert(4, 10); //agrego en la posicion 4 el numero 10
            mostrarLista(Lista2);

            //Mostrar/Recorrer lista

            for (int i = 0; i < Lista2.Count; i++)
            {
                Console.Write(Lista2[i] + " "); 
            }


            //Concatenar listas
            List<int> Lista3 = new List<int>();
            Lista3.AddRange(Lista2);
            Lista3.AddRange(Lista1);
            Console.WriteLine("Lista 3:");
            mostrarLista(Lista3);

            //Buscar elemento de la lista

            Console.WriteLine("El 10 esta en la posicion {0}", Lista3.IndexOf(10));
            // Ordenar lista
            Lista3.Sort(); //ordena la lista de menor a mayor
            Console.WriteLine("Lista 3 ordenada");
            mostrarLista(Lista3);
            Console.WriteLine(Lista3.BinarySearch(10)); //para usar el "BinarySearch" la lista o vector, deben estar ordenados
        }
    }
}
