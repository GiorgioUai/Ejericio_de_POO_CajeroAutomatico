using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cliente : IEnumerable<Cuenta>
    {
        private List<Cuenta> mListaDeCuentas = new List<Cuenta>();

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; }
        public string  Clave { get; private set; }
        public double LimiteCredito { get; set; }

        public int CantidadCuentas { get; }

        public Cliente(string pUsuario)
        {
            Usuario = pUsuario;
        }

        public void CambiarClave(string pClave)
        {

        }

        public void AgregarCuenta(Cuenta pCuenta)
        {

        }

        public delegate void MantenimientosCobradosDelegate(Single pMonto);
        public MantenimientosCobradosDelegate MantenimientosCobrados;

        public void CobrarMantenimientos(Single pMonto)
        {
            MantenimientosCobrados?.Invoke(pMonto);
        }

        public IEnumerator<Cuenta> GetEnumerator()
        {
            return  mListaDeCuentas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mListaDeCuentas.GetEnumerator();
        }
    }
}
