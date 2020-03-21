using System;
using System.Linq;
using System.Collections.Generic;

namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {   


            int[] numeros = new int[] {10, 20, 30, 35, 40, 45, 50, 55, 60, 65, 70, 80, 85, 90, 100, 200, 300, 400, 500, 600, -10, -20, -15};

            //Realizar consulta
            var consulta = 
                from num in numeros
                where num%2 == 0
                select num;

            //Ejecutar Consulta
            foreach (var num in consulta)
                Console.WriteLine($"{num}");
            
            //Consulta 2
            var consulta2 = 
                from num in numeros
                where (num%2) != 0
                select num;

            var consulta3 =
                (from num in numeros
                where num < 0
                select num ).ToList();

            Console.WriteLine();
            Console.WriteLine("\nNumeros mayores a 100\n");
            for (int i = 0; i < consulta2.Count(); i++)
            {
                Console.WriteLine($"consulta2[i] ");
            }
        }
    }
}
