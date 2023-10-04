using System;
namespace ProyectoFinal
{
    public abstract class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string email { get; set; }

    }
}