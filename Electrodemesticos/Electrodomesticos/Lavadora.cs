using System;
using Electrodemesticos.Pesos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electrodemesticos.Letras;

namespace Electrodemesticos.Electrodomesticos
{
    class Lavadora : Electrodomestico
    {
        protected float carga;
        protected float pesoKg;
        public Lavadora(float precioBase,TamanioPrecio peso, LetraPrecio consumoEnergetico, float pesoKg) : base( peso,consumoEnergetico)
        {
            this.carga = 30;
            this.pesoKg = pesoKg;
            this.precioBase = precioBase;
        }
  /// <summary>
  /// PrecioFinal() agrega valor extra por carga de peso
  /// </summary>
  /// <returns></returns>
        public override float PrecioFinal()
        {
        
            float incrementoDePrecio = base.PrecioFinal();
            if(this.pesoKg > this.carga)
            {
                incrementoDePrecio += 50;

            }
            return incrementoDePrecio;
        }
    }
}
