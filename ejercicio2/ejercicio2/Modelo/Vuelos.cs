using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Modelo
{
    class Vuelos
    {

        private int NumerodeVuelo;
        private string FechadeSalida;
        private string Destino;
        private string Precio;

        public int NumerodeVuelo1 { get => NumerodeVuelo; set => NumerodeVuelo = value; }
        public string FechadeSalida1 { get => FechadeSalida; set => FechadeSalida = value; }
        public string Destino1 { get => Destino; set => Destino = value; }
        public string Precio1 { get => Precio; set => Precio = value; }

        public Vuelos()
        {

        }
        public Vuelos(int vuelo, string pre,string salida)
        {
            NumerodeVuelo = vuelo;
            Precio = pre;
            FechadeSalida = salida;
        }
        public Vuelos(int vuelo,string salida,string des,string pre)
        {
            NumerodeVuelo = vuelo;
            FechadeSalida = salida;
            Destino = des;
            Precio = pre;
        }
    }
}
