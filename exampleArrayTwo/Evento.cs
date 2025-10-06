/// Representa un evento dentro del sistema.
/// Puede ser de distintos tipos y puede estar restringido solo a adultos.
class Evento
{
    /// Contador estático que lleva la cantidad de eventos creados.
    public static int numeroDeEventos = 0;

    /// Nombre del evento.
    public string NombreEvento { get; set; }

    /// Tipo del evento (ejemplo: cultural, deportivo, feria, etc.).
    public TipoEvento Tipo { get; set; }

    /// Indica si el evento está restringido únicamente para adultos.
    public bool SoloAdultos { get; set; }

    /// Constructor para crear un evento con nombre, tipo y restricción de edad.
    /// <param name="nombreEvento">Nombre del evento.</param>
    /// <param name="tipo">Tipo de evento.</param>
    /// <param name="soloAdultos">True si es exclusivo para adultos, false en caso contrario.</param>
    public Evento(string nombreEvento, TipoEvento tipo, bool soloAdultos)
    {
        this.NombreEvento = nombreEvento;
        this.Tipo = tipo;
        this.SoloAdultos = soloAdultos;
        numeroDeEventos++;
    }
}
