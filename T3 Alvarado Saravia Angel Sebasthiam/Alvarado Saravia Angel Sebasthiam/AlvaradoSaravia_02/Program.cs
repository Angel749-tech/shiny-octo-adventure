using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaradoSaravia_02
{
    class Program
    {
        static void Main(string[] args)
        {

            ///// --- Una Empresa comercial le solicita que implemente un arreglo de enteros --
            int[] arreglo = new int[6];
            // Una función que llene el arreglo con valores aleatorios (Entre 1 y 500)
            valoresaleatoriosALVARADOSARAVIA(arreglo);
            // Una función que muestre en consola los datos del arreglo
            Console.WriteLine("Datos del arreglo: "); datosdelarregloALVARADOSARAVIA(arreglo);
            // Una función que calcule y retorne la posición del tercer número par
            Console.Write("\nLa posición del tercer número par es (-1 si no existe): "); posiciontercernumeroparALVARADOSARAVIA(arreglo);
            // Una función que calcule y retorne el antepenúltimo múltiplo de 5
            Console.WriteLine("\nEl antepenultimo multiplo de 5 es (-1 si no existe): " + multiplo5ALVARADOSARAVIA(arreglo));

        }

        static void valoresaleatoriosALVARADOSARAVIA(int[] arreglo)
        {
            Random aleatorio = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = aleatorio.Next(1, 500+1);
            }
        }
        static void datosdelarregloALVARADOSARAVIA(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + ",");
            }
        }
        static int posiciontercernumeroparALVARADOSARAVIA(int[] arreglo)
        {
            int par = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    par++;
                    if (par == 3)
                        Console.Write(arreglo[i]);
                }
            }
            return -1;

        }

        static int multiplo5ALVARADOSARAVIA(int[] arreglo)
        {
            int multiplo = 0;
            for (int i = arreglo.Length-1; i >= 0; i--)
            {
                if (arreglo[i] % 5 == 0)
                {
                    multiplo++;
                    if (multiplo == 3)
                        Console.Write(arreglo[i]);
                }
        
            }
            return -1; // Si no existe
        }
    }
}
