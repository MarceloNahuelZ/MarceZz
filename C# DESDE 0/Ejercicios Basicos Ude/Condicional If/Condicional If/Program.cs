using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ingrese su usuario porfavor ");
            string usuario = Convert.ToString(Console.ReadLine());

            if (usuario == "Marcelo")
            {
                Console.WriteLine("Acceso Permitido");
            }
            else
            {
                Console.WriteLine("Acceso Denegado");
            }

            Console.WriteLine("Ingrese el primer numero ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero ");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((x != 0) && (y != 0))
            {
                Console.WriteLine("El Resultado de su division es : " + x / y);
            }
            else
            {
                Console.WriteLine("El Numero no se puede dividir por 0 ");
            }

            Console.WriteLine("Ingrese el primer numero ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (((a < 0) && (b < 0))) {
                Console.WriteLine("Ambos son Negativos");
            }
            else if ((a > 0) && (b > 0)) {
                Console.WriteLine(b + "ambos positivo");

            }else if ((a < 0) && (b > 0)) {
                Console.WriteLine(b+ "Es positivo");

            }
            else
            {
                Console.WriteLine(a+ " es positivo");
            }
            
                                
            

        }
    }
}
