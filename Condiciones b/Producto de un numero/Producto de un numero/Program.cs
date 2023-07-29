using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que le pida al usuario dos números enteros y
 * muestre su multiplicación, pero sin usar el operador *. 
 * Debe usar sumas consecutivas.*/

namespace Producto_de_un_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; 
            int y;
            int resultado = 0;
            int i = 0;

            Console.WriteLine("Ingrese el primer numero ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            y = Convert.ToInt32(Console.ReadLine());

            while (i < y)
            {
                resultado = resultado + x;
                i++;
            }
            Console.WriteLine(x + "x" +  y + " = " + resultado );
        }
    }
}
