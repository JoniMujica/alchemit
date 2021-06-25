using System;
using System.Collections.Generic;

namespace listas___uso_de_predicados
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
            List<int> lista1 = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                lista1.Add(i);
            }
            Console.Write("Lista 1: ");
            mostrarLista(lista1);
        }


    }
}
