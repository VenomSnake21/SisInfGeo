using System;

namespace _31.Delegados1
{
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d;

            Console.Clear();

            d = Mensajes.Mensaje1;
            d("Juan");

            d = Mensajes.Mensaje2;
            d("Jose");

            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d("Carlos");

            Console.WriteLine();
        }
    }

    public class Mensajes {
        public static void Mensaje1(string msj){
            Console.WriteLine($"{msj} - lleva el pastel");
        }

        public static void Mensaje2(string msj){
            Console.WriteLine($"{msj} - fue el culpable de que se cancele la fiesta");
        }
    }
}
