//* Representa a un empleado con información básica y validaciones.

public class Employee
{
    //? Campo privado para almacenar el documento del empleado.
    private string _document;

    //* Identificador único del empleado (solo lectura).

    public int Id { get; }

    //* Nombre completo del empleado.

    public string FullName { get; set; } = "";

    //* Salario base del empleado (solo lectura fuera de la clase).

    public decimal BaseSalary { get; private set; }

    //* Documento del empleado. Valida que no sea nulo ni vacío.

    public string Document
    {
        get => _document;
        set
        {
            //? Validación para asegurar que el documento no sea nulo ni solo espacios.
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Documento requerido");
            _document = value.Trim();
        }
    }

    //* Constructor principal que inicializa todas las propiedades del empleado.

    //* <param name="id">Identificador único (debe ser mayor a 0).</param>
    //* <param name="fullName">Nombre completo del empleado.</param>
    //* <param name="baseSalary">Salario base (debe ser mayor o igual a 1,000,000).</param>
    //* <param name="document">Documento del empleado (no puede ser vacío).</param>
    public Employee(int id, string fullName, decimal baseSalary, string document)
    {
        //? Validación del identificador.
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));
        Id = id;
        FullName = fullName;
        SetBaseSalary(baseSalary); //? Validación y asignación del salario.
        Document = document; //? Validación y asignación del documento.
    }

    //* Permite modificar el salario base, validando el mínimo permitido.

    //* <param name="amount">Nuevo salario base.</param>
    public void SetBaseSalary(decimal amount)
    {
        //? Validación del salario mínimo.
        if (amount < 1_000_000m)
            throw new ArgumentException("Salario mínimo no válido");
        BaseSalary = amount;
    }
}
