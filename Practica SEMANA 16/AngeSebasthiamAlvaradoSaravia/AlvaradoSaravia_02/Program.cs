using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlvaradoSaravia_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };

            Console.WriteLine("\nEl tamaño del arreglo es: " + tamaño(arreglo));
            Console.WriteLine("\nDepósito almacenado en dicha posición: " + obtenerdeposito(arreglo, 0));
            Console.WriteLine("\nEl promedio de todos los depósitos es: " + promedio(arreglo));
            Console.WriteLine("\nEl mayor de todos los depósitos es: " + depositomayor_alvaradoSaravia(arreglo));
            Console.WriteLine("\nEl menor de todos los depósitos es: " + depositomenor_alvaradoSaravia(arreglo));
            Console.WriteLine("\nLa cantidad de depósitos mayores a 3000 es: " + mayores3k_alvaradosaravia(arreglo));
            Console.WriteLine("\nLa cantidad de depósitos menores a 2500 es: " + menores2500_alvaradosaravia(arreglo));
            int primerdep = posprimerdepósito_alvaradosaravia(arreglo);
            Console.WriteLine("\nLa posición del primer depósito encontrado en el rango de 2000 a 2500 es: " + primerdep);
            int posultimodep = posUltimodeposito_alvaradosaravia(arreglo);
            Console.WriteLine("\nLa posición del último depósito encontrado en el rango de 3500 a 4000 es: " + posultimodep);
        }

        static int tamaño(int[] arreglo)
        {
            int tamaño = 0;

            Console.WriteLine("Arreglo:");
            for (int i = 0; i < arreglo.Length; i++)
            {
            Console.Write(arreglo[i] + ",");
            }
            tamaño = arreglo.Length;
            return tamaño;

        }

        static int obtenerdeposito (int[] arreglo, int posición)
        {
            int p=0;
            for (int i = 0;i < arreglo.Length; i++)
            {
                p = arreglo[posición];
            }

            return p;
        }

        static double promedio (int[] arreglo)
        {
            int suma = 0;
            double pro = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }
            
            pro = 1.0* suma / arreglo.Length;

            return pro;
        }

        static int depositomayor_alvaradoSaravia(int[] arreglo)
        {
            int mayor = 1;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                }
            }

            return mayor;
        }

        static int depositomenor_alvaradoSaravia (int[] arreglo)
        {
            int menor = 8000;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] < menor)
                    menor = arreglo[i];
            }
            return menor;
        }

        static int mayores3k_alvaradosaravia (int[] arreglo)
        {
            int mayores = 0;
            for (int i = 0;i < arreglo.Length; i++)
            {
                if ((arreglo[i] > 3000))
                    mayores++;
            }

            return mayores;
        }

        static int menores2500_alvaradosaravia (int[] arreglo)
        {
            int menores = 0;

            for(int i = 0; i<arreglo.Length; i++)
            {
                if ((arreglo[i] < 2500))
                    menores++;
            }

            return menores;
        }

        static int posprimerdepósito_alvaradosaravia (int[] arreglo)
        {

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] >= 2000 && arreglo[i] <= 2500)
                {
                    return i;
                }
            }
            return -1;
        }

        static int posUltimodeposito_alvaradosaravia (int[ ] arreglo)
        {
            int s = 0;

            for (int i = arreglo.Length-1; i >= 0; i--)
            {
                if (arreglo[i] >= 3500 && arreglo[i] <= 4000)
                {
                    s++;
                    
                    if (s == 2)
                    {
                        return i;
                    }
                }
            }

            return -1;

        }
    }
}
