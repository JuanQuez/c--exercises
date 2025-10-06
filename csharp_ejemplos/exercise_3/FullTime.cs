// Empleado tiempo completo
namespace exercise_3
{
    public class FullTime : EmployeeBase, IReportable
    {
        public decimal Monthly { get; }

        public FullTime(string name, decimal monthly)
            : base(name) => Monthly = monthly;

        public override decimal CalculatePayment() => Monthly;

        public string BuildReport() => $"Empleado FT: {FullName}, Pago: {Monthly:C0}";
    }
}
