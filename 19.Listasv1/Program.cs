using System;
using System.Collections.Generic;

namespace _19.Listasv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definir lista de valores iniciales
            List<string> mats = new List<string>(){
                "Calculo I",
                "Redaccion Avanzada",
                "Introduccion a la Ingenieria"
            };
            //agregar elementos a la lista
            mats.Add("Matematicas discretas");
            mats.Add("Compiladores e interpretes");

            Imprime(mats);

            //Agregar un rango de materias
            string[] mopt = {
                "Sistemas de info Geo (op)",
                "Seguridad en Redes (op)",
                "Topicos Selectos de Redes (op)"
            };

            mats.AddRange(mopt);

            Console.WriteLine("---------------------------------");

            Imprime(mats);

            //mats.Reverse(); voltea el orden de los valores

            //mats.Sort(); los orden

            //Buscar un elemento
            Console.WriteLine("Busca aun materia que tenga la palabra Discretas");
            string mat = mats.Find(x => x.Contains("Discretas"));

            Console.WriteLine(mat);

            //Buscar todas las ocurrencias de una lista en abse a auna condicion
            Console.WriteLine("Buscar todas las materias que contengan (op)");
            var ms = mats.FindAll(x => x.Contains("(op)"));
            Imprime(ms);
        }

        static void Imprime(List<string> lista){
            foreach (string m in lista)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(lista.Count);
        }
    }
}
