using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Cree un programa en C# que solicite al usuario una distancia en metros y el tiempo necesario (horas, minutos, segundos).

Muestra la velocidad, en metros por segundo, kilómetros por hora y millas por hora.

1 milla = 1609 metros.*/


namespace Ejercicio_6_Valor_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valores float...");

            float distancia = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese la distancia en metros:" );
           
            float horas=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ingrese la Hora");

            Console.WriteLine("Ingrese los minutos");
            float minutos=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese los segundos.");
            float segundos=Convert.ToSingle(Console.ReadLine());

            
           /*a terminar*/
        }
    }
}
