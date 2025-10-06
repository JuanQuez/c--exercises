/// Representa el tipo de un evento (ejemplo: cultural, deportivo, feria, exhibición, etc.).
internal class TipoEvento
{
    private string nombre;

    /// Constructor que asigna el nombre del tipo de evento.
    /// <param name="nombre">Nombre del tipo de evento.</param>
    public TipoEvento(string nombre)
    {
        this.nombre = nombre;
    }
}
