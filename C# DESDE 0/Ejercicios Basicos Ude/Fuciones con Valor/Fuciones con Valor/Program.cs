using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuciones_con_Valor
{
    

    internal class Program
    {
        static int Duplicar(int n)
        {
            return n * 2;
        }

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int SumarHasta(int limite)
        {
            int suma = 0;
            for (int i = 0; i <= limite; i++)
                suma += 1;
            return suma;

        }


        static void Main(string[] args)
        {
            int x;
            Console.WriteLine(Duplicar(5));
            x = Duplicar(12);
            Console.WriteLine(x);
            Console.WriteLine(Sumar(12, 12));

        }
    }
}
