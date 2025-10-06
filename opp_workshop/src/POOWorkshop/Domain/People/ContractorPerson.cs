namespace POOWorkshop.Domain.People;

// Sellada: no admite más herencia
public sealed class ContractorPerson : Person
{
    public decimal HourRate { get; }
    public ContractorPerson(string name, decimal hourRate) : base(name)
    {
        if (hourRate <= 0) throw new ArgumentOutOfRangeException(nameof(hourRate));
        HourRate = hourRate;
    }
}
