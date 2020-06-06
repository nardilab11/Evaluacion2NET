using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2NET.Modelo
{
    abstract class Empleado : Persona
    {
        private int _rut;
        protected Empleado(string nombre, string apellido, int rut) : base(nombre, apellido)
        {
            this._rut = rut;
        }

        public int Rut { get => _rut; set => _rut = value; }
    }
}
