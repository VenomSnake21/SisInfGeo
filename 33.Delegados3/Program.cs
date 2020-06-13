using System;

namespace _33.Delegados3
{

    public delegate int MiDelegado(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1 = A.MetodoA;
            MiDelegado d2 = B.MetodoB;

            Console.WriteLine($"La suma                   es {d1(10,20)}");
            Console.WriteLine($"La multiplicacion         es {d2(10,20)}");
            Console.WriteLine();

            MiDelegado d = d1 + d2;

            Console.WriteLine($"El resultado              es {d(10,20)}");
            Console.WriteLine();

            Console.WriteLine();
        }
    }

    public class A{
        public static int MetodoA(int a, int b){
            return a + b;
        }
    }

    public class B{
        public static int MetodoB(int a, int b){
            return a * b;
        }
    }
}
