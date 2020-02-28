using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado  empleado01= new empleado();

            empleado empleado02;

            empleado02 = new empleado();

            empleado01.Nombre= "Wade Perez";
            empleado01.Edad = 21;

            //empleado02.Nombre = "";

            //Console.WriteLine($"Nombre: {empleado01.Nombre} \nEdad: {empleado01.Edad}");
            Console.WriteLine(empleado01.ToString());

            Console.WriteLine($"Te vas de vacaciones {DateTime.Now.ToString("dd/MM/yy")}");
            Console.WriteLine($"Regresas: {empleado01.Vacaciones(DateTime.Now, 30)}");
        }
    }
}
