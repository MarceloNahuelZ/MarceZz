using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LAS CONFIGURACIONES SON PROPIEDADES QUE TIENE MI APLICACION QUE VAN A MODIFICAR CIERTAS CARACTERISTICAS... EJ COLOR DE UNA VENTANA ETC
// LO CLASICO QUE SE UTILIZA SON LOS ARCHIVOS

namespace Archivos_de_configuraciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAMOS LA VARIABLE QUE VA A CONTENER MI CONFIGURACION 
            int edad;
            //CARGAMOS EL VALOR
            edad = Properties.Settings.Default.ConfiguracionDeEdad;
            Console.WriteLine("El valor leido de la configuracion es " + edad);


            //GUARDAMOS UN NUEVO VALOR DE LA CONFIGURACION
            edad = edad + 1;
            Console.WriteLine("Guardamos la configuracion nueva edad  = " + edad);
            Properties.Settings.Default.ConfiguracionDeEdad = edad;
            Properties.Settings.Default.Save(); 
            Console.ReadLine();

        }
    }
}
