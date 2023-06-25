using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribe un programa en C# que calcule el resultado de sumar, restar,
 * multiplicar y dividir dos números introducidos por el usuario.

Además también debería calcular el resto de la división en la última linea.

*/


namespace Ejercicio_2_Calculadora_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el primer numero");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int num2=Convert.ToInt32(Console.ReadLine());


            double suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double division = num1 / num2 ;
            double resto = num1 % num2;

            Console.WriteLine("El resultado de tu operacion es: " + num1 + " + " + num2 + " = "  + suma);
            Console.WriteLine("El resultado de tu operacion es: " + num1 + " - " + num2 + " = " + resta);
            Console.WriteLine("El resultado de tu operacion es: " + num1 + " * " + num2 + " = " + multiplicacion);
            Console.WriteLine("El resultado de tu operacion es: " + num1 + " / " + num2 + " = " + division);
            Console.WriteLine("El resultado de tu operacion es: " + num1 + " % " + num2 + " = " + resto);
            Console.ReadKey();
        }
    }
}
