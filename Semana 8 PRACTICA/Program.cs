using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_8_PRACTICA
{
    internal class Program
    {
        double x, y;

        static void Main(string[] args)
        {
            int opcion;
            char continuar;




            do
            {

                do
                {
                    Console.WriteLine("\nCalculadora C#:");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine("0. Salir");

                    Console.WriteLine("\nIngrese una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 0 || opcion >= 4);

                Console.WriteLine("Ingrese X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Y");
                int y = int.Parse(Console.ReadLine());

                switch (opcion)

                {

                    case 0: Console.WriteLine("Cerrando..."); return;
                    case 1:
                        suma(x, y);
                        break;
                    case 2:
                        resta(x, y);
                        break;
                    case 3:
                        division(x, y);
                        break;
                    case 4:
                        multiplicacion(x, y);
                        break;
                }

                Console.WriteLine("\n¿Desea continuar? (S/N): ");
                continuar = Console.ReadKey().KeyChar;
                Console.Clear();

            }
            while (continuar != 'N');


        }


        static void suma(int x, int y)
        {
            Console.WriteLine("La suma es: " + (x + y));
        }

        static void resta(int x, int y)
        {
            Console.WriteLine("La resta es: " + (x - y));
        }


        static void division(int x, int y)
        {
            if (y != 0)
                Console.WriteLine("La división es: " + (x / y));
            else
                Console.WriteLine("No se puede dividir entre cero");
        }


        static void multiplicacion(int x, int y)
        {
            Console.WriteLine("La multiplicación es: " + (x * y));
        }


    }
}
