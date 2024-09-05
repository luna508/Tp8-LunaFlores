using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Producto
    {
        private string Nombre;
        private float Precio;
        private string Descripcion;
        private int Stock;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public float Precio1 { get => Precio; set => Precio = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Stock1 { get => Stock; set => Stock = value; }

        public Producto()
        {

        }
        public Producto(string nom, float pre, int stock)
        {
            Nombre = nom;
            Precio = pre;
            Stock = stock;

        }
        public Producto(string nom, float pre, int stock,string des)
        {
            Nombre = nom;
            Precio = pre;
            Stock = stock;
            Descripcion = des;
        }
    }
}
