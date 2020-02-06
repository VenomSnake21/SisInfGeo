using System;

namespace _07.VectorPromedio
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] vector = {10, 20 , 22, 33, 22, 55, 43, 23, 12, 22, 10, 20 , 22, 33, 22, 55, 43, 23, 12, 22, 
                            10, 20 , 22, 33, 22, 55, 43, 23, 12, 22, 
                            10, 20 , 22, 33, 22, 55, 43, 23, 12, 22, 
                            10, 20 , 22, 33, 22, 55, 43, 23, 12, 22,};

            Console.WriteLine("Calcular el promedio de 50 valores constantes \n");
            Console.WriteLine("Los elementos del arreglo son: ");
            imprime(vector);

            float promedio = prom(vector);

            Console.WriteLine($"El promedio de el arreglo es: {promedio}");

            mayor(vector, promedio);

        }

        static void imprime(int[] v){
            for(int i = 0; i < v.Length; i++){
                Console.Write($"{v[i]} ");
            }
        }

        static float prom(int[] vec){
            int suma = 0;
            for(int i = 0; i < vec.Length; i++){
                suma += vec[i];
            }
            return suma/ vec.Length;
        }

        static void mayor(int[] vect, float prome){
            int contador = 0;
            for(int i = 0; i < vect.Length; i++)
                if(vect[i] > prome)
                    contador ++;

            Console.WriteLine($"En total hay {contador} numeros mayores al promedio");
        }

    }
}
