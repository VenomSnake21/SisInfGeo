using System;

namespace _20.Listasv2{
    class Pieza{

        public Pieza(int id, string nombre) => (Id, Nombre) = (id, nombre);
        public int Id {get; set;}
        public string Nombre{get; set;}

        public override string ToString() => $"{Id} - {Nombre}";

    }
}