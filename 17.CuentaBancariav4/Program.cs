using System;
using System.IO;

namespace _14.CuentaBancaria
{
    [Serializable()]
    class Program
    {
        static void PruebaCuentaBancaria()
        {
            CuentaBancaria chelines = new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear {chelines.Saldo}");
            chelines.Deposita(500);
            Console.WriteLine($"Saldo despues del domingo {chelines.Saldo}");
            if(chelines.Retira(600)) 
                Console.WriteLine($"Saldo despues la peda {chelines.Saldo}");
            else
                Console.WriteLine("No puedes andar organizando fiestas si no tienes dinero");
        }
        

        /*static void PruebaCliente() {
            // Creamos dos objetos tipo Cliente
            Cliente cliente1 = new Cliente("Juan Perez");
            Cliente cliente2 = new Cliente("Maria Lopez");
            Cliente cliente3 = new Cliente("Mario Lopez");
            
            // Creo un objeto tipo Cuenta
            // Creo un objeto tipo Cliente y le asigno la Cuenta creada
            CuentaBancaria cuenta1 = new CuentaBancaria(100);
            cliente1.Cuenta=cuenta1;
            cliente1.Cuenta.Deposita(500);

            // Asigno directamente una nueva CuentaBancaria al Cliente existente
            cliente2.Cuenta=new CuentaBancaria(200);
            cliente3.Cuenta = cliente2.Cuenta;
            cliente2.Cuenta.Retira(50);
            cliente3.Cuenta.Deposita(100);

            Console.WriteLine($"Cliente {cliente1.Nombre} tiene un saldo de {cliente1.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente2.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {cliente3.Nombre} tiene un saldo de {cliente3.Cuenta.Saldo}");
        } */

        /*static void Main() {
            Banco mibanco = new Banco("Mis Cheleines","Carlos Ricon");

            mibanco.AgregarCliente(new Cliente("Genero Borreo"));
            mibanco.AgregarCliente(new Cliente("Arturo Romo"));
            mibanco.AgregarCliente(new Cliente("Ricardo Monreal"));
            mibanco.AgregarCliente(new Cliente("Amalia Garcia"));
            mibanco.AgregarCliente(new Cliente("Miguel Alonso"));
            mibanco.AgregarCliente(new Cliente("Alejandro Tello"));

            mibanco.Clientes[0].Cuenta = new CuentaBancaria(15000);
            mibanco.Clientes[1].Cuenta = new CuentaBancaria(25000);
            mibanco.Clientes[2].Cuenta = new CuentaBancaria(35000);
            mibanco.Clientes[3].Cuenta = new CuentaBancaria(45000);
            mibanco.Clientes[4].Cuenta = new CuentaBancaria(55000);
            mibanco.Clientes[5].Cuenta = new CuentaBancaria(105000);

            mibanco.Clientes[2].Cuenta.Retira(15000);
            mibanco.Clientes[5].Cuenta.Retira(25000);
            mibanco.Clientes[3].Cuenta.Deposita(25000);

            foreach(Cliente cte in mibanco.Clientes) {
                Console.WriteLine($"Cliente: {cte.Nombre}, Saldo: {cte.Cuenta.Saldo}");
            }*/

            static void Inicializa(Banco banco)
            {
                banco.AgregarCliente(new Cliente("Juan Perez"));
                banco.AgregarCliente(new Cliente("Santiago Esparza"));
                banco.AgregarCliente(new Cliente("Juan Villa"));
                banco.AgregarCliente(new Cliente("Carlos Castaneda"));

                banco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(1000,0.5));
                banco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1000,200));
                banco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(2000,0.3));
                banco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(2000,0.3));
                banco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(6000,0.3));
                banco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(5000,0.3));
                banco.Clientes[2].AgregarCuenta(new CuentaDeCheques(1200,300));
                banco.Clientes[2].AgregarCuenta(new CuentaDeCheques(1200,300));
                banco.Clientes[3].AgregarCuenta(new CuentaDeCheques(120000,1300));
                banco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(5000,0.6));

                banco.Clientes[3].AgregarCuenta(banco.Clientes[3].Cuentas[0]);

                banco.Clientes[3].Cuentas[0].Retira(90000);
            }

            static void Reporte(Banco banco)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"\t\t{banco.Nombre}");
                Console.WriteLine($"Reporte mensual de saldo");
                Console.WriteLine("--------------------------------------------------\n\n");
                foreach(Cliente cte in banco.Clientes)
                {
                    Console.WriteLine($"{cte.Nombre}");
                    foreach(CuentaBancaria cta in cte.Cuentas){
                        if(cta is CuentaDeAhorro)
                        {
                            (cta as CuentaDeAhorro).CalcularInteres();
                        }
                        Console.WriteLine(cta is CuentaDeCheques? "Cheques" : "Ahorro");
                    }
                    Console.WriteLine($"Total Cuentas: {cte.Cuentas.Count}\n");
                }

                Console.WriteLine("--------------------------------------------------\n\n");
                Console.WriteLine($"Total de Clientes: {banco.Clientes.Count}");

            }

            static void Main()
            {
                string archivo = "datos";
                Banco mibanco = null;

                if(!File.Exists(archivo)){
                    mibanco = new Banco("Bancornudo", "Venom Snake");
                    Inicializa(mibanco);
                    Util.Grabar(archivo, mibanco);

                    Console.WriteLine("---------- DATOS GRABADOS");
                }else{
                    mibanco = new Banco();
                    Util.Cargar(archivo, mibanco);
                }

                Reporte(mibanco);
            }
    }
}