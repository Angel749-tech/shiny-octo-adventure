using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_PRACTICA;

namespace Semana_9._4_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Triángulo t = new Triángulo();
            Cuadrado c = new Cuadrado();
            Rectángulo r = new Rectángulo();
            Trapecio tra = new Trapecio();


            int opcion, opcion2;
            string continuee;

            do
            {

                do
                {

                    Console.WriteLine("Bievenido al sistema de cálculos de áreas y perímetros\n");
                    Console.WriteLine("*** Menú de opciones***");
                    Console.WriteLine("*   1. Triángulo      *");
                    Console.WriteLine("*   2. Cuadrado       *");
                    Console.WriteLine("*   3. Rectángulo     *");
                    Console.WriteLine("*   4. Trapecio       *");
                    Console.WriteLine("*   5. SALIR          *");
                    Console.WriteLine("***********************");

                    Console.WriteLine("Ingrese una opción\n");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (opcion < 0 || opcion > 4);

                switch (opcion)
                {
                    case 0: Console.WriteLine("Cerrando..."); return;
                    case 1:
                        Console.WriteLine("*** Triángulo***");
                        Console.WriteLine("* 1. Área      *");
                        Console.WriteLine("* 2. Perímetro *");
                        Console.WriteLine("****************");

                        Console.WriteLine("Ingrese una opción: ");
                        opcion2 = int.Parse(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1: t.area(); break;
                            case 2: t.perimetro(); break;
                        }



                        break;

                    case 2:
                        Console.WriteLine("*** Cuadrado ***");
                        Console.WriteLine("* 1. Área      *");
                        Console.WriteLine("* 2. Perímetro *");
                        Console.WriteLine("****************");

                        Console.WriteLine("Ingrese una opción: ");
                        opcion2 = int.Parse(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1: c.area(); break;
                            case 2: c.perimetro(); break;
                        }

                        break;
                    case 3:

                        Console.WriteLine("** Rectángulo **");
                        Console.WriteLine("* 1. Área      *");
                        Console.WriteLine("* 2. Perímetro *");
                        Console.WriteLine("****************");

                        Console.WriteLine("Ingrese una opción: ");
                        opcion2 = int.Parse(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1: r.area(); break;
                            case 2: r.perimetro(); break;
                        }

                        break;

                    case 4:

                        Console.WriteLine("*** Trapecio ***");
                        Console.WriteLine("* 1. Área      *");
                        Console.WriteLine("* 2. Perímetro *");
                        Console.WriteLine("****************");

                        Console.WriteLine("Ingrese una opción: ");
                        opcion2 = int.Parse(Console.ReadLine());

                        switch (opcion2)
                        {
                            case 1: tra.area(); break;
                            case 2: tra.perimetro(); break;
                        }

                        break;
                }

                Console.WriteLine("\n¿Desea continuar? (S = Sí, deseo continuar... / Presionar otra tecla para cerrar): ");
                continuee = Console.ReadLine();
                Console.Clear();

            }
            while (continuee == "S" || continuee == "s");

        }
    }
}
