using System;
using System.IO;

namespace Escribir_En_Un_Fichero_De_Texto
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //Con esta manera machaca elfichero si ya estaba creado
                //StreamWriter sw = new StreamWriter("Prueba2.txt");
                //Con el true continua escribiendo pero no machaca el fichero
                StreamWriter sw = new StreamWriter("Prueba2.txt", true);

                string[] texto =
                {
                "Hola a todos",
                "Estoy escribiendo",
                "en diferentes",
                "lineas"
            };

                //Recorro el texto y voy escribiendo
                foreach (var linea in texto)
                {
                    sw.WriteLine(linea);
                }
                //Cerramos el fichero
                sw.Close();

                Console.WriteLine("El fichero ha sido escrito");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
