using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribe un programa en C# que solicite dos números enteros al usuario (x, y) y 
 * imprima el resultado de la división y el resto de la división en una nueva linea.
*/

namespace Ejercicio_3_Division_y_modulo_de_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            int division = x / y;
            int resto = x % y;

            Console.WriteLine("El resultado de su division es:" + x + " / " + y + " es = a : " + division);
            Console.WriteLine("El resultado de su resto entre:" + x +  " / " + y + " es = a : " + resto);

        }
    }
}
