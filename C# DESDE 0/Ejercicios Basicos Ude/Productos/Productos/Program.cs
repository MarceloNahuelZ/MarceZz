using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El producto de 12 * 13 es igual a :  " + 12*13);
            Console.WriteLine("El Resultado de 226 / 5 es igual a: " + 226/5);
            Console.WriteLine("Ingrese un Numero :");
            int x = Convert.ToInt32(Console.ReadLine());
            int resultado = x * x;
            Console.WriteLine("El resultado de : " + x + " al cuadrado es :"  + resultado);
            Console.WriteLine("Halla el resto de dividir 169 entre 7 es igual a :" + 169 % 7);
        }
    }
}
