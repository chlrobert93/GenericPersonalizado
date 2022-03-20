using System;
using System.Collections.Generic;

namespace GenericPersonalizado
{
    internal class Program
    {

        public class ListaElementos<T>
        {
            //Crear nuestra lista
            private List<T> elementos;

            //Constructor
            public ListaElementos()
            {
                //Instancia
                elementos = new List<T>();
            }

            //Métodos
            public void Agregar(T nuevoElemento)
            {
                elementos.Add(nuevoElemento);

            }


            public void Eliminar( T elementoEliminar)
            {
                elementos.Remove(elementoEliminar);

            }


            public void Listar()
            {
                foreach (T nuevoElemento in elementos)
                {
                    Console.WriteLine("El elemento es: {0}", nuevoElemento);
                }
            }

        }
        static void Main(string[] args)
        {
            //Crear nueva instancia
            ListaElementos<int> ListaEntera = new ListaElementos<int>();

            ListaEntera.Agregar(1);
            ListaEntera.Agregar(2);
            ListaEntera.Agregar(3);
            ListaEntera.Agregar(4);
            ListaEntera.Eliminar(2);


            ListaEntera.Listar();

            Console.ReadKey();


            ListaElementos<string> ListaCadena = new ListaElementos<string>();

            ListaCadena.Agregar("Bob Toronja");
            ListaCadena.Agregar("Patricio estrella");
            ListaCadena.Agregar("Calamardo");

            ListaCadena.Eliminar("Calamardo");

            ListaCadena.Listar();
            Console.ReadKey();

        }
    }
}
