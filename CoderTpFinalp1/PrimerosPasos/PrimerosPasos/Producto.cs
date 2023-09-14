using System;
namespace FinalProject
{
    public abstract class Producto
    {
        public int id { get; set; }
        public string description { get; set; }
        public double cost { get; set; }
        public double priceSale { get; set; }
        public int stock { get; set; }
        public int idUser { get; set; }

    }
}