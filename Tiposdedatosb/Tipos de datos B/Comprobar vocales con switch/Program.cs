using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cree un programa en C# que solicite al usuario una letra (x) 
 * y compruebe si es una vocal o otro símbolo.

Muestre por pantalla Vocal o Otro símbolo.*/


namespace Comprobar_vocales_con_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comprobemos las vocales.");

            char x = Convert.ToChar(Console.ReadLine());

            switch (x)
            {
                case  'a':
                    Console.WriteLine("La Letra A es una vocal");
                    break;

                case 'e' :
                    Console.WriteLine("La letra E es una vocal");
                    break;

                case 'i':
                    Console.WriteLine("La letra I es una vocal");
                    break;

                case 'o':
                    Console.WriteLine("La letra O es una vocal");
                    break;

                case 'u':
                    Console.WriteLine("La letra U es una vocal");
                    break;

                default : Console.WriteLine("La letra :" + x + " no es una vocal");
                    break;


            }   

        }
    }
}
