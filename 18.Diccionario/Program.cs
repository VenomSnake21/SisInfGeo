using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> midic = new Dictionary <string, string>();
            //y así se agrega y prdena alfabeticamente
            SortedDictionary<string, string> midic = new SortedDictionary<string, string>();

            //Agrega entradas al diccionario

            midic.Add("txt", "archivo de texto");
            midic.Add("jpg", "Archivo de imagen");
            midic.Add("mp3", "Archivo de sonido");
            midic.Add("htm", "Archivo de HTML");
            midic.Add("exe", "Archivo ejecutable de windows");
            midic.Add("lll", "Archivo de tipo desconocido");

            //Acceder a un elemento en base a la llave

            Console.WriteLine(midic["htm"]);
            
            //Verificiar si una llave existe, si no agregar la

            if(midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else
                midic.Add("elf", "Archivo ejecutable de Linux");
            
            //Borrar una llave
            if(midic.ContainsKey("lll"))
                midic.Remove("lll");

            //Recorrer el diccionario e imprimir la llave y su valor
            foreach (KeyValuePair<string, string> val in midic)
            {
                Console.WriteLine($"{val.Key} - {val.Value}");

            }

            //imprimir solo las lalves del diccionario
            foreach (string llave in midic.Keys)
            {
                Console.WriteLine(llave);
            }
            //borrar una entrada si la lalve existe
            //if(midic.ContainsKey)
        }
    }
}
