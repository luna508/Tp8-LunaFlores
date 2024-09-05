using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico4.Modelo
{
    class Estudiante
    {
        private string Nombre;
        private int NumMatricula;
        private string AnCursado;

        public Estudiante()
        {

        }
        public Estudiante(string nom, int matric)
        {
            Nombre = nom;
            NumMatricula = matric;
        }
        public Estudiante(string nom, int matri, string año)
        {
            Nombre = nom;
            NumMatricula = matri;
            AnCursado = año;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int NumMatricula1 { get => NumMatricula; set => NumMatricula = value; }
        public string AnCursado1 { get => AnCursado; set => AnCursado = value; }
    }
}
