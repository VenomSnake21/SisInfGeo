using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pieza> mp = new List<Pieza>();

            //Agregar elementos a la lista
            mp.Add(new Pieza(1234, "Tuerca de rosc interior"));
            mp.Add(new Pieza(5678, "Tornillo de Pulgada para concreto de 1/4"));
            mp.Add(new Pieza(9345, "Bateria 12 v"));

            //Agregar un rango de elementos
            var proveedor = new List<Pieza>(){
                new Pieza(8888, "Tornillo de cabeza pequena"),
                new Pieza(9999, "Cables para pasar corriente"),
                new Pieza(7777, "Tridente del diablo")
            };

            mp.AddRange(proveedor);

            //Imprime el contenido de la lista
            mp.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("----------------------------------");

            mp.RemoveAt(mp.Count -2);

            //inserta un elemento en la 2da posicion
            mp.Insert(1, new Pieza(2222, "Caja de 8 velocidades"));
            mp.ForEach(p => Console.WriteLine(p.ToString()));
            
            //busca las piezas que sean tornillo
            Console.WriteLine("----------------------------------");
            var t = mp.FindAll(x => x.Nombre.Contains("Tornillo"));
            t.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
