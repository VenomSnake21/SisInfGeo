using System;

namespace ej1
{
    class empleado
    {
        private string nombre;
        private int edad;


        public empleado(){
        }
        public empleado(string nombre, int edad){
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre{
            get{return nombre;}
            set{nombre = value;}
        }

        public int Edad{
            get{return edad;}
            set{edad = value;}
        }

        public string Vacaciones(DateTime ini, int dias){
            DateTime fin;
            fin = ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }

        public override string ToString() {
            return $"Nombre: {nombre}\nEdad: {edad}";
        }
    }
}