using System;

namespace C1_Tipos_de_datos_básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string leyenda = "Hello binit!"; //con string declaro una cadena de caracteres
            int num1 = 10; //con int declaro una variable de numero entero (-2147483648 a 2147483647)
            double num2 = 3.1416; // con double declaro una variable real (15-16 cifras de precisión.)
            Console.WriteLine(leyenda);
            Console.WriteLine("El valor entero es {0} , el valor real es {1}",num1,num2); // con {} agrego el valor de las variables al string desde 0 a n++
            bool condicion = (num1 == num2); // con == comparo las variables
            Console.WriteLine("La condicion es {0}", condicion);
            char caracter = 'a';
            Console.WriteLine("El caracter es {0}", caracter);
        }
    }
}
