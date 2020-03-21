using System;
using System.Linq;
using System.Collections.Generic;

namespace _23.Linq3
{
    class Program{
        static void Main(string[] args){
            List<Estudiante> grupo = new List<Estudiante>();

            grupo.Add(
                new Estudiante {Id = 1234, Nombre = "Maria",
                Ciudad = "Fresnillo", Calle = "Benito Juarez",
                Cals = new List<int> {90, 80, 70, 60}
                }
            );

            grupo.Add(
                new Estudiante {Id = 1234, Nombre = "Pedro",
                Ciudad = "Fresnillo", Calle = "Benito Juarez",
                Cals = new List<int> {90, 80, 90, 70}
                }
            );
            grupo.Add(
                new Estudiante {Id = 1234, Nombre = "Jorge",
                Ciudad = "Jerez", Calle = "Africa",
                Cals = new List<int> {50, 40, 60, 90}
                }
            );
            grupo.Add(
                new Estudiante {Id = 1234, Nombre = "Miguel",
                Ciudad = "Jalpa", Calle = "Barbosa",
                Cals = new List<int> {80, 90, 60, 70}
                }
            );
            grupo.Add(
                new Estudiante {Id = 1234, Nombre = "Lola",
                Ciudad = "Zacatecas", Calle = "El Vergel",
                Cals = new List<int> {50, 80, 70, 50}
                }
            );

            //Imprimir todos los datos
            Console.WriteLine("\nTodo de todo: \n");
        
            grupo.ForEach(est=> Console.WriteLine(est.ToString()));

            var q1 = (from est in grupo orderby est.Nombre select est).ToList();
            q1.ForEach(est=> Console.WriteLine(est.ToString()));

            var q2 = from est in grupo group est by est.Ciudad;
            foreach (var ciudad in q2)
            {   
                Console.WriteLine(est.ToString());    
            }
        }
    }
}
