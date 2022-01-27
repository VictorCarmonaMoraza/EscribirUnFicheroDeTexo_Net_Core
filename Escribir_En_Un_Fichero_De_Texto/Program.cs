using System;
using System.IO;

namespace Escribir_En_Un_Fichero_De_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Prueba2.txt");

            string[] texto =
            {
                "Hola a todos",
                "Estoy escribiendo",
                "en diferentes",
                "lineas"
            };

            //Recorro el texto y voy escribiendo
            foreach (var linea  in texto)
            {
                sw.WriteLine(linea);
            }
            //Cerramos el fichero
            sw.Close();

            Console.WriteLine("El fichero ha sido escrito");

            Console.ReadLine();
        }
    }
}
