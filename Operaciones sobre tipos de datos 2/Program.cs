using System;

namespace Operaciones_sobre_tipos_de_datos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pintor1 = "Picasso";
            string pintor2 = "Monet";
            string pintor3 = "Klee";
            string musico1 = "Schoenberg";
            string musico2 = "Berg";
            string prueba = "aa-aaa-bbbb-aa-abb";
            string segmento = "bb";
            string abc = "abcdefghijklmnñopqrstuvwxyz";

            string[] arr = { pintor1, musico1, pintor2, musico2, pintor3 };
            Console.WriteLine("La longitud del ABC es: {0}",abc.Length);

            string conca = (pintor1 + ", " + pintor3);
            Console.WriteLine(conca);
            Console.WriteLine("Antes: {0}", prueba);
            Console.WriteLine("Despues: {0}", prueba.Replace(segmento,musico2));
            Console.WriteLine(abc);
            Console.WriteLine("Remove");
            Console.WriteLine(abc.Remove(10)); //este elimina todos los caracteres menos los primeros 10
            Console.WriteLine(abc.Remove(10, 10)); // este elimina los caracteres que esten entre la letra "10" hasta las siguientes 10 letras
            Console.WriteLine("SubString");
            Console.WriteLine(abc.Substring(10)); //este toma apartir de la letra "10" en adelante
            Console.WriteLine(abc.Substring(10, 10)); // lo mismo que arriba pero limita obtener hasta  10 letras

            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
