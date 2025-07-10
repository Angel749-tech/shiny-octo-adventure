using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15_EJEMPLO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[] n = { 11, 10, 15, 19, 20 }; // Arreglo unidimensional

            for (int i=0; i < n.Length; i++)
            {
                suma += n[i];
            }

            Console.WriteLine("La suma es: " + suma);



        }
    }
}
