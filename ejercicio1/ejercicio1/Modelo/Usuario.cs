using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Modelo
{
    class Usuario
    {
        private string Nombre;
        private string Telefono;
        private bool Registrado;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public bool Registrado1 { get => Registrado; set => Registrado = value; }

        public Usuario()
        {

        }
        public Usuario(string nom, string tel)
        {
            Nombre = nom;
            Telefono = tel;
        }

        public Usuario(string nom, string tele, bool regis)
        {
            Nombre = nom;
            Telefono = tele;
            Registrado = regis;

        }
    }

}
