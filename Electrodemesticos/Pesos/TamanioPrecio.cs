using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Pesos
{
    class TamanioPrecio
    {
        protected float valorLetra;

        public TamanioPrecio()
        {
            this.valorLetra = CalcularPeso();
        }
        /// <summary>
        /// calcula el peso que recibe de sus hijos
        /// </summary>
        /// <returns></returns>
        public float CalcularPeso()
        {
            return this.valorLetra;
        }
    }
}
