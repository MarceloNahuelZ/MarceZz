using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_datos_basicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string cadena = "cadena 1";
            char caracter = 'A';
            string cadena2 = "b";
            int entero = 1;
            double numeroDouble = 1.0;
            float numeroFlotante = 2.927f;
            decimal numeroDecimal = 10.927m;

            Console.WriteLine($"cadena: {cadena}");
            Console.WriteLine($"caracter: {caracter}");
            Console.WriteLine($"cadena2: {cadena2}");
            Console.WriteLine($"entero: {entero}");
            Console.WriteLine($"numeroDouble: {numeroDouble}");
            Console.WriteLine($"numeroFlotante: {numeroFlotante}");
            Console.WriteLine($"NumeroDecimal: {numeroDecimal}");

            float gradosF = 87;
            float gradosC;

            gradosC = (gradosF - 32) * 5/9;
            Console.WriteLine($"{gradosF} Grados F° equivalen a: {gradosC} Grados C°:");



        }
    }
}
