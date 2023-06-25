using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua. 
 * En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados. 
 * La escala de Kelvin es una escala absoluta utilizada en ciencias.

Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit. 
Solicite al usuario la cantidad de grados centígrados para convertirlos usando las siguientes tablas de conversión:

kelvin = celsius + 273
fahrenheit = celsius x 18/10 + 32
*/

namespace Ejercicio_4_Centigrados_a_Kelvin_y_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Centigrados a Kelvin y Fahrenheit..");

            Console.WriteLine("Ingrese los Grados Centigrados");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = celsius + 273;
            double fahrenheit = celsius * 18 / 10  + 32;

            Console.WriteLine("sus grados en kelvin son:" + kelvin );

            Console.WriteLine("sus grados en fahrenheit son:" + fahrenheit);


        }
    }
}
