public class Inventory
{
    private Dictionary<string, Product> products = new Dictionary<string, Product>();

    public void ViewInventory()
    {
        Console.WriteLine("\nCurrent inventory:");
        foreach (var prod in products.Values)
        {
            Console.WriteLine($"Product: {prod.Name}, Quantity: {prod.Quantity}");
        }
    }

    public void AddProduct(string name, int quantity)
    {
        if (products.ContainsKey(name))
            products[name].Add(quantity);
        else
            products.Add(name, new Product(name, quantity));

        Console.WriteLine("Product added successfully.");
    }

    public void RemoveProduct(string name, int quantity)
    {
        if (products.ContainsKey(name))
        {
            if (products[name].Remove(quantity))
                Console.WriteLine("Product removed successfully.");
            else
                Console.WriteLine("Not enough stock to remove that quantity.");
        }
        else
        {
            Console.WriteLine("The product does not exist in the inventory.");
        }
    }
}
