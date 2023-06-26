using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Escriba un programa C# que solicite un número (x) y responda si es positivo o negativo.
*/

namespace Ejercicio_3_Positivo_y_negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positivo y Negativo ");

            Console.WriteLine("Ingrese un numero ");
            string x = Convert.ToString(Console.ReadLine());

            if (x == '-' + x)
            {
                Console.WriteLine("Su numero ingresado es Negativo;");
            }
            else
            {
                Console.WriteLine("Su numero es positivo;");
            }

        }
    }
}
