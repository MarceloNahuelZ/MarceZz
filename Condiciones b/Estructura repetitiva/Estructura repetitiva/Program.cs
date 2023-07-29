using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Cree un programa en C# que solicite al usuario dos números enteros (x, y) y muestre el rango de esos números
 * (los dos incluidos), de tres maneras diferentes:

Usando la instrucción for.
Usando la instrucción while.
Usando la instrucción do while.
Entrada
6
12
Salida
6 7 8 9 10 11 12
6 7 8 9 10 11 12
6 7 8 9 10 11 12 
*/

namespace Estructura_repetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Ingrese el primer numero");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            y = Convert.ToInt32(Console.ReadLine());

            // Usando la instrucción for.
            Console.Write("Usando la instrucción for: ");
            for (int i = x; i <= y; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Usando la instrucción while.
            Console.Write("Usando la instrucción while: ");
            int whileCounter = x;
            while (whileCounter <= y)
            {
                Console.Write(whileCounter + " ");
                whileCounter++;
            }
            Console.WriteLine();

            // Usando la instrucción do-while.
            Console.Write("Usando la instrucción do-while: ");
            int doWhileCounter = x;
            do
            {
                Console.Write(doWhileCounter + " ");
                doWhileCounter++;
            } while (doWhileCounter <= y);
            Console.WriteLine();
        }
    }
}
