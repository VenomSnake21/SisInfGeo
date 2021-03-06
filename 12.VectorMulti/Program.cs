﻿using System;

namespace _12.VectorMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10;

            double[] A = new double[MAX];
            double[] B = new double[MAX];
            double[] C = new double[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++)
                A[i] = aleatorio.Next(-10, 10);

            for(int i = 0; i < MAX; i++)
                B[i] = aleatorio.Next(-10, 10);

            multiplisor(A,B,C);

            Console.WriteLine("Arreglo A");
            imprimidor(A);
            Console.WriteLine("Arreglo B");
            imprimidor(B);
            Console.WriteLine("Arreglo C");
            imprimidor(C);

        }

        static void imprimidor(double [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }

        static void multiplisor(double [] pariente, double [] jaina, double [] buchon){
            int inv = pariente.Length - 1;
            for(int i = 0; i < jaina.Length; i++){
                buchon[i] = pariente[i] * jaina[inv];
                inv--;
                }
            }
        }
}
