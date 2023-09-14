using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que use el operador condicional para asignar 
 * valor a una variable boolean. Deberás asignar verdadero si dos números ingresados
 * por el usuario (x, y) son pares y falso si alguno de ellos es impar.
Para finalizar muestra el valor de la variable por pantalla.*/

namespace Boolean_y_operador_condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boolean y operador condicional ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            bool ambos = ((x % 2 == 0) && (y % 2 == 0)) ? true : false;
            Console.WriteLine(ambos);
        }
    }
}
