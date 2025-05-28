using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_PRACTICA
{
    public class Rectángulo
    {
        public void area()
        {
            Console.WriteLine("Ingrese lado mayor: ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado menor: ");
            int l = int.Parse(Console.ReadLine());

            Console.WriteLine("El área del rectángulo es: " + (l*L));

        }
        public void perimetro()
        {
            Console.WriteLine("Ingrese lado mayor: ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado menor: ");
            int l = int.Parse(Console.ReadLine());


            Console.WriteLine("El área del trapecio es: " + (L+L+l+l));


        }
    }
}
