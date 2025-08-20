public class Inventario
{
    private Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

    public void VerInventario()
    {
        Console.WriteLine("\nInventario actual:");
        foreach (var prod in productos.Values)
        {
            Console.WriteLine($"Producto: {prod.Nombre}, Cantidad: {prod.Cantidad}");
        }
    }

    public void AgregarProducto(string nombre, int cantidad)
    {
        if (productos.ContainsKey(nombre))
            productos[nombre].Agregar(cantidad);
        else
            productos.Add(nombre, new Producto(nombre, cantidad));

        Console.WriteLine("Producto agregado correctamente.");
    }

    public void RetirarProducto(string nombre, int cantidad)
    {
        if (productos.ContainsKey(nombre))
        {
            if (productos[nombre].Retirar(cantidad))
                Console.WriteLine("Producto retirado correctamente.");
            else
                Console.WriteLine("No hay suficiente stock para retirar esa cantidad.");
        }
        else
        {
            Console.WriteLine("El producto no existe en el inventario.");
        }
    }
}