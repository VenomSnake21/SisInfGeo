using System;
using System.Diagnostics;
using System.Ling;
using System.Collections;

namespace _36.Sistema1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Lenght < 1) Menu();
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                switch (int.Parse(args[0]))
                {
                    case 1: InfoSistema(); break;
                    case 2: Procesos(); break;
                    case 3: ProcesoActual(); break;
                    case 4: HilosyModulos(int.Parse(args[1])); break; 
                    default: Console.WriteLine("Opcion invalida ..."); break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void Menu(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[-] Menu: Procesos, hilos, modulos\n");
            Console.WriteLine("[-] Informacion del sistema  ................... [1]");
            Console.WriteLine("[-] Visualizar procesos del sistema  ........... [2]");
            Console.WriteLine("[-] Visualizar el proceso actual  .............. [3]");
            Console.WriteLine("[-] Ver hilos y modulos de un proceso dado  .... [4]");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void InfoSistema(){
            Console.WriteLine($"Numero de Procesadores : {Environment.ProcessorCount}");
            Console.WriteLine($"Usuario activo         : {Environment.UserName}");
            Console.WriteLine($"Dot Net.Core version   : {Environment.Version}");
            Console.WriteLine($"Version de SO          : {Environment.OSVersion}");
            Console.WriteLine($"Nombre de la maquina   : {Environment.MachineName}");
            Console.WriteLine($"Sistema es 64 bits     : {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Directorio actual      : {Environment.CurrentDirectory}");
            Console.WriteLine($"Unidades Logicas       : {Environment.GetLogicalDrives().Count()}");
            foreach (string drv in Environment.GetLogicalDrives()) Console.WriteLine($"{drv} ");
            Console.WriteLine($"\nVariables de entorno : {EnvironmentVariables() Console.Write($"{var.Key, -35} = {var.Value}\n")}");
        }

        static void Procesos(){
            var procesos = (from proc in Process.GetProcesses() orderby proc.ProcessName select proc).ToList();
            Console.WriteLine($"Procesos del sistema: {procesos.Count}");
            procesos.ForEach(p => Console.WriteLine($"{p.Id} {p.ProcessName}"));
            Console.WriteLine();
        }

        static void ProcesoActual(){
            var pa = Process.GetCurrentProcess();
            Console.WriteLine("El proceso que se ejecuta actualmente: ");
            Console.WriteLine($"{pa.Id} {pa.ProcessName} {pa.StartTime}\n");
        }

        static void HilosyModulos(int proceso){
            try{
                Process pr = Process.GetProcessById(proceso);
                Console.WriteLine("\nInformacion de un proceso:");
                Console.WriteLine($"{pr.Id} {pr.ProcessName}");

                ProcessThreadCollection hilos = pr.Threads;
                Console.WriteLine($"\n>> Hilos en este proceso: {hilos.Count}");
                foreach(ProcessThread hilo in hilos){
                    Console.WriteLine($"{hilo.Id} {hilo.ThreadState} {hilo.StartTime} {hilo. PriorityLevel}");
                }

                ProcessModuleCollection modulos = pr.Modules;
                Console.WriteLine("\n>> Modulos del proceso: ");
                foreach (ProcessModule mod in modulos)
                {
                    Console.WriteLine($"{mod.ModuleName}");
                }
            }
            catch( ArgumentException err){
                Console.WriteLine(err.Message);
            }
        }
    }
}
