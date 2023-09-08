using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3) Generar los números del 1 al 10 y mostrarlos por pantalla.

4) Generar los numeros del 10 al 1 y mostrarlo por pantalla.*/


namespace Generador_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros del 1 al 10");

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int i = 10; i >= 1 ; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
