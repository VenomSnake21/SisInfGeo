using System;

namespace _26.Interfaz2
{

    public class Organismo{
        public void Respiracion(){
            Console.WriteLine("Respiración");
        }
        public void Movimiento(){
            Console.WriteLine("Movimiento");
        }
        public void Crecimiento(){
            Console.WriteLine("Crecimiento");
        }
    }

    public interface iAnimales{
        void MultiCelular();
        void SangreCaliente();
    }

    public interface ICanino : iAnimales{
        void Corre();
        void CuatroPatas();
    }

    public class Perro : Organismo, ICanino{
        public void Corre(){
            Console.WriteLine("Corre");
        }
        public void CuatroPatas(){
            Console.WriteLine("Cuatro Patas");
        }
        public void MultiCelular(){
            Console.WriteLine("Multicelular");
        }
        public void SangreCaliente(){
            Console.WriteLine("Sangre Caliente");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Console.WriteLine("\nCaracteristicas del Perro");
            perro.Respiracion();
            perro.Movimiento();
        }
    }
}
