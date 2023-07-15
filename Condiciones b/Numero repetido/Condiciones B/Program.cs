using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Escriba un programa en C#
 * que solicite un número (x) y una cantidad (y).
 * Muestre ese número tantas veces como la cantidad (y).*/


namespace Condiciones_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;



            Console.WriteLine("Repetiremos numeros");
            Console.WriteLine("Ingrese el numero que desea repetir ...:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cuantas veces desea repetirlo");
            y = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < y; i++) {
                Console.Write(x);
            }

        }
    }
}
