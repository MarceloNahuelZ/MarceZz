using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2) Crear un programa que permita ingresar los siguientes datos: nombre, Edad, profesion y sueldo, 
 * de 10 personas (utilizando while) y que se muestre por pantalla el sueldo mas alto y el promedio de edad. (WHILE)*/


namespace Ingreso_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double edad;
            string profesion;
            double sueldo;
            double contador = 0;
            double PromedioEdad = 0;
            double SueldoMasAlto = 0;
            while (contador <= 10)
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su edad");
                edad = Convert.ToDouble(Console.ReadLine());
                PromedioEdad += edad; 

                Console.WriteLine("Ingrese su profesion");
                profesion = Console.ReadLine();

                Console.WriteLine("Ingrese su sueldo");
                sueldo = Convert.ToDouble(Console.ReadLine());


                if (sueldo < SueldoMasAlto)
                {
                    SueldoMasAlto = sueldo;

                }

                contador++;

            }
              
            Console.WriteLine("El Sueldo mas alto es " + (SueldoMasAlto));
            Console.WriteLine("El promedio de edad es :" + (PromedioEdad / contador));
        }
        
    }
}
