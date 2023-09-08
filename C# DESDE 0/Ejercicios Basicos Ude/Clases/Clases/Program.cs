using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* Alumnos alumnos1 = new Alumnos();
            alumnos1.nombre = "Juan";
            alumnos1.edad = 33;
            
            alumnos1.grado = "Programador";

            Alumnos alumnos2 = new Alumnos();
            alumnos2.nombre = "Enrique";
            alumnos2.edad = 23;
           
            alumnos2.grado = "Medicina";*/

           Alumnos alumnos3 = new Alumnos("Mirta", 25, 14.5, "Astronauta");
           
           Console.WriteLine(alumnos3.Nota);
           Console.WriteLine("El alumno " + alumnos3.nombre );
           Console.WriteLine(alumnos3.Aprobado());
            Console.WriteLine(Alumnos.alumnosTotales);

           
        }


    }
}
