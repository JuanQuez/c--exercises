// OOP - Class in C#

class AritmeticOperation
{
    // properties - sintaxis (access mod, datatype, name, properties, get, set)
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    // functions - sintaxis (access mod, return type, name, parameters)
    public int PrintSum()
    {
        int sumResult = Number1 + Number2;
        Console.WriteLine($"La suma es: {sumResult}");
    }

    public int Sum(int n1, int n2)
    {
        int result = n1 + n2;
        return result;
    }
}
