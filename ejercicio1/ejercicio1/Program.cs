using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio1.Modelo;


namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            Libro libro2 = new Libro("Cuentos de Campo", "Horacio Quiroga",345);
            Libro libro3 = new Libro(true, "Cuentos de Campo", "Horacio Quiroga",345,"planeta","23/8/24", "23/9/24","Fisico");

            libro1.Disponi1 = true;
            libro1.Codigo1 = 345;
            libro1.Nombre1 = "Cuentos de Campo";
            libro1.Autor1 = "Horacio Quiroga";
            libro1.Editorial1 = "planeta";
            libro1.FechaPrestamo1 = "20/06/2024";
            libro1.FechaDevo1 = "20/07/2024";
            libro1.Formato1 = "fisico";

            Console.WriteLine("Disponible: " + libro1.Disponi1);
            Console.WriteLine("Libro: " + libro1.Nombre1);
            Console.WriteLine("Autor: " + libro1.Autor1);
            Console.WriteLine("Editorial: "+ libro1.Editorial1);
            Console.WriteLine("Fecha de Prestamo: " + libro1.FechaPrestamo1);
            Console.WriteLine("Fecha de Devolucion: " + libro1.FechaDevo1);
            Console.WriteLine("Digital o Fisico:  " + libro1.Formato1);


            Console.WriteLine("------------------------------------------------------");

            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario("Flores Luna","3838473440");
            Usuario usuario3 = new Usuario("Flores Luna","3838473440",true);

            usuario1.Nombre1 ="Flores Luna ";
            usuario1.Telefono1 = "3838-473440";
            usuario1.Registrado1 = true;
            Console.WriteLine("Usuario: " + usuario1.Nombre1);
            Console.WriteLine("Telefono: " + usuario1.Telefono1);
            Console.WriteLine("Disponible: " + usuario1.Registrado1);
            




            Console.ReadKey();
        }
    }
}
