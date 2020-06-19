using System;

namespace E3.TercerExamen
{
    class Program
    {
        static void Main(string[] args)
        {   

            int opc = 1;

            do
            {
                opc = Menu();

                switch (opc)
                {
                    case (1): Opc1(); break;
                    case (2): Opc2(); break;
                    case (3): Opc3(); break;
                    case (4): Opc4(); break;
                    case (5): Opc5(); break;
                    case (6): Opc6(); break;
                    case (7): Opc7(); break;
                    case (8): Opc8(); break;
                }

            } while (opc != 0);
        }

        static int Menu(){
            int opcion;

            Console.Clear();
            Console.WriteLine("Bienvenido al programa final creado por César Luna\nA continuacion se le daran algunas opciones de las novedades C#8: ");
            Console.WriteLine("\n\t\t[1] Miembros de solo lectura .....");
            Console.WriteLine("\t\t[2] Expresiones Switch ...........");
            Console.WriteLine("\t\t[3] Patrones de propiedades ......");
            Console.WriteLine("\t\t[4] Patrones de tupla ............");
            Console.WriteLine("\t\t[5] Patrones de posicionales .....");
            Console.WriteLine("\t\t[6] Declaraciones de Using .......");
            Console.WriteLine("\t\t[7] Funciones locales estaticas ..");
            Console.WriteLine("\t\t[8] Indices y Rangos .............");
            Console.WriteLine("\t\t[0] Salir ........................");

            Console.WriteLine("\n\nOpcion: ");
            opcion = int.Parse(Console.ReadLine());

            return opcion;
        }

        static void Reg(){
            char opr;
            Console.WriteLine("\n\n Desea usted regresar al menu?: a = si, b = salir");
            opr = char.Parse(Console.ReadLine());

            if(opr == 'a'){
                Menu();
            }
        }

        static void Opc1(){
            Console.Clear();
            Console.WriteLine("En este sector tenemos que podemos declarar como null algunas variables, por ejemplo: ");

            //int entero = null; Este te salta un error
            int? entero = null; // Con el nuevo C# 8 este se puede imprimir

            //Console.WriteLine($"La variable es {entero}"); Lo malo es que la forma de imprimir es diferente
            Console.WriteLine($"La variable es {entero ?? "null"}"); //Así se imprime que es null, solo tenemos que poner que queremos imprimir, ejemplo null

            Reg();
        }
        static void Opc2(){
            char op2;
            Console.Clear();
            Console.WriteLine("Como novedades tenemos que le switch se le cambio un poco la estructa");

            Console.WriteLine("Si usted elige a se imprime un hola y el programa termina, si usted preciona b se regresa al menu principal");
            op2 = char.Parse(Console.ReadLine());

            switch (op2)
            {
                op2 when a => Console.WriteLine("Hola :3"); break;
                op2 when b => Menu(); break;
            };
        }
        static void Opc3(){
            Console.Clear();
            Console.WriteLine("Ahora en C# 8 se puede asignar valores a variables especificas, un ejemplo:");
            Console.WriteLine("Supongamos que se le pide a usted el nombre de su estado, ejemplo 'ZA' = Zacatecas");
            Console.WriteLine("Ahora se le puede asignar un valor a esa opcion, y usted debería pagar + 0.06% de tenencia pa la uaz");
            //public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            //    location switch
            //{
            //    { State: "ZA" } => tenencia * 0.06M,
            //    { State: "DU" } => tenencia * 0.075M,
            //    { State: "MI" } => tenencia * 0.05M,
            //    // Los demas casos cambian a 0
        _   //    => 0M
            //};

            Reg();
        }
        static void Opc4(){
            Console.Clear();
            Console.WriteLine("Los patrones de tupla nos permiten ahora crear algoritmos los cuales pueden auto concluirse, ejemplo seria el piedra papel tijeras... el cual esta en el codigo");
            //public static string PiedraPapelTijeras(string primera, string segunda)
            //    => (primera, segunda) switch{
            //("piedra", "papel") => "El papel cubre la piedra. Papel gana.",
            //("piedra", "tijeras") => "La piedra rompe las tijeras. Piedra gana.",
            //("papel", "piedra") => "El papel cubre la rocka. Papel gana.",
            //("papel", "tijeras") => "Las tijeras cortan el papel. Tijeras ganan.",
            //("tijeras", "piedra") => "La piedra rombe las tijeras. La buena piedra, nada le gana.",
            //("tijeras", "papel") => "Las tijeras rompen el papel. Tijeras ganan.",
            //(_, _) => "Empate"
            //};

            Reg();
        }
        static void Opc5(){
            Console.Clear();
            Console.WriteLine("Ahora similar al caso 3 se le puede asignar un patron a las posiciones, por ejemplo:");
            Console.WriteLine("Si un programa pide su edad (por ejemplo) a este numero se le puede asignar un patron");
            Console.WriteLine("Ejemplo:  edad < 15 => Riesgo.Bajo, edad > 15 && edad < 60 => Riesgo.Medio,  edad > 60 => Riesgo.Alto");
            Console.WriteLine("Al pedir la edad se pueden asignar riesgos de cuanto afecta el covid segun la edad");

            Reg();
        }
        static void Opc6(){
            using int numero;
            Console.Clear();
            Console.WriteLine("Using indica al compilador que la variable que se declara debe eliminarse al final del ámbito de inclusión, por ejemplo:");
            Console.WriteLine("Introduzca un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Felicidades el numero que usted ingreso dejara de ser parte de la memoria de su computadora gracias al using");

            Reg();
        }
        static void Opc7(){
            Console.Clear();
            Console.WriteLine("En este caso se agrego Static ... El cual encapsula y vuelve local el valor donde se utilice el static");
            Console.WriteLine("Por ejemplo si tenemos static int Add(int a, int b) => a + b; El programa sumara en esa funcion a+b y solo en esa funcion");

            Reg();
        }
        static void Opc8(){
            Console.Clear();
            var gente = new string[] {
            "Hola", "Buenas", "Tardes", "Como", 
            "Esta", "Usted", "Hoy", ?
            };
            Console.WriteLine("En este nuevo caso en los rangos e indices se agrego el  ^  Lo que indica el rango contrario, ejemplo de un arreglo normal: ");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{gente[i]}");
            }
            Console.WriteLine("Ahora usaremos el mismo for con un cambio minusculo que imprimira al reves el mismo arreglo");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"{gente[^i]}");
            }

            Reg();
        }
    }
}
