using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribe un programa en C# que pregunte al usuario por un número x y 
 * muestre el resultado de su tabla de multiplicar del 1 al 10.
 */

namespace Ejercicio_6_Tabla_de_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tabla de Multiplicar Simple del numero: ");


            int x = Convert.ToInt32(Console.ReadLine());
            
           
            for(int i = 1; i < 11; i++)
            {
                int resultado = x * i;
                Console.WriteLine(x +"x"+ i + "=" +resultado );
            }
        }
    }
}
