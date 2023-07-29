using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log("Programa iniciando");
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Log($"Nombre ingresado : ");
            Log("Programa finalizado");
            Console.ReadLine();
        }

        static void Log(string logtext) 
        { 
            Console.WriteLine(DateTime.Now.ToString() + " - " + logtext);
        }
    }
}
