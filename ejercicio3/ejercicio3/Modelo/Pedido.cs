using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Modelo
{
    class Pedido
    {
        private int IndenPedido;
        private string FechadePedido;
        private string Usuario;
        private float Preciototal;

        public int IndenPedido1 { get => IndenPedido; set => IndenPedido = value; }
        public string FechadePedido1 { get => FechadePedido; set => FechadePedido = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public float Preciototal1 { get => Preciototal; set => Preciototal = value; }

        public Pedido()
        {

        }
        public Pedido(int id, string usua, float total)
        {
            IndenPedido = id;
            Usuario = usua;
            Preciototal = total;

        }
        public Pedido(int id, string pedido,string usua, float total)
        {
            IndenPedido = id;
            FechadePedido = pedido;
            Usuario = usua;
            Preciototal = total;

        }
    }

}
