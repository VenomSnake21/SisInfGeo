using System;

namespace _25.Interfaz1
{
        class Gato : IAnimal{
            public Gato(string nombre){
                this.Nombre = nombre;
            } 
            public string Nombre {get; set;}
            public void Llorar() => Console.WriteLine("miau miau");
        }
}
