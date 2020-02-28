using System;

namespace _14.CuentaBancaria 
{
    [Serializable()]

    class CuentaDeAhorro: CuentaBancaria 
    { //Heredamos de cuenta bancaria
        private double tasaInteres;

        public CuentaDeAhorro(double saldo, double tasaInteres) : base(saldo)
        { //Llamada explicta al constructor de la clase base
            this.tasaInteres = tasaInteres;
        }

        public void CalcularInteres()
        {
            saldo += (saldo * tasaInteres);
        }
    }
}