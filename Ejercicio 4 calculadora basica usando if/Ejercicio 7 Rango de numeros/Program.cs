using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cree un programa en C# que solicite un rango de números al usuario (x, y) y los muestre en pantalla.
*/

namespace Ejercicio_7_Rango_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rango de numeros");

            Console.WriteLine("Ingrese el primer numero: ");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int y=Convert.ToInt32(Console.ReadLine());

            for(int i = x; i <= y; i++)
            {
                Console.WriteLine(i);
                
            }
            }
        }
    }

