using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles_anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = { {20,21,22 }, {30,31,32 }, {40,41,42 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(numeros[i,j]);
                }
            }
        }
    }
}
