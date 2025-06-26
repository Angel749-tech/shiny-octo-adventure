using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion1T3
{
    internal class Program
    {
        static double num = 45, dem = 3, suma = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Para la siguiente sucesión: ");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(num + "/" + dem + " = " + num / dem);
                num -= 2;
                dem *= 2;
            }
            suma = SUMA(num, dem);
            Console.WriteLine("La suma de toda la sucesión es: " + suma.ToString("F4"));
            Console.WriteLine("La suma de toda la sucesión es: " + Math.Round(suma, 2));
            Console.WriteLine("La suma de toda la sucesión es: " + suma);

        }

        static double SUMA(double num, double dem)
        {
            double nuM = 45, deM = 3, suma = 0;
            for (int i = 0;i < 15; i++)
            {
                suma += nuM / deM; 
                nuM -= 2;
                deM *= 2;
            }

            return suma; 
        }
    }
}
