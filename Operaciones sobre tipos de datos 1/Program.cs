using System;

namespace Operaciones_sobre_tipos_de_datos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;
            int u = (x / y); //division entera
            Console.WriteLine(u);
            int v = (x % y); //RESTO
            Console.WriteLine(v);

            double xx = 11.7;
            double yy = 3.5;
            double uu = (xx / yy);
            Console.WriteLine(uu);

            double vv = (xx % yy);
            Console.WriteLine(vv);

            //Booleanos
            bool comp1 = (x == xx); //falso
            bool comp2 = (y <= yy); //verdadero
            Console.WriteLine("Comparacion 1: {0}, Comparacion 2: {1}", comp1, comp2);

            bool YY = (comp1 && comp2);
            bool OO = (comp1 || comp2);
            Console.WriteLine("YY: {0}, OO: {1}",YY,OO);

            bool noYY = !YY; // verdadero
            bool nuevaConjuncion = (noYY && OO);
            Console.WriteLine(nuevaConjuncion);
        }
    }
}
