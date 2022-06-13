using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Letras
{
    class LetraPrecio
    {
        protected float valorLetraPrecio;

        /// <summary>
        /// calcula el valor de la letra segun el tipo
        /// </summary>
        /// <returns></returns>
        public float CalcularLetra()
        {
            return this.valorLetraPrecio;
        }


    }
}
