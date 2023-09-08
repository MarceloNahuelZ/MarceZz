using ObjetosyClases;
using System.Runtime.CompilerServices;

//aca se crea el producto

Producto testProducto = new Producto();

Producto testProductoParametrizado = new Producto(1, "Camisa", 50000, 100000, "Ropa");



// metodo sin parametros... 

if (!testProducto.hayPrecioDeVenta())
{
    Console.WriteLine("No hay precio de venta");
}
else
{
    Console.WriteLine("No hay precio de venta");
}

Console.WriteLine();