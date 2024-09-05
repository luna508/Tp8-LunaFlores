using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio2.Modelo;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasajero pasajero1 = new Pasajero();
            Pasajero pasajero2 = new Pasajero("Flores Zoe", "Argentina ");
            Pasajero pasajero3 = new Pasajero("Flores Zoe", 234, "Argentina");

            pasajero1.Nombre1 = "Flores Zoe ";
            pasajero1.Nacionalidad1 = "Argentina";
            pasajero1.NumerodePasaporte1 = 234;

            Console.WriteLine("Nombre del Pasajero/a: " + pasajero1.Nombre1);
            Console.WriteLine("Numero de pasaporte es :" + pasajero1.NumerodePasaporte1);
            Console.WriteLine("Su Nacionalidad es : " + pasajero1.Nacionalidad1);

            Console.WriteLine("-----------------------------------------");

            Vuelos vuelo1 = new Vuelos();
            Vuelos vuelo2 = new Vuelos(567,"$34900","20/07/2024");
            Vuelos vuelo3 = new Vuelos(567,"$34900","20/07/2024","EE.UU");

            vuelo1.NumerodeVuelo1 = 567;
            vuelo1.FechadeSalida1 = "20/07/2024";
            vuelo1.Destino1 = "EE.UU";
            vuelo1.Precio1 = "$34900";

            Console.WriteLine("Numero de Vuelo es : " + vuelo1.NumerodeVuelo1);
            Console.WriteLine("Fecha de salida de su vuelo es el dia: " + vuelo1.FechadeSalida1);
            Console.WriteLine("El destino de vuelo es a: " + vuelo1.Destino1);
            Console.WriteLine("El precio de su vuelo es : " + vuelo1.Precio1);

            Console.ReadKey();

        }
    }
}
