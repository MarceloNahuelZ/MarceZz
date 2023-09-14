using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Escribe un programa en C# que calcule la medía aritmética de 4 factores introducidos por el usuario, uno por cada linea.
*/

namespace Ejercicio_5_Media_aritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el cuarto numero: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int resultado = (w + x + y + z) / 4;

            Console.WriteLine("El resultado de tu promedio es: " + resultado);
        }
    }
}
