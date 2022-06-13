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

            public LetraC()
        {
            this.valorLetraPrecio = this.CalcularLetraC();
        }
        /// <summary>
        /// retorna valor de Letra C
        /// </summary>
        /// <returns></returns>
            public float CalcularLetraC()
            {
                return this.valorLetraPrecio = LetraC.VALOR_LETRA_C;
            }
        }
}
