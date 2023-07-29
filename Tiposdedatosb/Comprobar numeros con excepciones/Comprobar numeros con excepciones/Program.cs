using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que solicite al usuario un texto (x) y 
 * realice una conversión para comprobar si el texto es un número o no.*/

namespace Comprobar_numeros_con_excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto ");

            string x = Convert.ToString(Console.ReadLine());

            try
            {
                Convert.ToInt32(x);
                Console.WriteLine("Es un numero");
            }
            catch
            {
                Console.WriteLine("No es un numero");
                throw;
            }
        }
    }
}
