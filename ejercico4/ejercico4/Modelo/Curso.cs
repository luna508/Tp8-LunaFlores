using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico4.Modelo
{
    class Curso
    {
        private int Codigo;
        private string Nombre;
        private string Profesor;
        private string Materia;

        public Curso()
        {

        }
        public Curso(string nom, int cod)
        {
            Nombre = nom;
            Codigo = cod;
        }

        public Curso(int cod, string nom, string prof, string mat)
        {
            Codigo = cod;
            Nombre = nom;
            Profesor = prof;
            Materia = mat;
        }

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Profesor1 { get => Profesor; set => Profesor = value; }
        public string Materia1 { get => Materia; set => Materia = value; }
    }
}
