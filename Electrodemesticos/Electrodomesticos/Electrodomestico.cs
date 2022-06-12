using Electrodemesticos.Letras;
using Electrodemesticos.Pesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Electrodomesticos
{
     class Electrodomestico
    {
        protected float precioBase;
        protected LetraPrecio consumoEnergetico;
        protected TamanioPrecio peso;

        public Electrodomestico(TamanioPrecio peso, LetraPrecio consumoEnergetico)
        {
            this.precioBase = 100;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
        }

        
        public float PrecioFinal()
        {
            float pesoTotal = this.peso.CalcularPeso();
            float letraValor = this.consumoEnergetico.CalcularLetra();
            float sumatoriaFinal = 0;
            sumatoriaFinal += this.precioBase + (pesoTotal + letraValor);
            return sumatoriaFinal;
        }
    }
}
