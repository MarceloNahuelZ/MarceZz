using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que calcule la nota de un alumno a partir de un número entero.
 * Solicite al usuario un número (x) y responda lo siguiente:
10 - Matrícula de honor
9 - Sobresaliente
7.8 - Notable
6 - Bien
5 - Aprobado
0.4 - Suspenso
Use la instrucción switch, break y default de C#.*/


namespace Switch_break_default
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Ingrese su nota.. ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 10: 
                    Console.WriteLine("Matricula de honor");
                    break;
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien...");
                    break;
                case 5:
                    Console.WriteLine("Aprobado");
                    break;
                case 4:
                    Console.WriteLine("Suspenso");
                    break;
                case 3:
                    Console.WriteLine("Suspenso");
                    break;
                case 2:
                    Console.WriteLine("Suspenso");
                    break;
                case 1:
                    Console.WriteLine("Suspenso");
                    break;

                default:
                    Console.WriteLine("Ingrese una nota valida.");
                    break;
            }

        }
    }
}
