using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, base1, area;

            Console.WriteLine("programa que calcula el area de un triangulo");

            Console.WriteLine("Dame la base: ");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Dame la altura: ");
            altura = double.Parse(Console.ReadLine());

            area = (base1 * altura) / 2;
            
            Console.WriteLine($"El area del triangulo es: {area}");
            Console.ReadLine();
        }
    }
}
