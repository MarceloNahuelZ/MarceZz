using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Cree un programa en C# que solicite un número (x) y muestre 10*x. Debe repetirse hasta  0.
*/

namespace Ejercicio_5_Usando_la_instruccion_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instruccion while...");
;
            Console.WriteLine("Ingrese su numero: ");
            int x=Convert.ToInt32(Console.ReadLine());

            while (x != 0)
            {
                Console.WriteLine(x*10);
                x--;
            }
        }
    }
}
