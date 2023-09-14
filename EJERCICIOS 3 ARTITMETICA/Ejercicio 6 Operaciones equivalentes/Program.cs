using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Escriba un programa en C# que solicite tres números (a, b, c) y muestre el resultado de (a+b)*c y el resultado de a*c + b*c.
*/

namespace Ejercicio_6_Operaciones_equivalentes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones equivalentes");

            Console.WriteLine("Ingrese el primer numero: ");
            int a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero ");
            int c= Convert.ToInt32(Console.ReadLine());

            int resu1 = (a + b) * c;
            int resu2 = a*c + b*c;

            Console.WriteLine("El primer resultado es: " + resu1);
            Console.WriteLine("El segundo resultado es: " + resu2);
        }
    }
}
