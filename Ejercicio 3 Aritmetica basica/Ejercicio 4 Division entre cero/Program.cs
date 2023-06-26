using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Cree un programa en C# que solicite dos números al usuario (x, y)
 * y muestre el resultado de su división.

 Tendrá que controlar la división por 0 con el uso de la excepción DivideByZeroException
 en un bloque try-catch. Si el usuario intenta dividir por 0 muestre No se puede dividir por 0.
*/


namespace Ejercicio_4_Division_entre_cero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divion entre 0 ");
            int x = Int32.TryParse(Console.ReadLine());
            
            

        }
    }
}
