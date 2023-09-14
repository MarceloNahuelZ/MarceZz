using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo
 * y calcule el perímetro y  el área 

Perímetro= suma de los cuatro lados.
Área= base x altura.

*/


namespace Ejercicio_5_Valor_double
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el ancho a calcular: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura a calcular: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double perimetro = (x + y) * 2;
            double area = x * y;

            Console.WriteLine("El valor del area ingresado es de:" + area);
            Console.WriteLine("El valor del perimetro ingresado es de: "+perimetro);


        
        }
    }
}
