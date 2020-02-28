using System;

namespace _14.CuentaBancaria
{
    class CuentaBancaria{
        private double saldo;

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public void Deposita(double cantidad){
            saldo += cantidad;
        }

        public double Saldo{
            get{ return saldo;}
        }
    
        public bool Retira(double cant){
            if(saldo > cant){
                saldo -= cant;
                return true;
            }else return false;
        }

    }
}