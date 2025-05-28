using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Estructura_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio2();
            Console.ReadLine();
        }

        // For (inicio; condición; incremento)
        // accion
        // accionn...

        static void ejercicio1()
        {
            //Desarrolle un programa que permita ingresar un número entero
            //e imprima los divisores de dicho valor y la cantidad de divisores hallados.



        }

        static void ejercicio2()
        {
            // Desarrolle un programa que genere aleatoriamente las edades de 30 personas y calcule la edad promedio,
            // la cantidad personas mayores de edad y la cantidad de personas menores de edad.

            int edad, edadsuma = 0, promedio, mayorsuma = 0, menorsuma = 0;

            Random rand = new Random();

            for (int i = 1; i <= 30; i++)
            {
                edad = rand.Next(1, 122);
                Console.WriteLine(edad);
                edadsuma += edad;
                if (edad >= 18)
                {
                    mayorsuma++;
                }
                else
                    menorsuma++;

            }

            promedio = edadsuma/30;

            Console.WriteLine("El promedio de las edades generadas es: " +promedio);
            Console.WriteLine("La cantidad de mayores de edad es: " + mayorsuma);
            Console.WriteLine("La cantidad de menoers de edad es: " + menorsuma);



        }

        static void ejercicio3()
        {

            // Implementa el algoritmo que te permita ingresar un número y realice: Realizar
            // el programa que imprima los números de 0 a 20.

            int n=0;

            Console.WriteLine("Ingrese un número entero");
            n=int.Parse(Console.ReadLine());


                for (n=0; n<=20; n++)
                {
                    Console.WriteLine(n);
                }
            

        }


        static void ejercicio4()
        {
            // Realizar un programa que imprima de forma descendente de 50 a 20.

            for (int n = 50; n <= 20; n--)
            {
                Console.WriteLine(n);
            }
        }


        static void ejercicio5()
        {
            // Realizar un programa que imprima de 0 a 100(de 5 en 5) y sumar todos los valores obtenidos.
            int suma = 0;
            for (int n = 0; n <= 100; n += 5)
            {
                Console.WriteLine(n);
                suma += n;
            }

            Console.WriteLine("La suma de todos los números obtenidos es: " + suma);
            Console.ReadKey();
        }


        static void ejercicio6()
        {
            // Desarrollar un programa que solicite cuantos números se ingresaran, luego
            // permitir que el usuario ingrese los números uno por no, y luego mostrar cuantos
            // números son pares, impares y ceros.

            int cantinumeros, numeros, pares=0,impares=0,ceros=0;

            Console.WriteLine("Ingresa la cantidad de números a ingresar");
            cantinumeros = int.Parse(Console.ReadLine());

            if (cantinumeros > 0)
            {
                for (int n=1; n <= cantinumeros; n++)
                {
                    Console.WriteLine("Ingrese los números uno por uno");
                    numeros = int.Parse(Console.ReadLine());

                    if (numeros == 0)
                    {
                        ceros++;
                    }
                    else
                        if (numeros % 2 == 0)
                        pares++;
                    else
                        impares++;



                }

                Console.WriteLine("La cantidad de pares son: " + pares);
                Console.WriteLine("La cantidad de impares son: " + impares);
                Console.WriteLine("La cantidad de ceros son: " +  ceros);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Número inválido");
            }


        }


        static void ejercicio7()
        {

        }


        static void ejercicio8()
        {

        }


        static void ejercicio9()
        {

        }


        static void ejercicio10()
        {

        }
































    }
}
