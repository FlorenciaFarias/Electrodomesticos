using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Letras
{
    class LetraB : LetraPrecio
    {
        private static float VALOR_LETRA_B = 80;

        public LetraB()
        {
            this.valorLetraPrecio = this.CalcularLetraB();
        }
        /// <summary>
        /// retorna el valor de letra B
        /// </summary>
        /// <returns></returns>
        public float CalcularLetraB()
        {
            return this.valorLetraPrecio = LetraB.VALOR_LETRA_B;
        }
    }
}
