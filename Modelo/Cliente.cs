using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2NET.Modelo
{
    class Cliente : Persona
    {
        private string _direccion;
        public Cliente(string nombre, string apellido, string direccion) : base(nombre, apellido)
        {
            this._direccion = direccion;
        }

        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
