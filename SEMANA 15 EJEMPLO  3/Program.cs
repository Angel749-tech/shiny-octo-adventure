using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_15_EJEMPLO__3
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double promedio = 0;
            int[,] m = { { 14, 18, 12 }, { 11, 17, 13 }, { 10, 7, 8} };
            Console.WriteLine("Arreglo bidimensional: ");
            Console.WriteLine();
            // Recorido de un arreglo bidimensional
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    Console.Write(m[fila, columna] + "\t");
                    suma += m[fila, columna];

                }
                Console.WriteLine(); // Salto de linea al terminar una fila
            }
            // PROMEDIO
            promedio = 1.0*suma / (m.GetLength(0)*m.GetLength(1));
            // MAYOR VALOR
            int mayor = m[0,1];
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                 if (m[fila,columna] > mayor)
                    {
                        mayor = m[fila, columna];
                    }   

                }
                Console.WriteLine();
            }

            // MENOR VALOR
            int menor = mayor;
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    if (m[fila, columna] < menor)
                    {
                        menor = m[fila, columna];
                    }
                }
                Console.WriteLine();
            }
            // SUMA DIAGONAL PRINCIPAL

            int diagonal = 0;

            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    if (fila == columna)
                        diagonal += m[fila, columna];
                }
                Console.WriteLine();
            }

          
            Console.WriteLine("\nSuma del arreglo: " + suma);
            Console.WriteLine("\nPromedio del arreglo: " + promedio);
            Console.WriteLine("\nMayor valor del arreglo: " + mayor);
            Console.WriteLine("\nMenor valor del arreglo: " + menor);
            Console.WriteLine("\nDiagonal del arreglo: " + diagonal);




        }
    }
}
