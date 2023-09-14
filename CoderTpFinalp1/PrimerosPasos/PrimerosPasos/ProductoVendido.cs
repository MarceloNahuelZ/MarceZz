using System;
namespace FinalProject
{
    public abstract class ProductoVendido
    {
        public int id { get; set; }
        public int idProduct { get; set; }
        public int stock { get; set; }
        public int idSale { get; set; }
    }
}