using Electrodemesticos.Letras;
using Electrodemesticos.Pesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodemesticos.Electrodomesticos
{
    class Television : Electrodomestico
    {
        protected float resolucion;
        protected bool tdt;

        public Television(float resolucion, bool tdt, float precioBase, TamanioPrecio peso, LetraPrecio consumoEnergetico) : base(peso, consumoEnergetico)
        {
            this.resolucion = resolucion;
            this.tdt = tdt;
            this.precioBase = precioBase;
        }
        /// <summary>
        /// PrecioFinal() suma procentaje por pulgadas y un valor agregado por sintonizador
        /// </summary>
        /// <returns></returns>
        public override float PrecioFinal()
        {
            float incrementoDePrecio = base.PrecioFinal();

            float pulgadas = 40;
            float resultado = 0;
            float porcentaje = 30;
            float precioSintonizador = 50;

            if (this.resolucion > pulgadas)
            {
                resultado += (porcentaje * incrementoDePrecio / 100);
                
            }
            if (this.tdt == true)
            {
                incrementoDePrecio += precioSintonizador;
            }
            
            return incrementoDePrecio + resultado;
        }
    }
}
