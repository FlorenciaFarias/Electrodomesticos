using Electrodemesticos.Electrodomesticos;
using Electrodemesticos.Letras;
using Electrodemesticos.Pesos;
using System;
using System.Collections.Generic;

namespace Electrodemesticos
{
    class Program
    {
        static void Main(string[] args)
        {

            TamanioPrecio liviano = new Liviano();
            TamanioPrecio pesado = new Pesado();
            TamanioPrecio medio = new Medio();
            LetraPrecio A = new LetraA();
            LetraPrecio B = new LetraB();
            LetraPrecio C = new LetraC();

            Electrodomestico lavadoraUno = new Lavadora(300,medio, A,31);
            Electrodomestico lavadoraDos = new Lavadora(200, liviano, C, 20);
            Electrodomestico lavadoraTres = new Lavadora(250, pesado, B, 40);
            Electrodomestico lavadoraCuatro = new Lavadora(900, liviano, A, 29);
            Electrodomestico tvPrimera = new Television(30,true,200, medio, A);
            Electrodomestico tvSegunda = new Television(30, false, 200, pesado, C);
            Electrodomestico tvTercera = new Television(41, true, 900, medio, B);
            Electrodomestico tvCuarta = new Television(50, true, 1200, medio, C);
            Electrodomestico tvQuinta = new Television(49, false, 1000, medio, A);
            Electrodomestico tvSexta = new Television(75, false, 2200, pesado, A);

            List<Electrodomestico> electrodomesticosLista = new List<Electrodomestico>();

            electrodomesticosLista.Add(lavadoraUno);
            electrodomesticosLista.Add(lavadoraDos);
            electrodomesticosLista.Add(lavadoraTres);
            electrodomesticosLista.Add(lavadoraCuatro);
            electrodomesticosLista.Add(tvPrimera);
            electrodomesticosLista.Add(tvSegunda);
            electrodomesticosLista.Add(tvTercera);
            electrodomesticosLista.Add(tvCuarta);
            electrodomesticosLista.Add(tvQuinta);
            electrodomesticosLista.Add(tvSexta);


            foreach (Electrodomestico unElectrodomestico in electrodomesticosLista)
            {
                Console.WriteLine("El precio es: $" + unElectrodomestico.PrecioFinal());
            }

        }
    }
}
