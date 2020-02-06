using System;

namespace _08.VectorAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 15;

            int[] A = new int[MAX];
            int[] B = new int[MAX];
            int[] C = new int[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(1, 100);
                B[i] = aleatorio.Next(1, 100);
                C[i] = A[i] + B[i];
            }

            Console.WriteLine("Suma de 2 vectores aleaotorios con 15 elementos\n");

            imprime(A);
            imprime(B);
            imprime(C);
        }
        static void imprime(int [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }
    }
}
