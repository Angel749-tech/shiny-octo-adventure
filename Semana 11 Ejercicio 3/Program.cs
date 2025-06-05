using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            llenardatos(n);
            listarDatos(n);
            // Primer Aprobado
            int primeraprobado = Primeraprobado(n);

            if (primeraprobado == -1)
                Console.WriteLine("No existen aprobados");
            else
                Console.WriteLine("El primer aprobado es: " + primeraprobado);
            // Segundo Aprobado

            int segundoaprobado = Segundoaprobado(n);

            if (segundoaprobado == -1)
                Console.WriteLine("No existen aprobados");
            else
                Console.WriteLine("El segundo aprobado es: " + segundoaprobado);

        }
        // Función que retorna la primera y segunda nota aprobatoria

        static int Primeraprobado(int[]n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 12)
                {
                    return n[i];
                }
         
            }
            return -1; // Retonar -1 cuando no hay aprobados
        }
        static int Segundoaprobado(int[] n)
        {
            int app = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] >= 12)
                {
                    app++;
                    if (app == 2)
                        return n[i];
                }

            }
            return -1; // Retonar -1 cuando no hay aprobados
        }
        // Función que llena el arreglo con números aleatorios de 0 a 20
        static void llenardatos(int[] n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = rnd.Next(0,21);
            }
        }


        // Función que recibe un arreglo y lo imprime

        static void listarDatos(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

        }
    }
}
