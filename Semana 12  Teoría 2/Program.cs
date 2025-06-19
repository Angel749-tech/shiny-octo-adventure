using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12__Teoría_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] calificaciones = { 10, 19, 13, 18, 11, 17, 19, 8, 20, 5 };

            Console.WriteLine("*Arreglo calificaciones: { 10, 19, 13, 18, 11, 17, 19, 8, 20, 5 }");

            // 1
            Console.WriteLine("\n*Cantidad de elementos del arreglo calificación: " + tamanio(calificaciones));
            // 2
            //CON USUARIO
            obtenercalificacion(calificaciones);
            // SIN USUARIO
            Console.WriteLine("\n*Calificación almacenada en dicha posición: " + obtenercalificacion2(0, calificaciones));
            // 3
            promediocalificacion(calificaciones);
            // 4
            Console.WriteLine("\n*El menor de todas las calificaciones del arreglo es: " + menorcalificacion(calificaciones));
            // 5
            Console.WriteLine("\n*El mayor de todas las calificaciones del arreglo es: " + mayorcalificacion(calificaciones));
            // 6
            Console.WriteLine("\n*El número de calificaciones aprobadas es de: " + nroCalificacionesAprobatorias(calificaciones));
            // 7
            Console.WriteLine("\n*El número de calificaciones desaprobadas es de: " + nroCalificacionesDesaprobatorias(calificaciones));
            // 8
            Console.WriteLine("\n*La posición de la primera calificación mayor o igual a 13 es (-1 si no existe): " + posPrimeraCalificacionAprobatoria(calificaciones));
            // 9
            Console.WriteLine("\n*La posición de la penúltima calificación desaprobatoria es (-1 si no existe): " + posPenultimaCalificacionDesaprobatoria(calificaciones));
            // 10
            Console.Write($"\n*Las calificaciones actuales reemplazadas por otras aleatorias comprendidas en el rango de 0 a 20 son: "); generarCalificaciones(calificaciones);
            Console.WriteLine("\n");
        }

        static int tamanio(int[] calificaciones)
        {
            int tamanio = 0;
            tamanio = calificaciones.Length;
            return tamanio;
        }

        static int obtenercalificacion(int[] calificaciones)
        {
            int posicion = 0;

            Console.Write("\n--> Digitar la posición para retonar la calificación almacenada en dicha posición (0 a 9): ");
            int obtenercalificacion=int.Parse(Console.ReadLine());
            if (obtenercalificacion >= 0 && obtenercalificacion <= 9)
            {
                posicion = calificaciones[obtenercalificacion];

                Console.WriteLine("\n*La posición digitada retorna la calificación: " + posicion);
            }
            else
                Console.WriteLine("¡Error en la digitación: Se esperaba un digito numérico entre el 0 y el 9!");
            return obtenercalificacion;
        }
        static int obtenercalificacion2(int posicion, int[] calificaciones)
        {
            int obtenercalificacionprime = calificaciones[posicion];
            return obtenercalificacionprime;
        }
        static double promediocalificacion(int [] calificaciones)
        {
            double promedio = 0, suma=0;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
               
            }

            promedio = 1.0 * suma / calificaciones.Length;

            Console.WriteLine("\n*El promedio de las calificaciones es : " +promedio);

            return promedio;
        } 

        static int menorcalificacion(int[] calificaciones)
        {
            int menor = 10000;

            for (int i = 0;i < calificaciones.Length; i++)
            {
                if (calificaciones [i] < menor)
                    menor = calificaciones [i];
                
            }
            return menor;
        }

        static int mayorcalificacion(int[] calificaciones)
        {
            int mayor = calificaciones[0];

            for (int i = 0; i < calificaciones.Length;i++)
            {
                if (calificaciones [i] >  mayor)
                    mayor = calificaciones[i];

            }
            return mayor;
        }

        static int nroCalificacionesAprobatorias(int[] calificaciones)
        {
            int nro = 0;
            for (int i = 0; i < calificaciones.Length; ++i)
            {
                if (calificaciones[i] >= 13)
                    nro++;

            }
           return nro;
        }

        static int nroCalificacionesDesaprobatorias(int[] calificaciones)
        {
            int nro2 = 0;
            for(int i = 0;i < calificaciones.Length; i++)
            {
                if (calificaciones[i] < 13)
                    nro2++;
            }
            return nro2;
        }

        static int posPrimeraCalificacionAprobatoria(int[] calificaciones)
        {

            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] >= 13)
                    return calificaciones[i];
            }
            return -1; // Si no existe
        }

        static int posPenultimaCalificacionDesaprobatoria(int[] calificaciones)
        {
            int pen = 0;
            for (int i = calificaciones.Length-1; i >= 0; i--)
            {
                if (calificaciones[i] < 13)
                {
                    pen++;
                    if (pen == 2)
                        return calificaciones[i];
                }

            }
            return -1; // Si no existe
        }

        static void generarCalificaciones(int[] calificaciones)
        {
            Random notas = new Random();
            for (int i = 0;i < calificaciones.Length; i++)
            {
                calificaciones [i] = notas.Next(0,20);

              Console.Write(calificaciones[i] + ",");
            }

        }

    }
}
