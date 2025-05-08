using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio7();
            Console.ReadLine();
        }

        static void ejercicio1()
        {

            int i = 1;

            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;

            }

        }



        static void ejercicio2()
        {

            int n = 1;

            Console.WriteLine("Ingrese un número, (0) para salir");

            while (n != 0)
            {

                Console.Write("Número: ");
                n = int.Parse(Console.ReadLine());


            }

            Console.WriteLine("\nPrograma finalizado.");

        }

        static void ejercicio3()
        {



            Console.WriteLine("Ingrese un número entero");

           int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("El número debe ser positivo, ingresar nuevamente...");

                n = int.Parse(Console.ReadLine());
            }



            while (n >= 0)
            {

                Console.WriteLine(n);
                n--;
            }



        }



        static void ejercicio4()
        {
            int tabla = 1;
            Console.WriteLine("Ingrese un número del 1 al 12");
            tabla = int.Parse(Console.ReadLine());

            while (tabla <= 0)
            {
                Console.WriteLine("Núimero inválido. Ingrese nuevamente: ");
                tabla = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            int i = 1;

            while (i <= 12)
            {

                Console.WriteLine($"{i}*{tabla} = {i * tabla}");
                i++;

            }

        }

        static void ejercicio5()
        {

            int num=-1, sumapar=0, sumaimpar=0;
            while (true)
            {
                Console.WriteLine("Ingresar un número");
                num = int.Parse(Console.ReadLine());

                if (num == 0) break;
                if (num < 0)
                {
                    Console.WriteLine("Solo se permiten número enteros positivos mayores a 0");
                    num = int.Parse(Console.ReadLine());
                    continue;
                }

                if (num % 2 == 0) sumapar += num;
                else sumaimpar += num;
               
            }


            Console.WriteLine();
            Console.WriteLine("Sumas de pares: " + sumapar);
            Console.WriteLine("Suma de impares: " + sumaimpar);

        }


        static void ejercicio6()
        {
            int f, c;

            Console.WriteLine("Ingresar el número de filas");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el número de columnas");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int i = 0;
            while (i < f)
            {
                int j = 0;
                while (j < c)
                {
                    Console.Write("*");
                    j++;
                }

                Console.WriteLine();
                i++;
            }
        }

        static void ejercicio7()
        {

            string c, cc; 
            int i = 0;

            Console.WriteLine("Ingresar una contraseña");
            c = Console.ReadLine();
            Console.WriteLine("Validar contraseña(tres intentos máximo)");
            cc = Console.ReadLine();

            while (i <= 3)
            {
                if (cc == c)
                {
                    Console.WriteLine("Acceso aceptado");
                    return;
                }
                else
                {
                    i++;
                    if (i > 0) Console.WriteLine("Acceso denegado");
                    else Console.WriteLine("\n Acceso bloqueado, has superado el límite de intentos posibles");
                }


            }
     

        }
    }

}
