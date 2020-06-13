using System;

namespace _32.Delegados2
{

    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d;

            Console.Clear();

            d1 = Delegados.Mensaje1;
            d2 = Delegados.Mensaje2;

            d = d1 + d2;
            d("El Peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d += d3;
            d("El Borolas");
            Console.WriteLine();

            d -= d2;
            d("Peña");
            Console.WriteLine();

            d -= d1;
            d("Tello");
            Console.WriteLine();
        }
    }

    public class Delegados{
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel");
        }

        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable de que se cancele la fiesta");
        }
    }
}
