using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2NET.Modelo
{
    enum Menus
    {
        PERSONAL, MEDIANO, FAMILIAR
    }

    class Pedido
    {
        private Cliente _cliente;
        private Caja _caja;
        private Repartidor _repartidor;
        private Garzon _garzon;

        public Pedido(Cliente cliente, Caja caja)
        {
            this._cliente = cliente;
            this._caja = caja;
            this._repartidor = null;
            this._garzon = null;
        }

        

        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Caja Caja { get => _caja; set => _caja = value; }
        public Repartidor Repartidor { get => _repartidor; set => _repartidor = value; }
        public Garzon Garzon { get => _garzon; set => _garzon = value; }
    }
}
