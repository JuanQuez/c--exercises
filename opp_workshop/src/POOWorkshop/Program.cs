using POOWorkshop.Domain;
using POOWorkshop.Domain.Interfaces;
using POOWorkshop.Domain.Payroll;
using POOWorkshop.Domain.People;
using POOWorkshop.Services;
using POOWorkshop.Services.Output;
using POOWorkshop.Services.Payment;

Console.OutputEncoding = System.Text.Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n=== POOWorkshop – Demos ===");
    Console.WriteLine("1) Clases y Objetos (Product + encapsulamiento)");
    Console.WriteLine("2) Herencia (Person -> EmployeeFullTimePerson/Manager/ContractorPerson)");
    Console.WriteLine("3) Polimorfismo (IPayable + EmployeeBase: FullTime/Hourly)");
    Console.WriteLine("4) Abstracción + SOLID (PayrollService con DIP)");
    Console.WriteLine("0) Salir");
    Console.Write("Seleccione una opción: ");
    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1": DemoClassesObjects(); break;
        case "2": DemoInheritance(); break;
        case "3": DemoPolymorphism(); break;
        case "4": DemoSolid(); break;
        case "0": return;
        default: Console.WriteLine("Opción no válida."); break;
    }
}

static void DemoClassesObjects()
{
    Console.WriteLine("\n-- Demo: Clases y Objetos --");
    var p1 = new Product(1, "Laptop", 3_500_000m, 5);
    var p2 = new Product(2, "Mouse", 50_000m, 20);
    Console.WriteLine(p1);
    Console.WriteLine(p2);

    Console.WriteLine("Actualizando precios...");
    p1.SetPrice(3_700_000m);
    p2.SetPrice(45_000m);
    Console.WriteLine(p1);
    Console.WriteLine(p2);

    try
    {
        p2.SetStock(-1); // Forzamos error de validación
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Validación OK: {ex.Message}");
    }
}

static void DemoInheritance()
{
    Console.WriteLine("\n-- Demo: Herencia --");
    var people = new List<Person>
    {
        new Person("Juan Pérez"),
        new EmployeeFullTimePerson("Ana Gómez", 4_200_000m),
        new Manager("Carlos Ruiz", 8_000_000m, 12),
        new ContractorPerson("Marta Díaz", 80_000m)
    };

    foreach (var p in people)
        Console.WriteLine(p.Describe());
}

static void DemoPolymorphism()
{
    Console.WriteLine("\n-- Demo: Polimorfismo (Interfaces/Abstract) --");
    var payroll = new List<IPayable>
    {
        new FullTime("Laura", 4_500_000m),
        new Hourly("Pedro", 60_000m, 100),
        new Hourly("Sofía", 65_000m, 180)
    };

    foreach (var e in payroll)
        Console.WriteLine($"{e.GetType().Name} -> {e.CalculatePayment():C0}");
}

static void DemoSolid()
{
    Console.WriteLine("\n-- Demo: Abstracción + SOLID (DIP) --");
    var employees = new List<IPayable>
    {
        new FullTime("Laura", 4_500_000m),
        new Hourly("Pedro", 60_000m, 100),
        new Hourly("Sofía", 65_000m, 180)
    };

    var calculator = new OvertimeCalculator(baseHours: 160, overtimeFactor: 1.25m);
    var outputConsole = new ConsoleOutput();
    var service = new PayrollService(calculator, outputConsole);
    service.Run(employees);

    // También escribimos a archivo para evidenciar DIP (cambiar salida sin tocar lógica)
    var filePath = Path.Combine(AppContext.BaseDirectory, "payroll.txt");
    var outputFile = new FileOutput(filePath);
    var serviceToFile = new PayrollService(calculator, outputFile);
    serviceToFile.Run(employees);

    Console.WriteLine($"Archivo generado: {filePath}");
}
