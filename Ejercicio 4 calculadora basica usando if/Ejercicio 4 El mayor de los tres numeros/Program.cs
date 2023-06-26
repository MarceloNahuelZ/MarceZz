using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Escriba un programa en C# que solicite tres números (x, y, z) y muestre el mayor de ellos.
*/


namespace Ejercicio_4_El_mayor_de_los_tres_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El Mayor de los 3 numeros :");

            Console.WriteLine("Ingrese el primer numero: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y || y > z)
            {
                Console.WriteLine("El mayor de los 3 es: " + x);
            }
            else if (y > x || y > z)
            {
                Console.WriteLine("El mayor de los 3 es: " + y);
            }
            else if (z > x || z > y)
            {

                Console.WriteLine("El mayor de los 3 es:" + z);
            }else
            {
                Console.WriteLine("son todos iguales ");
            }
             
            
        }
    }

}