using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    public class Nodo
    {
        private Perro _DatosPerro;
        private Nodo _Siguiente;

        public Nodo()
        {
            _Siguiente = null;
        }
        public Nodo(Perro perro, Nodo siguiente=null)
        {
            DatosPerro = perro;
            _Siguiente = null;
        }

        public Perro DatosPerro
        {
            get { return _DatosPerro; }
            set { _DatosPerro = value; }
        }

        public Nodo Siguiente
        {
            get { return _Siguiente; }
            set { _Siguiente = value; }
        }
    }
}
