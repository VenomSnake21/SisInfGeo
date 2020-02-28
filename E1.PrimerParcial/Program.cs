using System;
using System.IO;

namespace E1.PrimerParcial
{
    [Serializable()]
    class Program
    {
        static void Main(string[] args)
        {   
            //Codigo creado y tecleado artesanalmente por César Abraham Coronado Luna
            Red mired = null;

            mired = new Red("Siscom", "Luis Garcia", "La esquina que domina");

            Inicializacion(mired);
            Mostrar(mired);
        }
        static void Inicializacion(Red red){
            red.AgregarNodo(new Nodo("192.100.0.10", "server", 5, 2, "Windows"));
            red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2009-2504", "microsoft", "Se quema el server", "Mundial", DateTime.Parse("11/7/2011")));
            red.AgregarNodo(new Nodo("192.100.3.11", "Computadora", 2, 7, "Linux"));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2010-2603", "Cisco", "Falla deposito de dinero", "Remota", DateTime.Parse("1/10/2010")));
            red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2111-2473", "Apple", "Cantidad de retiro erronea", "Local", DateTime.Parse("5/05/2008")));
            red.AgregarNodo(new Nodo("192.100.1.12", "Servecidor", 8, 8, "IOs"));
            red.AgregarNodo(new Nodo("192.100.0.15", "Equipo Activo", 12, 69, "Windows"));
            red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2101-2501", "Space X", "Al tercer intento bloquea la tarjeta", "Remota", DateTime.Parse("11/4/2011")));
            red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2090-2201", "Corsair", "No hay luz", "Distrital", DateTime.Parse("11/3/2002")));
            red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2044-2030", "Razer", "Se callo el sistema", "Mundial", DateTime.Parse("11/9/2001")));
        }
        static void Mostrar(Red red){
            Console.Clear();
            Console.WriteLine($"Empresa:\t {red.Empresa}");
            Console.WriteLine($"Propietario:\t {red.Propietario}");
            Console.WriteLine($"Domicilio:\t {red.Domicilio}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"  >>Total de Nodos: \t{red.Nodos.Count}");
            Console.WriteLine($"  >>Total de Vulnerabilidades: \t{red.TotalVul()}\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"\t>> Datos generales de los nodos: \n");

            foreach(Nodo nodo in red.Nodos){
                    //Aqui imprimimos toda la info de los nodos
                    Console.WriteLine($"Ip:\t{nodo.Ip}, Tipo:\t{nodo.Tipo}, Puertos: {nodo.Puertos}, Saltos: {nodo.Saltos}, SO:\t{nodo.So}, ToVul: {nodo.Vulneravilidad.Count}");
                }

            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($" Mayor numero de saltos: {red.MaySal()}");
            Console.WriteLine($" Menor numero de saltos: {red.MenSal()}\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"  >> Vulnerabilidades por nodo\n");
            Console.WriteLine("------------------------------------------");
            foreach(Nodo nodo in red.Nodos){
                Console.WriteLine($" >Ip: {nodo.Ip}, Tipo: {nodo.Tipo}\n");
                foreach(Vulnerabilidad vul in nodo.Vulneravilidad){
                    //Aqui se imprime la informacion de las vulnerabilidades
                    Console.WriteLine($"Clave: {vul.Clave}, Vendedor: {vul.Vendedor}, Descripcion: {vul.Descripcion},\nTipo: {vul.Tipo}, Fecha: {vul.Fecha}, Antiguedad: {vul.Anti()} años");
                    Console.WriteLine("\n");   
                }
                Console.WriteLine("------------------------------------------\n");
            }
        }
    }
}
