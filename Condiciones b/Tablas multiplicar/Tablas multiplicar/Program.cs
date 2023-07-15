using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que solicite un rango de números al usuario (x,y) 
 * y muestre las tablas de multiplicar de x hasta y. */

namespace Tablas_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Ingrese el primer numero:  ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo numero: ");
            y = Convert.ToInt32(Console.ReadLine());    

            for (int i = x ; i <= y; i++)
            {
                for (int j = 1 ; j <= 10; j++)
                {
                    Console.WriteLine(i + "X" + j + "=" + (i*j) + " ");
                }
                Console.WriteLine();
            }
           
            }
        }
    }

