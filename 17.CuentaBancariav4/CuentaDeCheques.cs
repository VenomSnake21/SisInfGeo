using System;

namespace _14.CuentaBancaria 
{
    [Serializable()]
    class CuentaDeCheques : CuentaBancaria
    {
        private double proteccionSobregiro;

        public CuentaDeCheques(double saldo, double proteccionSobregiro) : base(saldo)
        {
            this.proteccionSobregiro = proteccionSobregiro;
        }

        public override bool Retira(double cant)
        {   
            if(saldo < cant)
            {
                double proteccionRequerida = cant - saldo;
                if(proteccionSobregiro < proteccionRequerida)
                {
                    return false;
                }else{
                    saldo = 0.0;
                    proteccionSobregiro -= proteccionRequerida;
                }
            }else{
                saldo-=cant;
                return true;
            }
              return true;         
            }
    }
}