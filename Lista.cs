using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    public  class Metodos
    {
        private Nodo inicio;

        // Método para determinar si la lista está vacía
        public bool EstaVacia()
        {
            return inicio == null;
        }

        // Método para obtener la longitud de la lista
        public int Longitud()
        {
            int longitud = 0;
            Nodo actual = inicio;

            while (actual != null)
            {
                longitud++;
                actual = actual.Siguiente;
            }

            return longitud;
        }

        // Método para imprimir los elementos de la lista
        public void ImprimirLista()
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.DatosPerro.Nombre}, Raza: {actual.DatosPerro.Raza}, Tamaño: {actual.DatosPerro.Tamaño}");
                actual = actual.Siguiente;
            }
        }

        // Método para verificar si un elemento está en la lista
        public bool Contiene(Perro perro)
        {
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.DatosPerro.Equals(perro))
                {
                    return true;
                }
                actual = actual.Siguiente;
            }

            return false;
        }

        // Método para devolver la posición de un elemento en la lista
        public int Posicion(Perro perro)
        {
            int posicion = 0;
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.DatosPerro.Equals(perro))
                {
                    return posicion;
                }
                actual = actual.Siguiente;
                posicion++;
            }

            return -1; // Retorna -1 si el elemento no se encuentra en la lista
        }

        // Método para insertar un elemento al principio de la lista
        public void InsertarAlPrincipio(Perro perro)
        {
            Nodo nuevoNodo = new Nodo { DatosPerro = perro, Siguiente = inicio };
            inicio = nuevoNodo;
        }

        // Método para insertar un elemento en el medio de la lista
        public void InsertarEnMedio(Perro perro, int posicion)
        {
            if (posicion < 0 || posicion > Longitud())
            {
                Console.WriteLine("Posición inválida");
                return;
            }

            if (posicion == 0)
            {
                InsertarAlPrincipio(perro);
                return;
            }

            Nodo nuevoNodo = new Nodo { DatosPerro = perro };
            Nodo actual = inicio;

            for (int i = 0; i < posicion - 1; i++)
            {
                actual = actual.Siguiente;
            }

            nuevoNodo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevoNodo;
        }

        // Método para insertar un elemento al final de la lista
        public void InsertarAlFinal(Perro perro)
        {
            Nodo nuevoNodo = new Nodo { DatosPerro = perro, Siguiente = null };

            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                ObtenerUltimoNodo().Siguiente = nuevoNodo;
            }
        }

        // Método para insertar un elemento en una posición especificada por el usuario
        public void InsertarEnPosicion(Perro perro, int posicion)
        {
            if (posicion < 0 || posicion > Longitud())
            {
                Console.WriteLine("Posición inválida");
                return;
            }

            if (posicion == 0)
            {
                InsertarAlPrincipio(perro);
                return;
            }

            if (posicion == Longitud())
            {
                InsertarAlFinal(perro);
                return;
            }

            InsertarEnMedio(perro, posicion);
        }

        // Método para eliminar el primer elemento de la lista
        public void EliminarPrimero()
        {
            if (inicio != null)
            {
                inicio = inicio.Siguiente;
            }
        }

        // Método para eliminar un elemento del medio de la lista
        public void EliminarEnMedio(int posicion)
        {
            if (posicion < 0 || posicion >= Longitud())
            {
                Console.WriteLine("Posición inválida");
                return;
            }

            if (posicion == 0)
            {
                EliminarPrimero();
                return;
            }

            Nodo actual = inicio;

            for (int i = 0; i < posicion - 1; i++)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = actual.Siguiente.Siguiente;
        }

        // Método para eliminar el último elemento de la lista
        public void EliminarUltimo()
        {
            if (inicio == null)
            {
                return;
            }

            if (inicio.Siguiente == null)
            {
                inicio = null;
                return;
            }

            Nodo actual = inicio;

            while (actual.Siguiente.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = null;
        }

        // Método para eliminar un elemento deseado por el usuario en la lista
        public void EliminarElemento(Perro perro)
        {
            if (inicio == null)
            {
                return;
            }

            if (inicio.DatosPerro.Equals(perro))
            {
                inicio = inicio.Siguiente;
                return;
            }

            Nodo actual = inicio;

            while (actual.Siguiente != null && !actual.Siguiente.DatosPerro.Equals(perro))
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }

        // Método para obtener el último nodo en la lista
        private Nodo ObtenerUltimoNodo()
        {
            Nodo actual = inicio;

            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            return actual;
        }
    }
}
