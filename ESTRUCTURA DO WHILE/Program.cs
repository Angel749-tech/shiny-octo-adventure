using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_DO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio3();
            Console.ReadLine();
        }


        static void ejercicio1()
        {

            // Desarrolle un programa que muestre los siguientes valores:
            // Resultado: 3, 6, 9, 12, …, 39, 42, 45

            int n = 3;
            do
            {

                Console.WriteLine(n);
                n += 3;

            }
            while (n <= 45);
        }

        static void ejercicio2()
        {
            // Desarrolle un programa que genere números aleatorios de 4
            // dígitos hasta obtener un número impar menor que 1800. Se debe mostrar:

            // Los números generados, La suma de dichos números, La suma y cantidad de números pares,
            // La suma y cantidad de números impares

            int numeros=0,suma=0, sumapares=0, sumapares2=0, sumaimpares =0, sumaimpares2 = 0, n=0;
            Random rand = new Random();
            do
            {
                numeros = rand.Next(1000, 9999);
                Console.WriteLine(numeros);
                suma += numeros;
                
                if (numeros % 2 == 0)
                {
                    sumapares++;
                    sumapares2 += numeros;
                }

                else
                {
                    sumaimpares++;
                    sumaimpares2 += numeros;
                }
                n++;
            }
            while (numeros % 2 != 0 || numeros > 1800);

            Console.WriteLine($"La suma total es: {suma}, y la cantidad de números generados es {n}");
            Console.WriteLine($"La suma total de pares es : {sumapares2}, y la cantidad de pares es: {sumapares}");
            Console.WriteLine($"La suma total de impares es : {sumaimpares2}, y la cantidad de impares es: {sumaimpares}");
        }

        static void ejercicio3()
        {
            // Desarrolle un programa que genere números aleatorios comprendidos entre 5 y 500
            // hasta obtener un número múltiplo de 3 de 2 cifras.Se debe mostrar:

            // Los números generados
            // La cantidad números de 1 dígito, de dos y tres, respectivamente

            int num1 = 0, num2 = 0, num3 = 0, numeros;
            bool condicion = false;
            Random rand = new Random();

            do
            {
                numeros = rand.Next(5, 501);
                Console.WriteLine(numeros);

                if (numeros < 10)
                    num1++;
                else if (numeros < 100)
                    num2++;
                else
                    num3++;

                // Verificar si es un número de 2 dígitos y múltiplo de 3
                if (numeros >= 10 && numeros < 100 && numeros % 3 == 0)
                {
                    condicion = true; // terminar el ciclo
                }
            }
            while (!condicion);

            Console.WriteLine("La cantidad de números de un dígito es: " + num1);
            Console.WriteLine("La cantidad de números de un dígito es: " + num2);
            Console.WriteLine("La cantidad de números de un dígito es: " + num3);
        }

        static void ejercicio4()
        {
            Random rand = new Random();
            int count1Digito = 0;
            int count2Digitos = 0;
            int count3Digitos = 0;

            int numero;
            bool condicion = false; // para salir del ciclo cuando se cumpla la condición

            do
            {
                numero = rand.Next(5, 501);
                Console.WriteLine($"Número generado: {numero}");

                // Contar según la cantidad de dígitos
                if (numero < 10)
                    count1Digito++;
                else if (numero < 100)
                    count2Digitos++;
                else
                    count3Digitos++;

                // Verificar si es un número de 2 dígitos y múltiplo de 3
                if (numero >= 10 && numero < 100 && numero % 3 == 0)
                {
                    condicion = true; // terminar el ciclo
                }

            } while (!condicion);

            // Mostrar los resultados
            Console.WriteLine("\n----- Resumen -----");
            Console.WriteLine($"Cantidad de números de 1 dígito: {count1Digito}");
            Console.WriteLine($"Cantidad de números de 2 dígitos: {count2Digitos}");
            Console.WriteLine($"Cantidad de números de 3 dígitos: {count3Digitos}");

        }

        static void ejercicio5()
        {


        }

        static void ejercicio6()
        {


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
