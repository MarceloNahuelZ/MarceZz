using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Crea un programa en C# que solicite al usuario 2 números enteros y muestre en pantalla un número al azar entre esos valores.
 * Puedes utilizar el objeto Random de .NET.
 */

namespace Ejercicio_7_Generar_numero_al_azar
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Generar numero al azar!");

            Console.WriteLine("Ingrese el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int aleatorio = random.Next(x, y);

            Console.WriteLine("El numero aleatorio creado es: "+ aleatorio);
        }
    }
}
