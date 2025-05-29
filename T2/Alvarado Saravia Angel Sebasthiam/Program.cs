using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvarado_Saravia_Angel_Sebasthiam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n2 = 3, cantidaddenumeros = 0, sumadenumeros = 0, promediodelosnumeros, mayordelosnumeros = 0;
            // Desarrolle un programa que muestre los múltiplos de 3 a partir del 3 hasta el número que el usuario ingrese en la consola.
            Console.WriteLine("Por favor, digite un número entero a partir del 3 en adelante para mostrar los múltiplos del tres hasta el susodicho: \n");
            int n = int.Parse(Console.ReadLine());

            if (n <= 3)
            {
                Console.WriteLine("Error, no se puede calcular los múltiplos de 3");
            }
            else
                while (n2 <= n)
                {

                    if (n2 % 3 == 0)
                    {
                        Console.WriteLine("Multiplo de 3: ");
                        Console.WriteLine(n2);
                        
                        cantidaddenumeros++;
                        sumadenumeros += n2;
                    }
                    n2++;

                }
            if (n % 3 == 0)
            {
                mayordelosnumeros = +n;
            }
            else
            {

            }

            promediodelosnumeros = ((sumadenumeros) / cantidaddenumeros);
            Console.WriteLine("\nAdemás: \n");
            Console.WriteLine("La cantidad de los numeros son: " + cantidaddenumeros);
            Console.WriteLine("La suma de los números son: " + sumadenumeros);
            Console.WriteLine("El promedio de los números son: " + promediodelosnumeros);
            Console.WriteLine("El mayor de los números es " + (mayordelosnumeros));
        }
    }
}
