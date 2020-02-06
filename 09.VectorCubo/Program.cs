using System;

namespace _09.VectorCubo
{
    class Program
    {
        static void Main(string[] args)
        {
           const int MAX = 30;

            double[] A = new double[MAX];
            double[] B = new double[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(1, 10);
                B[i] = Math.Pow(A[i],3);
            }

            Console.WriteLine("Suma de 2 vectores aleaotorios con 15 elementos\n");

            imprime(A);
            imprime(B);
        }
        static void imprime(double [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }
    }
}
