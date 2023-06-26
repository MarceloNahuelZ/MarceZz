using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribe un programa en C# que multiplique por tres factores.
 * Solicita tres números al usuario y muestra el resultado de multiplicarlos entre sí.
 */


namespace Ejercicio_2_Multiplicacion_de_tres_factores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplicacion de tres factores: ");

            Console.WriteLine("Ingrese el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            int z = Convert.ToInt32(Console.ReadLine());

            int resultado = z * y * x;

            Console.WriteLine("El resultado de la multiplicacion es :" + z + " x " + y + " x "  + z + " = " + resultado);
        }
    }
}
