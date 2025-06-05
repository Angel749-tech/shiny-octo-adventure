using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11_PRACTICA
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio8();
            Console.ReadLine();
        }
        static void ejercicio1()
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Ingrese un número (Máximo cinco números) {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nNúmeros ingresados: ");
            foreach (int n in num)
            {
                Console.Write($"\n");
            }
        }
        static void ejercicio2()
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            Console.WriteLine("Arreglo original");
            foreach (int n in num)
                Console.Write(n + ",");

            Console.WriteLine("\nArreglo modificado: ");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] = 0;
                }

            }
            Console.WriteLine("\nNuevo arreglo: ");
            foreach (int n in num)
                Console.Write(n + ",");
        }

        static void ejercicio3()
        {
            int[] num = { 10, 50, 6, 3, 7, 20 };
            int mayor = 0, menor = num[5];
            Console.WriteLine("Arreglo del problema");
            foreach (int n in num)
                Console.Write(n + ",");


            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > mayor)
                {
                    mayor = num[i];
                }
                if (num[i] < menor)
                {
                    menor = num[i];
                }

            }

            Console.WriteLine($"\nValor Mínimo: {menor} y máximo {mayor}");


        }

        static void ejercicio4()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Ingresa 10 valores uno por uno {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Números pares ingresados: ");
            foreach (int n in num)
            {
                if (n % 2 == 0)
                    Console.Write(n + ",");
            }

        }

        static void ejercicio5()
        {
            Console.WriteLine("Ingrese la cantidad de valores que decea ingresar: ");
            int cant = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] num = new int[cant];
            Console.WriteLine();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese un número: {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }
            Console.WriteLine();
            Console.WriteLine("Números ingresados: ");
            foreach (int n in num)
            {
                Console.Write(n + ";");
            }
            Console.WriteLine();
            Console.WriteLine("La suma de todos los números es: " + suma);
        }

        static void ejercicio8()
        {
            string[] nom = { "jose", "oscar", "carmen", "alexa" };
            foreach (string n in nom)
                Console.WriteLine(n);
            Console.Write("\nIngrese el nombre a modificar: ");
            string ingreso = Console.ReadLine();
            bool modificado = false;
            for (int i = 0; i < nom.Length; i++)
            {
                if (nom[i] == ingreso)
                {
                    Console.WriteLine("Ingrese el nuevo nombre");
                    nom[i] = Console.ReadLine();
                    modificado = true;
                    Console.WriteLine("\nNombres actualizados: ");
                    foreach (string n in nom)
                        Console.WriteLine(n);
                    break;
                }
            }
            if (modificado == false)
            {
                Console.WriteLine("Nombre no encontrado");
            }

        }
    }
}
