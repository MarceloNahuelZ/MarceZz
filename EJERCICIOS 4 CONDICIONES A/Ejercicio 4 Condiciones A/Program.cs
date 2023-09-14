using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escriba un programa en C# que solicite al usuario dos números y una operación (+,-,x,/)
después calcule la operación y muestre el resultado por pantalla.

Muestre el texto Caracter no reconocido si el símbolo de la operación es diferente a los anteriores.

Debe usar el bloque if.

*/

namespace Ejercicio_1_calculadora_basica_
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion que desea realizar: + , - , / , x ");
            string operacion = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

           

            if(operacion == "+")
            {
                Console.WriteLine("El resultado de la operacion: " + num1 + "+" + num2 + " = " +  (num1 + num2));

            } else if (operacion == "-")
            {
                Console.WriteLine("El resultado de la operacion: " + num1 + "-" + num2 + " = " + (num1 - num2));

            } else if(operacion == "x")
            {
                Console.WriteLine("El resultado de la operacion: " + num1 + "x" + num2 + " = " + (num1 * num2));
            } else if (operacion == "/")
            {
                Console.WriteLine("El resultado de la operacion: " + num1 + "/" + num2 + " = " + (num1 / num2));
            } else
            {
                Console.WriteLine("El caracter no reonocido ingrese un caracter valido.");
            }

            
        }
    }
}
