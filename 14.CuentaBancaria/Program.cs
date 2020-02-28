using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void PruebaCuentaBancaria()
        {
            //CuentaBancaria RP = new CuentaBancaria(1000);
            //Console.WriteLine($"Saldo al crear {RP.Saldo}");
            //RP.Deposita = 500;
            //Console.WrciteLine($"Saldo despues del domingo {RP.Saldo}");
            //if(RP.Retira(500))
                //Console.WriteLine($"Saldo despues de la peda {RP.Saldo}");
            //else
                //Console.WriteLine("Usted no posee tanto dinero pobre y pendejo");
        }

                static void PruebaCliente(){
                Cliente cliente1 = new Cliente("Juan Perez");
                Cliente cliente2 = new Cliente("Maria Lopez");
                Cliente cliente3 = new Cliente("Mario Lopez");
               CuentaBancaria cuenta1 = new CuentaBancaria(100); 
               cliente1.Cuenta = cuenta1;
               cliente1.Cuenta.Deposita(500);

               cliente2.Cuenta = new CuentaBancaria(200);
               cliente3.Cuenta = cliente2.Cuenta;
               cliente2.Cuenta.Retira(50);
               cliente3.Cuenta.Deposita(100);

               Console.WriteLine($"Cliente: {cliente1.Nombre} tiene un saldo de {cliente1.Cuenta.Saldo}");
               Console.WriteLine($"Cliente: {cliente2.Nombre} tiene un saldo de {cliente2.Cuenta.Saldo}");
                }

                static void Main(){
                   Banco mibanco = new Banco("Bancogerte", "Carlitos Chambas");

                   mibanco.AgregarCliente(new Cliente("Genaro Borreo"));
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

                   mibanco.Clientes[2].Cuenta.Retira(5000);
                   mibanco.Clientes[5].Cuenta.Retira(50000);
                   mibanco.Clientes[3].Cuenta.Retira(35000);

                   foreach(Cliente cte in mibanco.Clientes){
                       Console.WriteLine($"Cliente: [cte.nombre], Saldo: {cte.Cuenta.Saldo}");
                   }
        }
    }
}