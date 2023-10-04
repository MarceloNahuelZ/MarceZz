using System;
namespace ProyectoFinal
{
    public abstract class Venta
    {
        public int id { get; set; }
        public string comentario { get; set; }
        public int idUsuario { get; set; }

    }
}