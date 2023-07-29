using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[5];

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Ingrese un numero");
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Los datos son ");
            for (int i = 0;i < 5;i++) {
                Console.Write(datos[i] +  "  ");
            }

            Console.WriteLine("Los datos al reves  son ");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(datos[i] + "  ");
            }

            string[] diasDeSemana = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            Console.WriteLine(" Dime uun numero de dia ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El nombre del dia es :" + diasDeSemana[dia-1]);

            Console.WriteLine("Dime el nombre de un dia: ");
            string nombreDia = Console.ReadLine();
            for (int i = 0; i < diasDeSemana.Length; i++)
            {
                if (nombreDia == diasDeSemana[i])
                {
                    Console.WriteLine("encontrado en " + (i+1));
                }
            }
        }
    }
}
