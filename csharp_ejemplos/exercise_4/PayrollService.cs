//?? Violación común: servicio mezcla cálculo + consola.
//?? Refactor: separar responsabilidades.
//?? IPaymentCalculator: calcula el pago de cualquier IPayable
namespace exercise_4
{
    public interface IPaymentCalculator
    {
        decimal Calc(IPayable e);
    }

    //?? Calculadora por defecto, solo llama CalculatePayment
    public class DefaultPaymentCalculator : IPaymentCalculator
    {
        public decimal Calc(IPayable e) => e.CalculatePayment();
    }

    //?? Calculadora que suma horas extra si es Hourly
    public class OvertimeCalculator : IPaymentCalculator
    {
        private readonly int _extraHours;

        public OvertimeCalculator(int extraHours) => _extraHours = extraHours;

        public decimal Calc(IPayable e)
        {
            if (e is Hourly h)
                return h.Rate * (h.Hours + _extraHours) * (1 - h.TaxRate);
            return e.CalculatePayment();
        }
    }

    //?? IOutput: salida abstracta
    public interface IOutput
    {
        void WriteLine(string text);
    }

    //?? Salida por consola
    public class ConsoleOutput : IOutput
    {
        public void WriteLine(string t) => Console.WriteLine(t);
    }

    //?? Salida a archivo txt
    public class FileOutput : IOutput
    {
        private readonly string _file;

        public FileOutput(string file) => _file = file;

        public void WriteLine(string text) => System.IO.File.AppendAllText(_file, text + "\n");
    }

    //?? Servicio de nómina, inyecta calculadora y salida
    public class PayrollService
    {
        private readonly IPaymentCalculator _calc;
        private readonly IOutput _out;

        public PayrollService(IPaymentCalculator calc, IOutput output)
        {
            _calc = calc;
            _out = output;
        }

        public void Run(IEnumerable<IPayable> items)
        {
            foreach (var it in items)
                _out.WriteLine($"{it.GetType().Name}: {_calc.Calc(it):C0}");
        }
    }
}

//?? Documentación:
//?? - Cada clase tiene una sola responsabilidad.
//?? - PayrollService usa inyección de dependencias.
//?? - FileOutput escribe en archivo, OvertimeCalculator suma horas extra solo a Hourly.
