using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escriba un programa en C# que muestre las letras del abecedario en 
 * mayúsculas utilizando únicamente un bucle for y variables char.*/

namespace Condiciones_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            
            char z = 'Z';
            
           

            Console.WriteLine("Abecedario upper.");
           
            
            for (char i = a; i <= z; i++)
            {
                Console.Write(i + " ");
                
            }
        }
    }
}
