using exercise_1;
using exercise_2;
using exercise_3;
using exercise_4;

//! Ejecucionde instancias de productos y stock (Ejercicio 1)
//??? Instancia con todos los datos
var prod1 = new Product(1, "Laptop", 1500000m, 10);

//??? Instancia con precio por defecto (0)
var prod2 = new Product(2, "Mouse", 50);

//??? Mostrar productos por consola
Console.WriteLine(prod1);
Console.WriteLine(prod2);

//! Ejemplo de uso de los pilares POO con Person, EmployeeFullTime, Manager y Contractor (Ejercicio 2)

//?? Instancia de una persona genérica
Person persona = new Person("Juan Pérez");
Console.WriteLine(persona.Describe()); //! Polimorfismo: Describe()

//?? Instancia de empleado de tiempo completo
EmployeeFullTime empleado = new EmployeeFullTime("Ana Gómez", 25000m);
Console.WriteLine(empleado.Describe());

//?? Instancia de manager con equipo
Manager gerente = new Manager("Carlos Ruiz", 40000m, 5);
Console.WriteLine(gerente.Describe());

//?? Instancia de contratista
Contractor contratista = new Contractor("Laura Díaz", 500m);
Console.WriteLine(contratista.Describe());

//! Ejemplo de uso de interfaces y reportes (Ejercicio 3)
var reportables = new List<IReportable>
{
    new FullTime("Ana", 4_200_000m),
    new Hourly("Luis", 60_000m, 80, 0.13m),
};
foreach (var r in reportables)
    Console.WriteLine(r.BuildReport());

//! Ejercicio 4: uso de PayrollService con inyección de dependencias
var payroll = new List<IPayable>
{
    new FullTime("Ana", 4_200_000m),
    new Hourly("Luis", 60_000m, 80, 0.13m),
};

//?? Calculadora con horas extra y salida a archivo
var overtimeCalc = new OvertimeCalculator(10); //? 10 horas extra
var fileOut = new FileOutput("payroll.txt");
var service = new PayrollService(overtimeCalc, fileOut);
service.Run(payroll);
