using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Alumnos
    {
        public string nombre;
        public int edad;
        private double nota;
        public string grado;
        public static int alumnosTotales;

        public Alumnos(string Nombre, int Edad, double argNota, string Grado)
        {
            nombre = Nombre;
            edad = Edad;
            Nota = argNota;
            grado = Grado;
            alumnosTotales++;

        }
        public bool Aprobado()
        {
            if (nota >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Nota 
        {
            get { return nota; }
            set { if (value >= 0 && value <=10 )
                {
                    nota = value;
                } else
                {
                    nota = -1.0;
                }  
                        }
        }
    }
}
