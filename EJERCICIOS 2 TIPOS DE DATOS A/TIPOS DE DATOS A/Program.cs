using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crea un programa en C# para calcular la superficie y el * 
 *volumen de una esfera, dado su radio.

superficie = 4 * pi * radio al cuadrado
volumen = 4/3 * pi * radio al cubo         

 */


namespace Calcular_dimensiones_de_esfera
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float radio = Convert.ToSingle(Console.ReadLine());
            float pi = 3.1415926535f;

            float superficie = 4 * pi * (radio * radio);
            float volumen = 4 / 3 * pi * (radio * radio * radio);

            Console.WriteLine("Superficie: " + superficie);
            Console.WriteLine("Volumen: " + volumen);
        }
    }

}
