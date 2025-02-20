using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cuenta
    {
        public string Numero { get; }
        public enum Tipo { CajaAhorro = 1, CUentaCorriente = 2, CUentaSueldo =3 }
        public Tipo mTipo { get; }

        public double Saldo { get; }

        public bool Cobrado { get; private set; }

        public Cuenta(Tipo pTipo, double pSaldo)
        {
            mTipo = pTipo;
            Saldo = pSaldo;

        }
        public Cuenta(Tipo pTipo, double pSaldo, string pNumero)
        {
            mTipo = pTipo;
            Saldo = pSaldo;
            Numero = pNumero;
        }
        internal void CobrarMantenimiento()
        {
            Cobrado = true;
        }
        public void Aplicarcredito(Single pCredito)
        {

        }
        public void AplicarDebito(Single pDebito)
        {

        }
    }
}
