using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercico4.Modelo;


namespace ejercico4
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante estudiante1 = new Estudiante();
            Estudiante estudiante2 = new Estudiante("Flores Eliseo", 2345);
            Estudiante estudiante3 = new Estudiante("Flores Eliseo",2345,"2° II°");

            estudiante1.Nombre1 = "Flores Eliseo";
            estudiante1.NumMatricula1 = 2345;
            estudiante1.AnCursado1 = "2° II°";

            Console.WriteLine("Nombre del estudiante: " + estudiante1.Nombre1);
            Console.WriteLine("Numero de matricula: " + estudiante1.NumMatricula1);
            Console.WriteLine("Año de cursado: " + estudiante1.AnCursado1);

            Console.WriteLine("-------------------------------------------------");
            Curso curso1 = new Curso();
            Curso curso2 = new Curso("2° II°",123456);
            Curso curso3 = new Curso(123456,"2° II°","Prof.Asuncion Costilla","Lengua y Litertura");

            curso1.Codigo1 = 123456;
            curso1.Nombre1 = "2° año II° division";
            curso1.Profesor1 = "Asuncion Costilla";
            curso1.Materia1 = "Lengua y Literatura";

            Console.WriteLine("Codigo: " + curso1.Codigo1);
            Console.WriteLine("Nombre: " + curso1.Nombre1);
            Console.WriteLine("Profesor/ra: " + curso1.Profesor1);
            Console.WriteLine("Materia que dicta: " + curso1.Materia1);

            Console.ReadKey();
        }
    }
}
