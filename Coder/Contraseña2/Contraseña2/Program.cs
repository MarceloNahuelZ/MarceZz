using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraseña2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Contraseña = "Huguito";
            string nombre;
            const string Categoria = "A";

            Console.WriteLine("Hola Bievenidos ");

            Console.WriteLine("Ingrese la categoria");

            switch (Categoria)
            {
                case "A":
                    Console.WriteLine("Administrador ");
                    break;
                case "U":
                    Console.WriteLine("Usuario");
                    break;
                case "X":
                    Console.WriteLine("Sin definir");
                    break;
                default:
                    Console.WriteLine("la categoria no existe");
            }
                       
            Console.WriteLine("Ingrese el Usuario");
            nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese la contraseña");
            Contraseña = Convert.ToString(Console.ReadLine());

            if (Contraseña == "Huguito"){
                Console.WriteLine("La contraseña es correcta");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta");
            }

        }
    }
}
