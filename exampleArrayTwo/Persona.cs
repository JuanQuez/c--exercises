/// Clase abstracta que representa a una persona genérica dentro del sistema.
/// Puede ser adulto o niño.
abstract class Persona
{
    /// Nombre de la persona.
    public string Nombre { get; set; }

    /// Edad de la persona.
    public int Edad { get; set; }

    /// Constructor de persona con nombre y edad.
    /// <param name="nombre">Nombre de la persona.</param>
    /// <param name="edad">Edad de la persona.</param>
    public Persona(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
}
