using System;

namespace _13.VectorEstadistico
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = 0;
            double numMay = 0;
            double numMen = 0;

            const int MAX = 10;

            //promedio, numero mayor, numero menor la varianza, desviacion estandar
            

            double[] A = new double[MAX];

            Random aleatorio = new Random();

            for(int i = 0; i < MAX; i++){
                A[i] = aleatorio.Next(-10, 10);
            }

            Console.WriteLine("Suma de vectores separados en num pos y num neg con 15 elementos\n");

            promedio = promedioinador(A);
            numMay = mayorizadoinador(A);
            imprimidor(A);
            numMen = numeromenor(A);
            impfinal(A, promedio, numMay, numMen);
        }

        static void imprimidor(double [] v){
            for(int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]}");
            Console.WriteLine();
        }

        static void impfinal(double[] v, double madre, double mia, double juan){
            Console.WriteLine($"El promedio es {madre}");
            Console.WriteLine($"El numero más grande fue {mia}");
            Console.WriteLine($"El numero más pequeño fue {juan}");
        }

        static double promedioinador(double[] carbon){
            double suma = 0;
            for(int i = 0; i < carbon.Length; i++){
                suma += carbon[i];
            }
            return suma/carbon.Length;
        }

        static double mayorizadoinador(double[] carnita){
            double mayor = 0;
            mayor = carnita[0];
            for(int i = 1; i < carnita.Length; i++)
                if(mayor < carnita[i])
                    mayor = carnita[i];
            return mayor;
        }

        static double numeromenor(double[] asada){
            double menor = 0;
            menor = asada[0];
            for(int i = 0; i < asada.Length; i++)
                if(asada[i] < menor)
                    menor = asada[i];
            
            return menor;
        }
    }
}
