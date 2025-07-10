using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_15_EJEMPLO_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 3];

            generardatos(n);
            Console.WriteLine("ARREGLO BIDIMENSIONAL: "); imprimirdatos(n);






        }
        static void generardatos(int[,] n)
        {
            Random random = new Random();
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                for (int col = 0; col < n.GetLength(1); col++)
                {
                    n[fila, col] = random.Next(0, 300 + 1);
                }
            }

        }

        static void imprimirdatos(int[,] n)
        {
            for (int fila = 0; fila < n.GetLength(0); fila++)
            {
                for (int col = 0; col < n.GetLength(1); col++)
                {
                    Console.Write(n[fila, col] + "\t");

                }

                Console.WriteLine();
            }
        }
    }
}
