// See https://aka.ms/new-console-template for more information
using OrmAlmacen.Models;
using System;

Console.WriteLine("Hello, World!");


#region Listar
using (OrmAlmacenContext db = new OrmAlmacenContext()) {

    #region Insertar
    Producto producto = new Producto();
    Console.WriteLine("Ingrese el nombre del producto");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la descripción del producto");
    producto.Descipción = Console.ReadLine();

    Console.WriteLine("Ingrese el precio del producto");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingresa los prouctos disponibles");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    db.Productos.Add(producto);
    db.SaveChanges();

    #endregion


    var ListProducto = db.Productos.ToList();

    foreach (var Producto in ListProducto)
    {
        Console.WriteLine(Producto);
    }

#endregion
}