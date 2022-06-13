using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Letras
{
    class LetraA : LetraPrecio
    {
        private static float VALOR_LETRA_A = 100;

        public LetraA()
        {
            this.valorLetraPrecio = this.CalcularLetraA();
        }
        public float CalcularLetraA()
        {
            return this.valorLetraPrecio = LetraA.VALOR_LETRA_A;
        }
    }
}
