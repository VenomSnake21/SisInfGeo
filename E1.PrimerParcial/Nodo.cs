using System;
using System.Collections.Generic;

namespace E1.PrimerParcial
{
    //Codigo creado y tecleado artesanalmente por César Abraham Coronado Luna
    [Serializable()]
    class Nodo
    {
        private string ip;
        private string tipo; //servidor, equipoactivo, computadora
        private int puertos;
        private int saltos;
        private string so;    //windows, linux, ios, otro
        private List <Vulnerabilidad> vulnerabilidades;

        public Nodo(string ip, string tipo, int puertos, int saltos, string so){
            this.ip = ip;
            this.tipo = tipo;
            this.puertos = puertos;
            this.saltos = saltos;
            this.so = so;
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        public string Ip{
            get{return ip;} 
            set{ ip = value;}
        }
        public string Tipo{
            get{return tipo;} 
            set{tipo = value;}
        }
        public int Puertos{
            get{return puertos;} 
            set{puertos = value;}
        }
        public int Saltos{
            get{return saltos;} 
            set{saltos = value;}
        }
        public string So{
            get{return so;} 
            set{so = value;}
        }
        public List <Vulnerabilidad> Vulneravilidad{
            get{ return vulnerabilidades;}
            set{ vulnerabilidades = value;}
        }
        public void AgregarVulnerabilidad(Vulnerabilidad vul){
            vulnerabilidades.Add(vul);
        }
    }
}