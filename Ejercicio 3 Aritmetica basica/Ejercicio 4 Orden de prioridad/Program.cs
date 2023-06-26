using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Crea un programa en C# que solicite un número entero x al usuario y
* imprima el resultado de las siguientes operaciones:
* -6 + x * 5
* (13-2) * x
* (x + -2) * (20 / 10)
* (12 + x) / (5 - 4)
*/

namespace Ejercicio_4_Orden_de_prioridad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Orden de prioridad ");

            Console.Write("Ingrese un numero entero: ");

            int x = Convert.ToInt32(Console.ReadLine());

            int ejer1 = -6 + x * 5;
            int ejer2 = (13 - 2) * x;
            int ejer3 = (x + -2) * (20 / 10);
            int ejer4 = (12 + x) / (5 - 4);

            Console.WriteLine("Resultado 1: " +  ejer1);
            Console.WriteLine("Resultado 2: " +  ejer2);
            Console.WriteLine("Resultado 3: " +  ejer3);
            Console.WriteLine("Resultado 4: " +  ejer4);

        }
    }
}
