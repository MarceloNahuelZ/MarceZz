using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_y_datos_por_el_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);

            Console.WriteLine("Ingrese el primer numero");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            int resultado = x / y ;

            Console.WriteLine("El resultado de su division es: " + resultado + " Y el resto de su division es :" + x%y);



        }
    }
}
