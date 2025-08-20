public class Product
{
    public string Name { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public void Add(int quantity)
    {
        Quantity += quantity;
    }

    public bool Remove(int quantity)
    {
        if (quantity <= Quantity)
        {
            Quantity -= quantity;
            return true;
        }
        return false;
    }
}