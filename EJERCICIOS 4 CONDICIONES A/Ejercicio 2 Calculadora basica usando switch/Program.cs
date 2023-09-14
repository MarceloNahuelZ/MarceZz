using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escriba un programa en C# que solicite al usuario dos números y una operación (+,-,x,/) 
después calcule la operación y muestre el resultado por pantalla.
Muestre el texto Caracter no reconocido si el símbolo de la operación es diferente a los anteriores.
*/


namespace Ejercicio_2_Calculadora_basica_usando_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora basica usando switch: ");

            Console.WriteLine("Ingrese el primer numero: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion que desea realizar: + - x / " );
            char operacion = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int num2=Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case '+':
                    Console.WriteLine("El resultado de su suma es :" + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("El resultado de su resta es:" + (num1 -num2));
                    break;

                case 'x':
                    Console.WriteLine("El resultado de su multiplicacion es: " +(num2 * num1));
                    break;

                case '/':
                    Console.WriteLine("El resultado de su division es: " + (num1 / num2));
                    break;

                default: Console.WriteLine("Caracter desconocido por favor vuelva a intentarlo");
                    break;
            }
            

        }
    }
}
