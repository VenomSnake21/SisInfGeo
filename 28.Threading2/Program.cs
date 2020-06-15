using System;
using System.Threading;

namespace _28.Threading2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                Thread t = new Thread(Imprime);
                t.Start(i);
            }
        }

        static void Imprime(object o){
            int s = 0;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Imprime en hilo {o} / {i}");
                s += i;
            }   
            Console.WriteLine($"Suma hilo {o} = {s} ");
        }
    }
}
