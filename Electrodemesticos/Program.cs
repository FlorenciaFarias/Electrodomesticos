using Electrodemesticos.Electrodomesticos;
using Electrodemesticos.Letras;
using Electrodemesticos.Pesos;
using System;

namespace Electrodemesticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TamanioPrecio medio = new Medio();
            LetraPrecio A = new LetraA();
            Electrodomestico lgLavadora = new Lavadora(200,medio, A,29);
            

            TamanioPrecio liviano = new Liviano();
            LetraPrecio B = new LetraB();
            Electrodomestico lavadoraDos = new Lavadora(200,liviano, B, 29);
            Console.WriteLine(lavadoraDos.PrecioFinal());


        }
    }
}
