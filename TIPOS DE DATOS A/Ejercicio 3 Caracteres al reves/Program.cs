using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.

namespace Ejercicio_3_Caracteres_al_reves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres al revés");

            Console.WriteLine("Ingrese la primera letra:");
            char letra1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda letra:");
            char letra2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera letra:");
            char letra3 = Convert.ToChar(Console.ReadLine());

            string resultado = letra3.ToString() + letra2.ToString() + letra1.ToString();
            Console.WriteLine("Las letras al revés son: " + resultado;
        }
    }
}