using System;

namespace C2_estructuras_de_datos__DateTime__TimeSpan__GUID_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021,4,13,16,40,0); // año,mes,dia,hora,min,seg   ---- fecha cualquiera
            Console.WriteLine(dt.ToString());
            DateTime hoy = DateTime.Today; //DECLARA UNA VARIABLE DE LA DECHA DE HOY DESDE LAS 00:00:00
            DateTime ahora = DateTime.Now; //DECLARA UNA VARIABLE DE HOY EN LA HORA ACTUAL QUE SE EJECUTA
            Console.WriteLine("Hoy {0} , ahora {1}" , hoy,ahora);
            Console.WriteLine("Hoy {0} , ahora {1}", hoy.ToString("T"), ahora.ToString("T"));  //CON "T" resumo el dato de tiempo

            TimeSpan ts = ahora - hoy; //con timespan obtengo invervalos de tiempo X-Y
            Console.WriteLine(ts);
            Console.WriteLine(ts.TotalSeconds); // con TotalSeconds muestro la cantidad de segundos transcuridos

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);
        }
    }
}
