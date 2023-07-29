using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_VOID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felicitar(24);

            Felicitar(10);
            
            Felicitar(20);

            Asteriscos(10);
        }

        static void Felicitar (int admiraciones)
        {
            Console.Write("Lo estas haciendo Muy Bien ");
            for (int i = 0; i < admiraciones; i++)
            {
                Console.Write("!");
            }
            Console.WriteLine();
        }

        static void Asteriscos (int Aste)
        {
            Console.Write("cantidad de asteriscos");
            
            for (int i = 0; i < Aste; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
