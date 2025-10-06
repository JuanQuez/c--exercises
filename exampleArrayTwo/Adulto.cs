/// Representa a una persona adulta que puede asistir a todos los eventos.
/// Hereda de <see cref="Persona"/>.
class Adulto : Persona
{
    /// Constructor para crear un adulto con nombre y edad.
    /// <param name="nombre"></param>
    /// <param name="edad"></param>
    public Adulto(string nombre, int edad)
        : base(nombre, edad) { }
}
