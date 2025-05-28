using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_PRACTICA
{
    public class Cuadrado
    {
        public void area()
        {
            Console.Write("Ingrese un lado: ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Área: " + (l * l));
        }

        public void perimetro()
        {
            Console.Write("Ingrese un lado: ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("Perímetro: " + (l + l + l + l));

        }



    }
}
