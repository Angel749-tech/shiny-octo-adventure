using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11_ARREGLOS_UNIDIMENSIONALES__Teoría_
{
    class Program{
        double suma = 0, promedio = 0;

        static void Main(string[] args)
        {

            ejercicio1();
            Console.ReadLine();
        }

        static void ejercicio1()
        {
            // Arreglo Unidimensional (una sola dimensión)

            int[] n = { 18, 15, 10, 13, 9, 17 };
            int suma;

            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine(n[2]);
            Console.WriteLine(n[3]);
            Console.WriteLine(n[4]);
            Console.WriteLine(n[5]);

            suma = n[0] + n[1] + n[2] + n[3] + n[4] + n[5];

            Console.WriteLine($"La suma es: {suma}");
        }

        
    }
}
