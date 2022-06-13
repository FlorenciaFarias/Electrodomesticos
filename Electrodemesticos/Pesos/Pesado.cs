using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Pesos
{
    class Pesado : TamanioPrecio
    {
        private static float VALOR_LETRA_PESADO = 80;
        public Pesado()
        {
            this.valorLetra = this.CalcularPesoPesado();
        }
        public float CalcularPesoPesado()
        {
            return this.valorLetra = Pesado.VALOR_LETRA_PESADO;
        }
    }
}
