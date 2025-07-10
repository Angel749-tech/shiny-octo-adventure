using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_15_EJEMPLO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 14, 18, 12, 9, 16 }, { 11, 17, 13, 19, 6 }, { 10, 7, 8, 15, 12 } };
            Console.WriteLine("Arreglo bidimensional: ");
            Console.WriteLine();
            // Recorido de un arreglo bidimensional
            for (int fila = 0; fila < m.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m.GetLength(1); columna++)
                {
                    Console.Write(m[fila,columna] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine(m[2, 3]);






        }
    }
}
