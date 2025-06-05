using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11_Ejercicio_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] n = { 18, 15, 10, 13, 9, 17 };
            // recorido del arreglo
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }



            int cAP = 0, dAP = 0;

            for (int i = 0; i < n.Length; i++)
            {

                // Aprobados y desaprobados
                if (n[i] >= 12)
                {
                    cAP++;

                }
                else
                    dAP++;
            }

            //Llamamos a la funciòn que calcula el promedio
            // La funciòn recibirà un arreglo
            double promedio2;
            promedio2 = promedio(n);
            int mayor1=0;
            mayor1 = mayornumero(n);
            int menor1 = 0;
            menor1 = menornumero(n);
            Console.WriteLine($"Los aprobados son: {cAP}");
            Console.WriteLine($"Los deaprobados son: {dAP}");
            Console.WriteLine($"El promedio de todas las notas es (con dos decimales): {Math.Round(promedio2, 2)}");
            Console.WriteLine($"El mayor de todas las notas es: {mayor1}");
            Console.WriteLine($"El mayor de todas las notas es: {menor1}");
        }


        static double promedio(int[] n)
        {
            // Promedio
            double promedio;
            int suma = 0;
            for (int i = 0; i < n.Length; i++)
            {
                suma += n[i];
            }
            promedio = 1.0 * suma / n.Length;
            return promedio;
        }

        static int mayornumero(int[]n)
        {
            int mayor = 0;
            for (int i = 0; i < n.Length; i++)
            {

                // Mayor nota
                if (n[i] > mayor)
                    mayor = n[i];
            }

            return mayor;
        }
        static int menornumero(int[] n)
        {
            int menor = n[0];
            for (int i = 0; i < n.Length; i++)
            {

                // Mayor nota
                if (n[i] > menor)
                    menor = n[i];
            }

            return menor;
        }

}
