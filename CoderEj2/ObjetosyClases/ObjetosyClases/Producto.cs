using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosyClases
{
    internal class Producto
    {
        //crear atributos SIEMPRE TIENEN QUE SER PRIVATES !!! SIEMPRE se pone _ para diferenciarlos pero no es obligatorio
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;

        // setter y getter asignar o tomar un valor del atributo... siempre van a ser publicos

        public int codigo { get; set; }
        public int categoria { get; set; }
        public string descripcion { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }

        // constructores los constructores siempre siempre van a ser public y el nombre de la clase...  y entre parentesis algunos parametros si necsito.

        public Producto()
        {
            _codigo = 0;
            _descripcion = string.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            _categoria = string.Empty;
        }

        // la palabra this es opcional pero es necesaria para diferenciar cuando estas dentro de esa clase. se hacer referencia a el objeto instanciado

        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
        }

        // crear un metodo para ver si hay productos cargados o no 

        public bool hayPrecioDeVenta()
        {
            // toda la logica del metodo y siempre cuando terminas va un return 
            return this._precioCompra > 0;
        }
        
        


    }
}
