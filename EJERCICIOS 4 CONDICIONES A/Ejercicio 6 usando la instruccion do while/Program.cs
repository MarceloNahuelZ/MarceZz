using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cree un programa en C# que solicite un número (x) y muestre 10*x. Debe repetirse hasta que el usuario ingrese 0.
*/

namespace Ejercicio_6_usando_la_instruccion_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instruccion do while");

            Console.WriteLine("Ingrese un numero: ");
            int x=Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(x * 10);
                x--;

            } while (x != 0);
        }
    }
}
