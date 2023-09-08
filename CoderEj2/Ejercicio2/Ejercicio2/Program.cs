using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2.	Crear un programa que pida tres números e indique cual es el menor y cual es el mayor */

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("El numero mayor es el " + a);

                if (b <= c)
                {
                    Console.WriteLine("El numero menor es el " + b);
                }
                else
                {
                    Console.WriteLine("El numero menor es el " + c);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("El numero mayor es el " + b);

                if (a <= c)
                {
                    Console.WriteLine("El numero menor es el " + a);
                }
                else
                {
                    Console.WriteLine("El numero menor es el " + c);
                }
            }
            else
            {
                Console.WriteLine("El numero mayor es el " + c);

                if (a <= b)
                {
                    Console.WriteLine("El numero menor es el " + a);
                }
                else
                {
                    Console.WriteLine("El numero menor es el " + b);
                }
            }
        }
    }
}