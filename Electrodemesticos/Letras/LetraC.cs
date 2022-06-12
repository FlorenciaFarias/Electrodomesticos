using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Letras
{
        class LetraC : LetraPrecio
        {
            private static float VALOR_LETRA_C = 60;

            public float CalcularLetraC()
            {
                return this.valorLetraPrecio = LetraC.VALOR_LETRA_C;
            }
        }
}
