// Empleado por horas, incluye TaxRate
namespace exercise_3
{
    public class Hourly : EmployeeBase, IReportable
    {
        public decimal Rate { get; }
        public int Hours { get; }
        public decimal TaxRate { get; } // retención

        public Hourly(string name, decimal rate, int hours, decimal taxRate = 0.1m)
            : base(name)
        {
            Rate = rate;
            Hours = hours;
            TaxRate = taxRate;
        }

        public override decimal CalculatePayment() => Rate * Hours * (1 - TaxRate);

        public string BuildReport() =>
            $"Por horas: {FullName}, Pago bruto: {(Rate * Hours):C0}, Retención: {TaxRate:P0}, Pago neto: {CalculatePayment():C0}";
    }
}
