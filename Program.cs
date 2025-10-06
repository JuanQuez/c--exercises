//& EXAMPLE 1

// Console.Write("¿What is your name? ");
// string userName = Console.ReadLine() ?? ""; //! We saved the user name in "userName" variable

//? We show a greeting
// Console.WriteLine($"It´s a pleasure to meet you, {userName}!");

//? We continue asking for the other data
// Console.Write("¿How old are you? ");
// int userAge = Convert.ToInt32(Console.ReadLine()); //! We saved the user age

// Console.Write("¿How much do you weigh? (in kilograms) ");
// double userWeight = Convert.ToDouble(Console.ReadLine()); //! We saved the user weight

// Console.Write("¿How tall are you? (in meters, for example 1.70) ");
// double userHeight = Convert.ToDouble(Console.ReadLine()); //! We saved the user height

//? We calculate the BMI
// double imc = userWeight / (userHeight * userHeight); //! This BMI formula

//? We show the BMI result
// Console.Write($" Hola {userName}, tu IMC es: {Math.Round(imc, 2)}");

// if (imc < 18.5)
//     Console.WriteLine("You´ve underweight.");
// else if (imc < 24.9)
//     Console.WriteLine("You´ve a normal weight.");
// else if (imc < 29.9)
//     Console.WriteLine("You´ve overweight.");
// else
//     Console.WriteLine("You´ve obesity.");

//& EXAMPLE 2

//? We convert currency
// Console.Write("How many Colombian pesos do you have?: ");
// double cashPesos = Convert.ToDouble(Console.ReadLine()); //! We ask for the amount of money

//? We define the exchange rates
// double rateUSD = 4000.0; // 1 dólar = 4000 pesos
// double rateEUR = 4400.0; // 1 euro = 4400 pesos
// double ratePEN = 1100.0; // 1 sol peruano = 1100 pesos

//? We calculate how much money it would be in other currencies
// double dolar = cashPesos / rateUSD;
// double euro = cashPesos / rateEUR;
// double sol = cashPesos / ratePEN;

//? We show the results
// Console.WriteLine($"{userName}, with {cashPesos} colombian pesos, You can have:");
// Console.WriteLine($"{Math.Round(dolar, 2)} dolars");
// Console.WriteLine($"{Math.Round(euro, 2)} euros");
// Console.WriteLine($"{Math.Round(sol, 2)} Peruvians Sol");

//&& EXAMPLE 3

/* Console.WriteLine("Satisfaction Survey | Fallout 4");

Console.Write("How satisfied are you with the game? (1-5): ");
int satisfactionGame = int.Parse(Console.ReadLine());

Console.Write("Would you recommend our game to other people? (1-5): ");
int recommendationGame = int.Parse(Console.ReadLine());

// Show survey results
Console.WriteLine("\n--- Survey Results ---");
Console.WriteLine($"Satisfaction with the game: {satisfactionGame}/5");
Console.WriteLine($"Recommendation to others: {recommendationGame}/5");

if (satisfactionGame >= 4 && recommendationGame >= 4)
{
    Console.WriteLine("Thank you for your positive feedback!");
}
else if (satisfactionGame <= 2 || recommendationGame <= 2)
{
    Console.WriteLine("We're sorry to hear that. We'll work to improve!");
}
else
{
    Console.WriteLine("Thank you for your feedback!");
}

// INVENTORY EXERCISES

Dictionary<string, int> lista_productos = new Dictionary<string, int>()
{
    { "Manzana", 100 },
    { "Pera", 200 },
    { "Uva", 300 },
};

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- Control de Stock ---");
    Console.WriteLine("1. Ver inventario");
    Console.WriteLine("2. Agregar producto");
    Console.WriteLine("3. Retirar producto");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("\nInventario actual:");
            foreach (var producto in lista_productos)
            {
                Console.WriteLine($"Producto: {producto.Key}, Cantidad: {producto.Value}");
            }
            break;

        case "2":
            Console.Write("Nombre del producto a agregar: ");
            string prodAgregar = Console.ReadLine();
            Console.Write("Cantidad a agregar: ");
            int cantidadAgregar = int.Parse(Console.ReadLine());

            if (lista_productos.ContainsKey(prodAgregar))
                lista_productos[prodAgregar] += cantidadAgregar;
            else
                lista_productos.Add(prodAgregar, cantidadAgregar);

            Console.WriteLine("Producto agregado correctamente.");
            break;

        case "3":
            Console.Write("Nombre del producto a retirar: ");
            string prodRetirar = Console.ReadLine();
            if (lista_productos.ContainsKey(prodRetirar))
            {
                Console.Write("Cantidad a retirar: ");
                int cantidadRetirar = int.Parse(Console.ReadLine());
                if (lista_productos[prodRetirar] >= cantidadRetirar)
                {
                    lista_productos[prodRetirar] -= cantidadRetirar;
                    Console.WriteLine("Producto retirado correctamente.");
                }
                else
                {
                    Console.WriteLine("No hay suficiente stock para retirar esa cantidad.");
                }
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
            break;

        case "4":
            salir = true;
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}
Console.WriteLine("¡Hasta luego!"); */

// Instanciar class (create an object of a class)
AritmeticOperation op1 = new AritmeticOperation();
op1.Number1 = n1;
op1.Number2 = n2;
op1.PrintSum();
op1.restOp();
