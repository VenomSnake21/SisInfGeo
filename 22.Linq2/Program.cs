using System;
using System.Linq;
using System.Collections.Generic;

namespace _22.Linq2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] frutas = new string[] {
                "mango", "cereza", "kiwi"
            };

            var qry1 = 
                (from fruta in frutas
                where fruta.StartsWith("m")
                select fruta);

            foreach (var f in qry1)
                Console.WriteLine(f);

            var qry2 = 
                (from fruta in frutas
                where fruta.Contains ("an")
                select fruta);
        }
    }
}
