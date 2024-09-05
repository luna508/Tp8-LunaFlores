using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Modelo
{
    class Libro
    {
        private bool Disponi;
        private string Nombre;
        private string Autor;
        private int Codigo;
        private string Editorial;
        private string FechaPrestamo;
        private string FechaDevo;
        private string Formato;

        public Libro()
        {

        }

        public Libro(string nom, string aut,int codi)
        {
            Nombre = nom;
            Autor = aut;
            Codigo = codi;
         }

        public Libro(bool dis,string nom, string aut, int cod,string edi,string pres,string devo, string form)
        {
            Disponi = dis;
            Nombre = nom;
            Autor = aut;
            Codigo = cod;
            Editorial = edi;
            FechaPrestamo = pres;
            FechaDevo = devo;
            Formato = form;
        }

        public bool Disponi1 { get => Disponi; set => Disponi = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
        public string FechaPrestamo1 { get => FechaPrestamo; set => FechaPrestamo = value; }
        public string FechaDevo1 { get => FechaDevo; set => FechaDevo = value; }
        public string Formato1 { get => Formato; set => Formato = value; }
    }

}
