using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_9._2_Funcion
{
    internal class Program
    {
        static int suma, resta, multiplicacion;
        static double division, promedio;

        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = int.Parse(Console.ReadLine());

            suma = sumaNumeros(n1, n2);
            resta = restanumeros(n1, n2);
            division = divisionnumeros(n1, n2);
            multiplicacion = multiplicacionnumeros(n1, n2);
            promedio = promedionumeros(n1, n2);

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("Promedio: " + promedio);

            Console.ReadLine();
        }

        // Creamos una función CON párametros (RECIBE VALORES) que calcule y retorne la suma de dos números (1)

        static int sumaNumeros(int a, int b)
        {
            suma = a + b;
            return suma;
        }


        static int restanumeros(int a, int b)
        {
            resta = a - b;
            return resta;

        }

        static double divisionnumeros(int a, int b)
        {
            division = 1.0 * a / b;
            return division;

        }


        static int multiplicacionnumeros(int a, int b)
        {
            multiplicacion = a * b;
            return multiplicacion;

        }

        static double promedionumeros(int a, int b)
        {
            promedio = 1.0 * (a + b) / 2;
            return promedio;
        }

    }
}
