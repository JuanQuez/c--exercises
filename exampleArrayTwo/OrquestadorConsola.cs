using System;
using System.Collections.Generic;

/// Clase estática que organiza la interacción por consola con el usuario.
/// Permite registrar personas, imprimir estadísticas y mostrar los eventos a los que pueden asistir.
static class OrquestadorConsola
{
    private static List<Persona> personas = new List<Persona>();

    /// Solicita al usuario el registro de personas mediante consola.
    /// Pide nombre y edad, luego determina si es adulto o niño y los agrega a la lista.
    public static void solicitarDatosPersonas()
    {
        int opcion;
        do
        {
            Console.WriteLine(
                "Acá puede inscribir las personas para saber a cuáles eventos pueden asistir."
            );
            Console.WriteLine(
                "Si desea inscribir una persona digite un número diferente al 0. Si desea salir digite el número 0"
            );

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0; // Manejo de error mínimo: si no es número, se toma como salir.
            }

            if (opcion != 0)
            {
                Console.WriteLine("Digite el nombre completo de la persona y luego la edad:");
                string nombre = Console.ReadLine();
                int edad = Int32.Parse(Console.ReadLine());

                Persona persona = edad < 18 ? new Ninno(nombre, edad) : new Adulto(nombre, edad);

                personas.Add(persona);
            }
        } while (opcion != 0);

        imprimirPersonas();
    }

    /// Muestra cuántas personas se han registrado, desglosadas en niños y adultos.
    public static void imprimirPersonas()
    {
        Console.WriteLine("La cantidad de personas registradas es: " + personas.Count);
        int numeroNinnos = 0;
        int numeroAdultos = 0;

        foreach (Persona persona in personas)
        {
            if (persona is Ninno)
            {
                numeroNinnos++;
            }
            else
            {
                numeroAdultos++;
            }
        }

        Console.WriteLine("La cantidad de niños registrados es: " + numeroNinnos);
        Console.WriteLine("La cantidad de adultos registrados es: " + numeroAdultos);
    }

    /// Imprime los eventos disponibles y verifica qué personas pueden asistir.
    /// <param name="eventos">Lista de eventos disponibles.</param>
    public static void imprimirEventos(List<Evento> eventos)
    {
        foreach (Evento evento in eventos)
        {
            string variante = evento.SoloAdultos ? "no" : "sí";
            Console.WriteLine(
                $"En el evento: {evento.NombreEvento} {variante} pueden asistir niños"
            );

            if (evento.SoloAdultos)
            {
                Console.WriteLine("Es decir, las siguientes personas no podrán asistir:");
                foreach (Persona persona in personas)
                {
                    if (persona is Ninno)
                    {
                        Console.WriteLine(persona.Nombre);
                    }
                }
            }
        }
    }
}
