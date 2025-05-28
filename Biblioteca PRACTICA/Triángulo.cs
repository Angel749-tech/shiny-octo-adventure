using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_PRACTICA
{
    public class Triángulo
    {
        public void area()
        {
            Console.Write("Ingrese la altura: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Área= " + (b * h) / 2);

        }

        public void perimetro()
        {
            Console.Write("Ingrese un lado del triángulo: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.Write("Perímetro: " + (l1+l1+l1));
        }
    }
}
