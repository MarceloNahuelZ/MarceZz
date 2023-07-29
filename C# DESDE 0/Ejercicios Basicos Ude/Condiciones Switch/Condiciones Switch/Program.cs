using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero del mes ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("El mes es Enero");
                    break;
                case 2:
                    Console.WriteLine("El mes es Febredo");
                    break;
                case 3:
                    Console.WriteLine("El mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("El mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("El mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("El mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes es Diciembre");
                    break;
                default: Console.WriteLine("Ingrese un mes valido");
                    break;

            }
        }
    }
}
