using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ejercicio3();
            Console.ReadKey();
          
        }


        static void ejercicio1()
        {

            int num1;
            Console.WriteLine("Ingresa un numero");
            num1= int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Es par");

            }
            else
            {
                Console.WriteLine("Es impar");
            }

        }

        static void ejercicio2()
        {
            int edad;
            Console.WriteLine("ingrese una edad");
            edad=int.Parse(Console.ReadLine());

           if (edad < 0)
            {
                Console.WriteLine("Edad invalida");

            }
           else if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");

            }
           else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

        static void ejercicio3()
        {


        }
    }
}
