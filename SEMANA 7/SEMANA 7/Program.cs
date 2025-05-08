using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio11();
            Console.ReadKey();
        }

        static void ejercicio1()
        {

            int numero = 1;

            while (numero < 6)
            {


                Console.WriteLine(numero);
                numero++;
            }

            Console.ReadKey();

        }

        static void ejercicio2()
        {


            int numero= 1, suma=0;

            while (numero <= 100)
            {


                Console.WriteLine(numero);
                suma += numero;
                numero++;


            }

            Console.WriteLine($"Suma: {suma}");

            Console.ReadKey();
        }

        static void ejercicio3()
        {

            int repetir = 1, serie=5, sumaserie = 0;

            while (repetir <= 50)
            {

                repetir++;
                Console.WriteLine(serie);
                sumaserie += serie;
                serie += 6;
;

                ;


            }

            Console.WriteLine($"Suma: {sumaserie}");

            Console.ReadKey();


        }
        static void ejercicio4()
        {

            int numero = 7, numero2 = 12, numero3 = 18;

            while (numero <= 1)
            {
                Console.WriteLine(numero + "\t" + numero2 + "\t" + numero3);
                numero--;
                numero2 -= 2;
                numero3 -= 3;

            }

        }

        static void ejercicio5()
        {

            int i1, i2, x;

            Console.WriteLine("Ingresar el primer número del invertalo (inferior)");
            i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo número del invertalo (superior)");
            i2 = int.Parse(Console.ReadLine());

            x = i1;

            Console.WriteLine("Lista de pares: ");

            while (x <= i2)
            {

                // Condición
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }

                // INCREMENTO O DECREMENTO
                x++;


            }

        }

        static void ejercicio6()
        {
            int i, x, contadordiv=0;
            Console.WriteLine("Ingresar un número para hallar sus divisores (entero)");
            i = int.Parse(Console.ReadLine());

            x = 1;
            Console.WriteLine("Lista de pares: ");

            while (x <= i)
            {
                if (i % x == 0)
                {

                    Console.WriteLine(x);
                    contadordiv++;
                }
                x++;

            }
            Console.WriteLine("La cantidad de divisores es: " + contadordiv);
        }

        static void ejercicio11()
        {

            int num;

            do
            {
                Console.WriteLine("Ingresar un número: ");
                num = int.Parse(Console.ReadLine());
            } while (num >= 0);

        }
    }
}
