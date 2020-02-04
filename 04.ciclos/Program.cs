using System;

namespace _04.ciclos
{
    class Program
    {
        static int Main(string[] args)
        {   
            int op = 0, cont= 0, sum = 0;

            if(args.Length == 0){
                Menu();   
                return 1;
            }

            int v = int.Parse(args[0]);
            op = v;

            Console.Clear();

            switch (op)
            {   
                case 1: {
                    cont = 1;
                    sum = 0;
                    while(cont <= 100){
                        Console.Write($"{cont} ");
                        sum += cont;
                        cont++;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;

                case 2: {
                    cont = 100;
                    sum = 0;
                    while(cont >= 1){
                        Console.Write($"{cont} ");
                        sum += cont;
                        cont--;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;

                case 3: {
                    sum = 0;
                    for(int i = 50; i <= 200; i++){
                        Console.Write($"{i} ");
                        sum += i;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;
                
                 case 4: {
                    sum = 0;
                    for(int i = 2; i <= 100; i+=2){
                        Console.Write($"{i} ");
                        sum += i;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;

                case 5: {
                    sum = 0;
                    for(int i = 99; i >= 1; i-= 2){
                        Console.Write($"{i} ");
                        sum += i;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;

                case 6: {
                    cont = 272;
                    sum = 0;
                    while(cont >= 40){
                        Console.Write($"{cont} ");
                        sum += cont;
                        cont-=4;
                    }
                    Console.WriteLine($"La suma es: {sum} \n");
                } break;

                default: Console.WriteLine("Opcion invalida"); break;
            }

            return 0;
        }


        static void Menu(){
            Console.Clear();
            Console.WriteLine("Programa sobre el uso de estructuras de control (ciclos pues)\n\n");
            Console.WriteLine("1.- Números del 1 al 100 con ciclo while  \n2.- Números del 100 al 1 con ciclo do .. while  \n3.- Números del 50 al 200 con ciclo for \n4.- Números del 2 al 100 solo los pares con ciclo for \n5.- Números del 99 al 1 solo los impares con ciclo for \n6.- Números del 272 al 40 en decrementos de 4 con ciclo while ");
            Console.WriteLine("\n\nOpcion: ");
        }
    }
}
