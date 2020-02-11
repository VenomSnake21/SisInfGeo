using System;

namespace _11.VectorInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 15;

            double[] A = new double[MAX];
            double[] B = new double[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(-10, 10);
            }

            inversor(A,B);

            Console.WriteLine("Arreglo normal");
            imprimidor(A);
            Console.WriteLine("Arreglo invertido");
            imprimidor(B);


        }

        static void imprimidor(double [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }

        static void inversor(double [] arre, double [] jalele){
            int inv = arre.Length - 1;
            for(int i = 0; i < jalele.Length; i++){
                jalele[i] = arre[inv];
                inv--;
            }
        }
    }
}
