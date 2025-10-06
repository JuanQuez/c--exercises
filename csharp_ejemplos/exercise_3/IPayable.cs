// IPayable: obliga a calcular el pago
using exercise_3;

public interface IPayable
{
    decimal CalculatePayment();
}

// IReportable: obliga a generar un reporte
public interface IReportable
{
    string BuildReport();
}

// Posibles errores:
// - No inicializar propiedades en constructor.
// - No implementar interfaces obligatorias.
