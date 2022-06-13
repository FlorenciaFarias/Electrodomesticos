using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Pesos
{
    class Medio : TamanioPrecio
    {
        private static float VALOR_LETRA_MEDIO = 50;

        public Medio()
        {
            this.valorLetra = CalcularPesoMedio();
        }
        public float CalcularPesoMedio()
        {
            return this.valorLetra = Medio.VALOR_LETRA_MEDIO;
        }
    }
}
