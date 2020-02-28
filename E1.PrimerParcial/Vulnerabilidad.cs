using System;

namespace E1.PrimerParcial
{
    //Codigo creado y tecleado artesanalmente por César Abraham Coronado Luna
    [Serializable()]

    class Vulnerabilidad{
        private string clave;
        private string vendedor;
        private string descripcion; 
        private string tipo;//local o remota 
        private DateTime fecha;

        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha){
            this.clave = clave;
            this.vendedor = vendedor;
            this.descripcion = descripcion;
            this.tipo = tipo;
            this.fecha = fecha;
        }

        public string Clave{
            get{return clave;}
            set{clave = value;}
        }
        public string Vendedor{
            get{return vendedor;}
            set{vendedor = value;}
        }
        public string Descripcion{
            get{return descripcion;}
            set{descripcion = value;}
        }
        public string Tipo{
            get{return tipo;}
            set{tipo = value;}
        }
        public DateTime Fecha{
            get{return fecha;}
            set{fecha = value;}
        }
        public int Anti(){
            DateTime newDate = DateTime.Now;
            DateTime oldDate = fecha;
            TimeSpan ts = newDate - oldDate;

            int anti = ts.Days/365;
            return anti;
        }
    }
}