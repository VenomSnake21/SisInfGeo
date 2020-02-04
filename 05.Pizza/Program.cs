using System;

namespace _05.Pizza
{
    class Program
    {
        static int Main(string[] args){

            if (args.Length == 0){
                Menu();
                return 1;
            }

            char tam = char.Parse(args[0]);
            string[] ings = args[1].Split("+");
            char cub = char.Parse(args[2]);
            char don = char.Parse(args[3]);

            string tamano = "", ingredientes  = "", cubierta = "", donde = "";

            if(tam == 'p') tamano = "Pequeña";
            else if(tam == 'm') tamano = "Mediano";
            else tamano = "Grande";

            foreach(string i in ings){
                switch(char.Parse(i)){
                    case'e': ingredientes += "Extra queso, "; break;
                    case'c': ingredientes += "Champiñones, "; break;
                    case't': ingredientes += "Tomates, "; break;
                }
            }

            if(cub == 'd') cubierta = "Delgada"; else cubierta = "Gruesa";

            if(don == 'c') donde = "Comer aqui"; else donde = "Para llevar";

            Console.Clear();

            Console.WriteLine($"Tamaño        : {tamano}");
            Console.WriteLine($"Ingredientes  : {ingredientes}");
            Console.WriteLine($"Cubierta      : {cubierta}");
            Console.WriteLine($"Lugar         : {donde}");

            return 0;
        }

        static void Menu(){
            Console.WriteLine("Bienvenido a Chess Pizzas, a continuacion le mostraremos un menu para que procese su pedido\n\nTamaño: (P)equeña, (M)ediana o (G)rande  \n Ingredientes: (E)xtra Queso, (C)hampiñones, (T)omates  \n Cubierta:  (D)elgada o (G)ruesa  \n Donde se consume:  (C)omer aquí o Para (L)levar\n\n");
        }
    }
}
