using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaradoSaravia_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] serie = { 45, 43, 41, 39, 37, 4, 18, 20, 40, 5, 9, 25, 99, 14, 64};
            int[] serie2 = { 3, 6, 12, 24, 48, 2, 6, 10, 4, 5, 3, 5, 11, 2, 8};
            double[] serie3 = { 15, 7.16, 3.416, 1.625, 0.77083, 2, 3, 2, 10,1, 3, 5, 9, 7, 9};
            // Función que imprime la serie
            Console.WriteLine("* La serie es: "); imprimeserieALVARADOSARAVIA(serie,serie2);
            // Función que suma la serie
            Console.WriteLine("* La suma de la serie es: " + sumaserieALVARADOSARAVIA(serie3));
        }

        static void imprimeserieALVARADOSARAVIA(int[] serie, int[] serie2)
        {
            for (int i = 0; i < serie.Length; i++)
            {
                Console.WriteLine(serie[i] + "/" + serie2[i]);
            }

        }

        static double sumaserieALVARADOSARAVIA(double[] serie3)
        {
            double suma = 0;
            for (int i = 0; i < serie3.Length; i++)
            {
                suma += serie3[i];
            }

            return suma;
        }

    }
}
