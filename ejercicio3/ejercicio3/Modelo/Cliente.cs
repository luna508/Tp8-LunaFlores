using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Cliente
    {
        private string Nombre;
        private string DirecciondeEnvio;
        private string CorreoElectronico;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string DirecciondeEnvio1 { get => DirecciondeEnvio; set => DirecciondeEnvio = value; }
        public string CorreoElectronico1 { get => CorreoElectronico; set => CorreoElectronico = value; }

        public Cliente()
        {

        }
        public Cliente(string nom,string envio)
        {
            Nombre = nom;
            DirecciondeEnvio = envio;
        }
        public Cliente(string nom, string envio, string correo)
        {
            Nombre = nom;
            DirecciondeEnvio = envio;
            CorreoElectronico = correo;
        }

    }

}
