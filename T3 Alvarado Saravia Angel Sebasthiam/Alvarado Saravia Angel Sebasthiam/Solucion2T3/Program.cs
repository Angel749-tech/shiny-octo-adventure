using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Solucion2T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] arreglo = new int[6];

            // Función que llena el arreglo
            lenarFunciones(arreglo);
            // Imprimir arreglo
            Console.WriteLine("\nDatos del arreglo: "); imprimirfunciones(arreglo);
            // Antepenúltimo múltiplo de 5
            int antepenultimo=antepenultimoquintuploFunciones(arreglo);
            Console.WriteLine("\nAntepenúltimo múltiplo de 5: " + antepenultimo);
            // Tercer número par
            int postercerpar= posiciontercernumeroparALVARADOSARAVIA(arreglo);
            Console.WriteLine("\nTercer número par: " + postercerpar);
            Console.WriteLine("\nGAAAAAAAAAAAAAAAAA");
        }

        static void lenarFunciones(int[] arreglo)
        {
            Random random = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = random.Next(0, 500 + 1);
            }
        }

        static void imprimirfunciones(int[] arreglo)
        {
            for (int i = 0;i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + ", ");
            }
        }

        static int antepenultimoquintuploFunciones(int[] arreglo)
        {
            int sum = 0;
            for (int i = arreglo.Length - 1; i >= 0; i--)
            {
                if (arreglo[i] % 5 == 0)
                {
                    sum ++;
                    if (sum == 3)
                    {
                        return arreglo[i];
                    }
                }
            }
            return -1; // Si no existe
        }

        static int posiciontercernumeroparALVARADOSARAVIA(int[] arreglo)
        {
            int num = 0;
            for(int i = 0; i < 6; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    num ++;
                    if (num == 3)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
