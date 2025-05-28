using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_PRACTICA
{
    public class Trapecio
    {

        public void area()
        {
            Console.WriteLine("Ingrese base mayor: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese base menor: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("El área del trapecio es: " + 1.0 * ((B + b) / 2) * h);

        }

        public void perimetro()
        {

            Console.WriteLine("Ingrese base mayor: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese base menor: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un lado del trapecio: ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("El área del trapecio es: " + (B + b + l + l));
        }
    }
}
