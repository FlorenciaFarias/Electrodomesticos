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
        /// <summary>
        /// contiene 3 atributos, 2 por agregación
        /// </summary>
        protected float precioBase;
        protected LetraPrecio consumoEnergetico;
        protected TamanioPrecio peso;
        
        /// <summary>
        /// este constructor espera peso y consumo energetico
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="consumoEnergetico"></param>
        public Electrodomestico(TamanioPrecio peso, LetraPrecio consumoEnergetico)
        {
            this.precioBase = 100;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
        }
        public Electrodomestico(float precioBase, TamanioPrecio peso, LetraPrecio consumoEnergetico)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
        }
        /// <summary>
        /// calcula el peso de la clase TamanioPrecio y la letra de LetrasPrecio,
        /// suma estos con el precio base y retorna el total del producto
        /// </summary>
        /// <returns></returns>
        public virtual float PrecioFinal()
        {
            float pesoTotal = this.peso.CalcularPeso();
            float letraValor = this.consumoEnergetico.CalcularLetra();
            float sumatoriaFinal = 0;
            sumatoriaFinal += this.precioBase + pesoTotal + letraValor;
            return sumatoriaFinal;
        }
    }
}
