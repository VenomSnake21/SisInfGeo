using System;
using System.Collections.Generic;

namespace E1.PrimerParcial
{
    //Codigo creado y tecleado artesanalmente por César Abraham Coronado Luna
    //Posdata esta clase fue la más facil de programar pero más dificil de entender conceptualmente hablando
    [Serializable()]
    
    class Red{
        private string empresa;
        private string propietario; 
        private string domicilio;
        private List <Nodo> nodos;

        public Red(){
            nodos = new List<Nodo>();
        }

        public Red(string empresa, string propietario, string domicilio){
            this.empresa = empresa;
            this.propietario = propietario;
            this.domicilio = domicilio;
            nodos = new List <Nodo>();
        }

        public string Empresa{
            get{return empresa; }
            set{empresa = value; }
        }

        public string Propietario{
            get{return propietario; }
            set{propietario = value; }
        }

        public string Domicilio{
            get{return domicilio; }
            set{domicilio = value; }
        }
        public List <Nodo> Nodos{
            get{ return nodos;}
            set{ nodos = value;}
        }
        public void AgregarNodo(Nodo nod){
            nodos.Add(nod);
        }
        public int TotalVul(){
            int tot = 0;
            foreach(Nodo n in nodos){
                tot+= n.Vulneravilidad.Count;
            }
            return tot;
        }
        public int MaySal(){
            int sal1 = 0;
            foreach(Nodo n in nodos){
                sal1 += n.Saltos;
            }
            return sal1;
        }
        public int MenSal(){
            int sal2 = 100;
            foreach(Nodo n in nodos){
                if(n.Saltos < sal2)
                    sal2 = n.Saltos;
            }
            return sal2;
        }
    }   
}