/// Representa a una persona menor de edad que puede estar restringida en algunos eventos.
/// Hereda de <see cref="Persona"/>.
class Ninno : Persona
{
    /// Constructor para crear un niño con nombre y edad.
    /// <param name="nombre">Nombre del niño.</param>
    /// <param name="edad">Edad del niño.</param>
    public Ninno(string nombre, int edad)
        : base(nombre, edad) { }
}
