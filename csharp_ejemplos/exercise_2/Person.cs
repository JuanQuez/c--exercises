//* Clase base que representa a una persona genérica
public class Person
{
    //* Propiedad de solo lectura para el nombre completo
    public string FullName { get; }

    //* Constructor que inicializa el nombre completo
    public Person(string fullName)
    {
        FullName = fullName;
    }

    //* Método virtual que describe a la persona (puede ser sobreescrito por clases derivadas)
    public virtual string Describe()
    {
        return $"Persona: {FullName}";
    }
}

//* Clase que representa a un empleado de tiempo completo, hereda de Person
public class EmployeeFullTime : Person
{
    //* Propiedad de solo lectura para el salario
    public decimal Salary { get; }

    //* Constructor que inicializa el nombre y el salario
    public EmployeeFullTime(string name, decimal salary)
        : base(name)
    {
        Salary = salary;
    }

    //* Sobrescribe Describe para mostrar información específica de empleado FT
    public override string Describe()
    {
        return $"Empleado FT: {FullName}, salario: {Salary:C0}";
    }
}

//* Clase que representa a un contratista, hereda de Person
//* Sealed: no puede ser heredada
public sealed class Contractor : Person
{
    //* Propiedad de solo lectura para la tarifa por hora
    public decimal HourRate { get; }

    //* Constructor que inicializa el nombre y la tarifa por hora
    public Contractor(string name, decimal hourRate)
        : base(name)
    {
        HourRate = hourRate;
    }

    //* Describe puede ser sobreescrito si se desea, pero aquí se hereda el de Person
}
