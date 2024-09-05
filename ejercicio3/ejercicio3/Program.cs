using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio3.Modelo;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            Cliente cliente2 = new Cliente("Mena Julieta","B° San Agustin p/5, c/18");
            Cliente cliente3 = new Cliente("Mena Julieta", "B° San Agustin p/5, c/18","guada231@gmail.com");

            cliente1.Nombre1 = "Julieta Mena";
            cliente1.DirecciondeEnvio1 = "B° San Agustin p/5, c/18";
            cliente1.CorreoElectronico1 = "guada231@gmail.com";

            Console.WriteLine("Nombre del Cliente/a: " + cliente1.Nombre1);
            Console.WriteLine("Direccion de Envio: " + cliente1.DirecciondeEnvio1);
            Console.WriteLine("Direccion de Correo Electronico: " + cliente1.CorreoElectronico1);

            Console.WriteLine("----------------------------------------------");
            Pedido pedido1 = new Pedido();
            Pedido pedido2= new Pedido(234,"Julieta Mena",1500);
            Pedido pedido3 = new Pedido(234,"Julieta Mena",1500);

            pedido1.IndenPedido1 = 234;
            pedido1.FechadePedido1 ="04/07/24";
            pedido1.Usuario1 = "Julieta Mena";
            pedido1.Preciototal1 = 1500;

            Console.WriteLine("Indentificador de Pedido: " +pedido1.IndenPedido1);
            Console.WriteLine("Fecha de Pedido: " + pedido1.FechadePedido1);
            Console.WriteLine("Nombre del Usuario: " + pedido1.Usuario1);
            Console.WriteLine("Precio Total :$ " + pedido1.Preciototal1);


            Console.WriteLine("----------------------------------------------");

            Producto producto1 = new Producto();
            Producto producto2 = new Producto("Coca-Cola 500",1500,3);
            Producto producto3 = new Producto("Coca-Cola 500", 1500, 3,"rica y muy comprada");

            producto1.Nombre1 = "Coca-Cola 500";
            producto1.Precio1= 1500;
            producto1.Stock1 =3;
            producto1.Descripcion1 = "rica y muy comprada";

            Console.WriteLine("El Nombre del Producto es: " + producto1.Nombre1);
            Console.WriteLine("El precio del Producto es $: " + producto1.Precio1);
            Console.WriteLine("Descrpcion de Producto: " + producto1.Descripcion1);
            Console.WriteLine("La Cantidad de Stock: " + producto1.Stock1);
            Console.ReadKey();



        }
    }
}
