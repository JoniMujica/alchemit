using System;
using System.Collections.Generic;

namespace C9_ESTRUCTURA_DE_SALTO
{
    class Program
    {
        static void mostrarLista(List<int> v)
        {
            foreach (int x in v)
            {
                if (x % 2 == 0)
                {
                    //continue;
                    Console.Write("{0} ", x);
                }
                //Console.Write("{0} ", x);
            }
            Console.WriteLine("");
        }

        //metodo 1
        /*
        static void buscarNum(int x,List<int> v)
        {
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == x)
                {
                    Console.WriteLine("El numero {0} esta en la lista",x);
                    break;
                }
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine("");
        }*/
        static void buscarNum(int x, List<int> v)
        {
            bool enc = false;
            for (int i = 0; i < v.Count && !enc; i++)
            {
                if (v[i] == x)
                {
                    Console.WriteLine("El numero {0} esta en la lista", x);
                    enc = true;
                }
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            for (int i = 0; i <= 40; i++)
            {
                Lista.Add(i);
            }
            mostrarLista(Lista);
            buscarNum(5, Lista);

            // aca un error que hay que cuidarse de usar continue (siempre sera verdadera y entra en un loop infinito)
            int inx = 0;
            while (inx < 40)
            {
                if (Lista[inx] != 6)
                    continue;
                Console.WriteLine("El numero 6 esta en la lista");

                inx++;
            }
        }
    }
}
