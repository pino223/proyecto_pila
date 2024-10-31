using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pila stack = null;
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("MENU Pilas");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Establecer Tamaño");
                Console.WriteLine("2.- Push");
                Console.WriteLine("3.- Pop");
                Console.WriteLine("4.- Imprimir");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("---------------------");
                Console.Write("Seleccionar Opción => ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el tamaño de la pila: ");
                        int max = int.Parse(Console.ReadLine());
                        if (stack == null)
                        {
                            stack = new Pila(max);
                            Console.WriteLine("Tamaño de la pila establecido");
                        }
                        else
                        {
                            stack.Establecer_Tamaño(max);
                        }
                        break;

                    case 2:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero establece el tamaño de la pila");
                        }
                        else
                        {
                            Console.Write("Ingresa el número que quieres insertar: ");
                            int num = int.Parse(Console.ReadLine());
                            if (stack.Push(num))
                                Console.WriteLine("Elemento insertado correctamente");
                        }
                        break;

                    case 3:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero establece el tamaño de la pila");
                        }
                        else
                        {
                            int popValue = stack.Pop();
                            if (popValue == -1)
                                Console.WriteLine("La pila está vacía");
                            else
                                Console.WriteLine($"Elemento extraído correctamente: {popValue}");
                        }
                        break;

                    case 4:
                        if (stack == null)
                        {
                            Console.WriteLine("Primero establece el tamaño de la pila");
                        }
                        else
                        {
                            stack.PrintStack();
                        }
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            //Proyecto pilas
            //1-Push Dame el numero a insertar
            //2-Pop Se saco tal numero
            //3-Imprimir 
            //4-Salir
            //Seleccionar opcion

        }
    }
}
