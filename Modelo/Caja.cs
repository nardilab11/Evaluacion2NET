using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2NET.Modelo
{
    class Caja
    {
        private int _numero;
        private Cajero _cajero;

        public Caja(int numero, Cajero cajero)
        {
            this._numero = numero;
            this._cajero = cajero;
        }

        public int Numero { get => _numero; set => _numero = value; }
        public Cajero Cajero { get => _cajero; set => _cajero = value; }
    }
}
