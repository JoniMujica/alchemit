using System;
using System.Collections.Generic;

namespace C8_estructuras_de_control_de_selección_y_de_iteración
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(30);
            lista.Add(27);
            lista.Add(20);
            lista.Add(17);
            lista.Add(5);
            foreach (int x in lista)
            {
                if (x%3 == 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("el numero {0} es divisible por 6", x);
                    }
                    else
                    {
                        Console.WriteLine("El numero {0} es divisible por 3",x);
                    }
                }
                else
                {
                    if (x%2 == 0)
                    {
                        Console.WriteLine("el numero {0} es divisible por 2", x);
                    }
                    else
                    {
                        Console.WriteLine("el numero {0} no es divisible por 3 ni por 2", x);
                    }
                }
            }
        }
    }
}
