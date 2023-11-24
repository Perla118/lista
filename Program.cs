using System;
using static lista.Lista;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista listaPerros = new Lista();

            // Agregar perros a la lista
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Max", Raza = "Labrador", Tamaño = "Grande" });
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Bella", Raza = "Chihuahua", Tamaño = "Pequeño" });
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Rocky", Raza = "Bulldog", Tamaño = "Mediano" });

            // Mostrar la información de los perros en la lista
            listaPerros.ImprimirLista();
        }
    }
}
