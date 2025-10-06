// Clase base para empleados, almacena nombre
namespace exercise_3
{
    public abstract class EmployeeBase : IPayable
    {
        public string FullName { get; }

        protected EmployeeBase(string name) => FullName = name;

        public abstract decimal CalculatePayment();
    }
}
