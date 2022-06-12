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

        public float CalcularLetraB()
        {
            return this.valorLetraPrecio = LetraB.VALOR_LETRA_B;
        }
    }
}
