using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Escribe un programa en C# que solicite un número entero x al usuario y imprima el resultado de sumarlo al cuadro.
 * 
 */

namespace Ejercicios_1_Aritmetica_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sumas al cuadrado");

            Console.WriteLine("Ingrese el numero deseado..");
            int x = Convert.ToInt32(Console.ReadLine());

            int resultado = ( x * x);

            Console.WriteLine("El resultado de su numero al cuadrado es: "+ x + "X" +  x + "=" + resultado);
        }

    }
}
