using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Pesos
{
    class Liviano : TamanioPrecio
    {
        private static float VALOR_LETRA_LIVIANO = 10;

        public Liviano()
        {
            this.valorLetra = this.CalcularPesoLiviano();
        }
        /// <summary>
        /// calcula el peso liviano mediante el atributo de clase
        /// </summary>
        /// <returns></returns>
        public float CalcularPesoLiviano()
        {
            return this.valorLetra = Liviano.VALOR_LETRA_LIVIANO;
        }
    }
}
