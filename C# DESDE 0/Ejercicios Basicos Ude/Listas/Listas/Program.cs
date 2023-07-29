using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> datos = new List<int>();
            
            int dia;
            string nombreDia;
            int numero;

            Console.WriteLine("Dame datos (-1) para terminar :");
            do
            {
                Console.WriteLine("Di un dato");
                numero= Convert .ToInt32(Console.ReadLine());
                if(numero != -1)
                    datos.Add(numero);

            } while (numero != -1);

            Console.WriteLine("los datos son: ");
            for (int i = 0; i < datos.Count; i++)
            {
                Console.WriteLine(datos[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("los datos al reves son");
            for(int i = datos.Count-1 ;i < 1; i--)
            {
                Console.WriteLine(datos[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Dime un dato " );
            int datoBuscar = Convert .ToInt32(Console.ReadLine());
            if (datos.Contains(datoBuscar))
            {
                Console.WriteLine("El dato esta");

            }else
            {
                Console.WriteLine("No encontrado");
            }
        }
    }
}
