using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // AGREGAR ESTE USING PARA QUE LOS DIRECTORIOS FUNCIONEN ! ! ! 

namespace Directorios_y_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DIRECTORIOS **********

            // CREAMOS UN DIRECTORIO 
            Directory.CreateDirectory("C:\\USER\\PUBLIC\\MIDIRECTORIO");

            // ELIMINAR DIRECTORIO 
            Directory.Delete("C:\\USER\\PUBLIC\\MIDIRECTORIO", true);

            //VERIFICAR SI UN DIRECTORIO EXISTE SE PUEDE VERIFICAR PRIMERO CON UN IF ... LUEGO SI NO EXISTE CREARLO.
            Directory.Exists("C:\\USER\\PUBLIC\\MIDIRECTORIO");

            //ENUMERAR LOS DIRECTORIOS DENTRO DE
            String[] directorios = Directory.GetDirectories("C:\\USER\\PUBLIC\\MIDIRECTORIO");

            //ENUMERAR LOS ARCHIVOS DE UN DIRECTORIO
            String[] archivos = Directory.GetFiles("C:\\USER\\PUBLIC\\MIDIRECTORIO");


            /*FILES***/

            // CREAR UN FILE 
            StreamWriter archivo;   // el STREAMWRITER ES UN PUNTERO algo que apunta al archivo creado. ( archivo es la variable )
            archivo = File.CreateText("C:\\USER\\PUBLIC\\MIARCHIVO.TXT");

            // ESCRIBIR EN EL FILE
            archivo.WriteLine("Escribo una linea");
            archivo.WriteLine("Escribo otra linea");
            archivo.WriteLine("Escribo la tercera linea");
            archivo.WriteLine("Escribo la ultima linea");
            archivo.WriteLine(DateTime.Now.ToShortTimeString());

            //CERRAR EL ARCHIVO
            archivo.Close();

            // FUNDAMENTAL SIEMPRE CERRAR EL ARCHIVO CUMPLE LA FUNCION DE GUARDAR ... SI NO SE GUARDA SE PIERDE EL CONTENIDO 


            //LEE UNA LINEA DE UN FILE   
            StreamReader archivoAleer;
            archivoAleer = File.OpenText("C:\\USER\\PUBLIC\\MIARCHIVO.TXT");
            string lectura = archivoAleer.ReadToEnd();
            Console.WriteLine(lectura);

            // LEER UN ARCHIVO HASTA EL FINAL 
            do
            {
                lectura = archivoAleer.ReadLine();
                Console.WriteLine(lectura );
            } while (lectura != null);
            archivoAleer.Close();

            //AGREGAR CONTENIDO A UN ARCHIVO    USAMOS LA FUNCION Append
            StreamWriter ficheroAppend;
            ficheroAppend = File.AppendText("C:\\USER\\PUBLIC\\MIARCHIVO.TXT");
            ficheroAppend.WriteLine("ESTA LINEA SE AGREGARA AL FINAL DEL CODIGO ...  "); // AGREGA TEXTO AL FINAL DEL ARCHIVO
            ficheroAppend.Close();

        }
    }
}
