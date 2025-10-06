using System.Collections.Generic;

/// Clase que actúa como capa de acceso a datos simulados.
/// Retorna una lista predefinida de eventos disponibles en el sistema.
class AccesoData
{
    /// Obtiene una lista de eventos disponibles, con distintos tipos y restricciones de edad.
    /// <returns>Lista de objetos <see cref="Evento"/>.</returns>
    public List<Evento> obtenerListaEventos()
    {
        List<Evento> eventos = new List<Evento>();

        TipoEvento cultural = new TipoEvento("Cultural");
        TipoEvento deportivo = new TipoEvento("Deportivo");
        TipoEvento exhibicion = new TipoEvento("Exhibición");
        TipoEvento feria = new TipoEvento("Feria");

        Evento eventoUno = new Evento("Evento uno", cultural, true);
        Evento eventoDos = new Evento("Evento dos", deportivo, false);
        Evento eventoTres = new Evento("Evento tres", deportivo, true);
        Evento eventoCuatro = new Evento("Evento cuatro", feria, false);
        Evento eventoCinco = new Evento("Evento cinco", feria, true);
        Evento eventoSeis = new Evento("Evento seis", exhibicion, true);

        eventos.Add(eventoUno);
        eventos.Add(eventoDos);
        eventos.Add(eventoTres);
        eventos.Add(eventoCuatro);
        eventos.Add(eventoCinco);
        eventos.Add(eventoSeis);

        return eventos;
    }
}
