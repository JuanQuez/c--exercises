namespace POOWorkshop.Domain.Payroll;

public class Hourly : EmployeeBase
{
    public decimal Rate { get; }
    public int Hours { get; }

    public Hourly(string fullName, decimal rate, int hours)
        : base(fullName)
    {
        if (rate <= 0)
            throw new ArgumentOutOfRangeException(nameof(rate));
        if (hours < 0)
            throw new ArgumentOutOfRangeException(nameof(hours));
        Rate = rate;
        Hours = hours;
    }

    public override decimal CalculatePayment() => Rate * Hours;

    public override string BuildReport() =>
        $"Hourly -> {FullName}: {Rate:C0} x {Hours} = {CalculatePayment():C0}";
}
