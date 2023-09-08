using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*mostrar la suma desde el 65 hasta el 25 de manera descendente y de 5 en 5 usando un FOR.*/

namespace LaSuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma Descendente");

          for (int i = 65; i >= 25 ; i -= 5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
