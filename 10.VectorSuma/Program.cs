using System;

namespace _10.VectorSuma
{
    class Program
    {
        static void Main(string[] args)
        {   

            double sumapos = 0;

            const int MAX = 30;

            double[] A = new double[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(-10, 10);
            }

            Console.WriteLine("Suma de vectores separados en num pos y num neg con 15 elementos\n");

            imprime(A);

            Console.WriteLine($"Suma de los numeros pos = {sumapos = sumpos(A)}");
        }

        static void imprime(double [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }

        static double sumpos(double[] v){
            double suma = 0;
            int contp = 0, contn = 0, contz = 0;
            for(int i = 0; i < v.Length; i++){
                if(v[i] > 0){
                    contp++;
                    suma += v[i];
                }else if(v[i]< 0){
                    contn ++;
                }else{
                    contz ++;
                }
            }
            Console.WriteLine($"Hay {contp} numeros positivos");
            Console.WriteLine($"Hay {contn} numeros negativos");
            Console.WriteLine($"Hay {contz} numeros ceros");

            return suma;
        }
    }
}