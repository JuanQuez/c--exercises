using System;
using System.Collections.Generic;

/// Clase principal del programa.
/// Punto de entrada que inicializa los datos y gestiona la interacción por consola.
AccesoData data = new AccesoData();
List<Evento> eventos = data.obtenerListaEventos();

OrquestadorConsola.solicitarDatosPersonas();
OrquestadorConsola.imprimirEventos(eventos);
