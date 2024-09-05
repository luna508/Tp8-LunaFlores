using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.Modelo
{
    class Pasajero
    {
        private string Nombre;
        private int NumerodePasaporte;
        private string Nacionalidad;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int NumerodePasaporte1 { get => NumerodePasaporte; set => NumerodePasaporte = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }

        public Pasajero()
        {

        }
        public Pasajero(string nom,string nacio)
        {
            Nombre = nom;
            Nacionalidad = nacio;

        }
        public Pasajero(string nom, int pasa, string nacio)
        {
            Nombre = nom;
            NumerodePasaporte = pasa;
            Nacionalidad = nacio;

        }
    }
}
