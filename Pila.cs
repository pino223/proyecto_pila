using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Pila
    {
        private int MAX;
        private int tope = 0;
        private Nodo inicio;
        public Pila(int max)
        {
            MAX = max;
            inicio = null;
        }

        public bool Empty()
        {
            if (inicio == null)
                return true;
            else 
                return false;
        }

        public bool Full()
        {
            if(tope==MAX)
                return true;
            else
                return false;
        }

        public void PrintStack()
        {
            if (Empty())
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            Nodo act = inicio;
            Console.WriteLine("Elementos de la pila:");
            while (act != null)
            {
                Console.WriteLine(act.Valor);
                act = act.Sig;
            }
            //Imprime la pila
        }

        public bool Push(int num)
        {
            if(Full())
            {
                Console.WriteLine("La pila esta llena");
                return false;
            }
            else
            {
                Nodo nuevoNodo = new Nodo(num);
                nuevoNodo.Sig = inicio;
                inicio = nuevoNodo;
                tope++;
                return true;
                
            }
            //regresa true si la inserccion es exitosa
            //regresa false si la píla esta llena y no se inserto
        }

        public int Pop() 
        {
            if (Empty())
            {
                Console.WriteLine("La pila está vacía.");
                return -1;
            }

            int valor = inicio.Valor;
            inicio = inicio.Sig;
            tope--;
            return valor;
            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1
        }

        public void Establecer_Tamaño(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor que 0");
            }

            MAX += cantidad;
            Console.WriteLine($"Capacidad de la pila incrementada. Nuevo tope máximo: {MAX}");
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
