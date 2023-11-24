using System;
using System.Collections.Generic;
//using static lista.Lista;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos listaPerros = new Metodos();

            // Agregar perros a la lista
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Max", Raza = "Labrador", Tamaño = "Grande" });
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Bella", Raza = "Chihuahua", Tamaño = "Pequeño" });
            listaPerros.InsertarAlFinal(new Perro { Nombre = "Rocky", Raza = "Bulldog", Tamaño = "Mediano" });

            // Mostrar la información de los perros en la lista
            listaPerros.ImprimirLista();


            

            // Aquí puedes solicitar entradas al usuario y llamar a los métodos correspondientes.
            // Por ejemplo:
            Console.WriteLine("Ingrese el nombre, raza y tamaño del perro:");
            string nombre = Console.ReadLine();
            string raza = Console.ReadLine();
            string tamaño = Console.ReadLine();

            Perro nuevoPerro = new Perro { Nombre = nombre, Raza = raza, Tamaño = tamaño };

            listaPerros.InsertarAlFinal(nuevoPerro);

            // Puedes continuar solicitando más entradas y llamando a otros métodos según sea necesario.

            // Ejemplo de impresión de la lista después de realizar algunas operaciones:
            Console.WriteLine("Lista de perros:");
            listaPerros.ImprimirLista();

            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Insertar al principio");
                Console.WriteLine("2. Insertar en medio");
                Console.WriteLine("3. Insertar al final");
                Console.WriteLine("4. Insertar en posición");
                Console.WriteLine("5. Eliminar primero");
                Console.WriteLine("6. Eliminar en medio");
                Console.WriteLine("7. Eliminar último");
                Console.WriteLine("8. Eliminar elemento");
                Console.WriteLine("9. Imprimir lista");
                Console.WriteLine("0. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre, raza y tamaño del perro:");
                        string nombre1 = Console.ReadLine();
                        string raza1 = Console.ReadLine();
                        string tamaño1 = Console.ReadLine();

                        Perro perro1 = new Perro { Nombre = nombre1, Raza = raza1, Tamaño = tamaño1 };

                        listaPerros.InsertarAlPrincipio(perro1);
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el nombre, raza y tamaño del perro:");
                        string nombre2 = Console.ReadLine();
                        string raza2 = Console.ReadLine();
                        string tamaño2 = Console.ReadLine();

                        Perro perro2 = new Perro { Nombre = nombre2, Raza = raza2, Tamaño = tamaño2 };

                        Console.WriteLine("Ingrese la posición:");
                        if (int.TryParse(Console.ReadLine(), out int posicion2))
                        {
                            listaPerros.InsertarEnMedio(perro2, posicion2);
                        }
                        else
                        {
                            Console.WriteLine("La posición ingresada no es válida.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el nombre, raza y tamaño del perro:");
                        string nombre3 = Console.ReadLine();
                        string raza3 = Console.ReadLine();
                        string tamaño3 = Console.ReadLine();

                        Perro perro3 = new Perro { Nombre = nombre3, Raza = raza3, Tamaño = tamaño3 };

                        listaPerros.InsertarAlFinal(perro3);
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el nombre, raza y tamaño del perro:");
                        string nombre4 = Console.ReadLine();
                        string raza4 = Console.ReadLine();
                        string tamaño4 = Console.ReadLine();

                        Perro perro4 = new Perro { Nombre = nombre4, Raza = raza4, Tamaño = tamaño4 };

                        Console.WriteLine("Ingrese la posición:");
                        if (int.TryParse(Console.ReadLine(), out int posicion4))
                        {
                            listaPerros.InsertarEnPosicion(perro4, posicion4);
                        }
                        else
                        {
                            Console.WriteLine("La posición ingresada no es válida.");
                        }
                        break;

                    case "5":
                        listaPerros.EliminarPrimero();
                        break;

                    case "6":
                        Console.WriteLine("Ingrese la posición:");
                        if (int.TryParse(Console.ReadLine(), out int posicion6))
                        {
                            listaPerros.EliminarEnMedio(posicion6);
                        }
                        else
                        {
                            Console.WriteLine("La posición ingresada no es válida.");
                        }
                        break;

                    case "7":
                        listaPerros.EliminarUltimo();
                        break;

                    case "8":
                        Console.WriteLine("Ingrese el nombre, raza y tamaño del perro a eliminar:");
                        string nombre8 = Console.ReadLine();
                        string raza8 = Console.ReadLine();
                        string tamaño8 = Console.ReadLine();

                        Perro perro8 = new Perro { Nombre = nombre8, Raza = raza8, Tamaño = tamaño8 };

                        listaPerros.EliminarElemento(perro8);
                        break;

                    case "9":
                        Console.WriteLine("Lista de perros:");
                        listaPerros.ImprimirLista();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
