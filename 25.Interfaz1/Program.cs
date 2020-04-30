using System;

namespace _25.Interfaz1
{
    public class Program
    {

        static void Main(string[] args)
        {
            Perro perro = new Perro("Juan");
            Console.WriteLine($"{perro.Nombre}");
            perro.Llorar();
        }
    }
}
