using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_15_EJEMPLO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, sum2 = 0, sum3 = 0, sum4 = 0, sumab = 0,sumac = 0;
            int[,] m = { { 14, 18, 12 }, { 11, 17, 13 }, { 10, 7, 8 } };

            // SUMA FILA
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    suma += m[fila, columna];

                }
                Console.WriteLine("Suma fila " +fila + ": "+ suma);
                suma = 0;             
            }

            // SUMA COLUMNA
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    if (columna == 0)
                        sum2 += m[fila, columna];
                    if (columna == 1)
                        sum3 += m[fila, columna];
                    if (columna == 2)
                        sum4 += m[fila, columna];
                }
            }
            Console.WriteLine("Suma columna 1: " + sum2);
            Console.WriteLine("Suma columna 2: " + sum3);
            Console.WriteLine("Suma columna 3: " + sum4);


            // SUMA CONTORNO MATRIZ + Y SI ES PAR
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    if (fila == 0 || columna == 0 || fila == m.GetLength(0) - 1 || columna == m.GetLength(1) - 1)
                    {
                        if (m[fila,columna] % 2 == 0)
                            sumab += m[fila, columna];
                    }
                    else
                        sumac += m[fila, columna];

                }
            }

            Console.WriteLine("Suma contorno: " + sumab);
            Console.WriteLine("Suma dentro del contorno: " + sumac);
        }
    }
}
