using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_9._1
{
    internal class Program
    {
        // VARIABLES GLOBALES (SE PUEDEN USAR EN CUALQUIER PARTE DEL PROGRAMA)
        static int n1, n2, suma, resta, multiplicacion;
        static double division, promedio;

        static void Main(string[] args)
        {
            Console.WriteLine("Número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = int.Parse(Console.ReadLine());

            // Llamamos a la función creada (2)
            suma = sumanumeros();
            resta = restanumeros();
            division = divisionnumeros();
            multiplicacion = multiplicacionnumeros();
            promedio = promedionumeros();

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("Promedio: " + promedio);


            Console.ReadLine();
        }

        static int sumanumeros()
        {
            suma = n1 + n2;
            return suma;
        }

        static int restanumeros()
        {
            resta = n1 - n2;
            return resta;

        }

        static double divisionnumeros()
        {
            division = 1.0 * n1 / n2;
            return division;

        }


        static int multiplicacionnumeros()
        {
            multiplicacion = n1 * n2;
            return multiplicacion;

        }

        static double promedionumeros()
        {
            promedio = 1.0 * (n1 + n2) / 2;
            return promedio;
        }


    }
}
