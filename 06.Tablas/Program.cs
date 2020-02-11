using System;

namespace _06.Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent = int.Parse(args[0]);
            int muini = int.Parse(args[1]);
            int mufin = int.Parse(args[2]);
            int muinin = int.Parse(args[3]);
            int muinfi = int.Parse(args[4]);

            Console.WriteLine($"A continuacion imprimiremos la tabla del {ent}\n");

            for(int i = 1; i < 11; i++){
                int multi = i * ent;
                Console.WriteLine($"{ent} x {i} = {multi}");
            }

            Console.WriteLine($"\n\nAhora multiplicaremos del {muini} al {mufin} en un intervalo que inicia de {muinin} al {muinfi}");

            for(int i = muini; i <= mufin; i++){
                for(int j = muinin; j <= muinfi; j++){
                    int multi = i * j;
                    Console.WriteLine($"{i} * {j} = {multi}");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
