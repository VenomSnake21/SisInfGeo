using System;
using System.Threading;

namespace _27.Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Principal";

            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            t1.Name = "Thread1";
            t2.Name = "Thread2";

            t1.Start();
            t2.Start();

            Imprime();

            Console.WriteLine("Saludos desde Main, se ha terminado todo");
        }

        static void Imprime(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}
