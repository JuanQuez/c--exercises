namespace exercise_2
{
    //* Clase Manager que hereda de EmployeeFullTime
    //* Representa a un gerente con tamaño de equipo
    public class Manager : EmployeeFullTime
    {
        //* Propiedad de solo lectura para el tamaño del equipo
        public int TeamSize { get; }

        //* Constructor que inicializa nombre, salario y tamaño de equipo
        public Manager(string name, decimal salary, int teamSize)
            : base(name, salary)
        {
            TeamSize = teamSize;
        }

        //* Sobrescribe Describe para incluir tamaño de equipo
        public override string Describe()
        {
            return $"Manager: {FullName}, salario: {Salary:C0}, equipo: {TeamSize} personas";
        }
    }

    //* Documentación:
    //* - Manager extiende EmployeeFullTime, aplicando herencia y polimorfismo.
    //* - Encapsula la propiedad TeamSize, solo lectura.
    //* - Describe() muestra todos los datos relevantes del gerente.
}
