using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doblemente_ligada
{
    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo atras = new Nodo();

        public Lista()
        {
            primero = null;
            atras = null;
        }

        public void insertarnodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write(" ingrese el numero para la lista doble ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero == null) 
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                atras = primero;
            }

            else
            {
                atras.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = atras;
                atras = nuevo; 
            }
            Console.Write(" El numero fue ingresado con exito ");
        }

        public void desplegarListaPU()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Siguiente;
            }
        }
        public void desplegarlistaUP()
        {
            Nodo actual = new Nodo();
            actual = atras;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Atras;
            }
        }
    }
}
