using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribe un programa en C# que pregunte al usuario ¿Cuál es tu animal favorito?. Después detén la ejecución del programa utilizando la instrucción Console.Read. Cuando el usuario pulse Intro el programa responderá ¡El mio también! en la segunda linea.

namespace Ejercicio_3_Leer_entrada_del_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cual es tu animal favorito?");
            Console.Read();
            Console.WriteLine("¡El mio también!");
        }
    }
}
