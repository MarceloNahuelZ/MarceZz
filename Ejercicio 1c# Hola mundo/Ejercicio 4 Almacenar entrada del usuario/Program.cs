using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crea un programa en C# que pregunte al usuario en la primera linea ¿Cómo te llamas? y guarde el nombre en la variable x.

//El programa debe responder en la segunda linea con Encantado de conocerte, x.


namespace Ejercicio_4_Almacenar_entrada_del_usuario
{
    internal class Program
    {
        private static string nombre;

        static void Main(string[] args)
        {
            string x;

            Console.WriteLine("¿Como te llamas?");
            Convert.ToString(x = Console.ReadLine());
            Console.WriteLine("Encantado de conocerte " +  x);
            
        }
    }
}
