using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2NET.Modelo
{
    class Cajero : Empleado
    {
        public Cajero(string nombre, string apellido, int rut) : base(nombre, apellido, rut)
        {
        }
    }
}
