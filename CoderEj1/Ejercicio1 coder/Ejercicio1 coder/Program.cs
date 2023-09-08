using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1.	Realizar un programa que pida ingresar por el teclado un número entero,
 * y que indique si el número es positivo, 0  o negativo.*/

namespace Ejercicio1_coder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("El Numero es igual a : 0 ");
            } else if (a >= 1) {
                Console.WriteLine("El numero es positivo");
            } else 
            {
                Console.WriteLine("El numero es negativo");
            }
        }
    }
}
