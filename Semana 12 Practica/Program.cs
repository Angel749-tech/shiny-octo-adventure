using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12_Practica
{
    class Program
    {
        static byte[] edades = new byte[0];
        static int cantidad=0;

        static void Main(string[] args)
        {
            int opcion;
            string continuar;

            Console.WriteLine("Bievenido al sistema de registro de edades\n");
            Console.WriteLine("*** Menú de opciones***");
            Console.WriteLine("*   1. Insertar       *");
            Console.WriteLine("*   2. Mostrar        *");
            Console.WriteLine("*   3. Eliminar       *");
            Console.WriteLine("*   4. Ordenar        *");
            Console.WriteLine("*   5. SALIR          *");
            Console.WriteLine("***********************");

            do
            {


                Console.WriteLine("Ingrese una opción\n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: insertar(); break;
                    case 2: mostrar(); break;
                    case 3: eliminar(); break;
                    case 4: ordenar(); break;
                    case 5: return;
                }

                Console.WriteLine("Para continuar escriba (Sí): ");
                continuar = Console.ReadLine();
            } while (continuar == "si");

        }

        static void insertar()
        {
            string cont;
            do
            {

                Console.WriteLine("Ingrese la edad");
                byte ed = byte.Parse(Console.ReadLine());
                Array.Resize(ref edades, edades.Length + 1);


                edades[cantidad] = ed;
                cantidad++;
                Console.WriteLine();
                Console.WriteLine("\n\nRegistro correcto.\n\n¿Desea seguir registrando (si)?");
                cont = Console.ReadLine();
                Console.Clear();
            } while (cont == "si");


        }

        static void mostrar()
        {
            Console.WriteLine("\nEdades registrados: ");
            for (int i=0; i < edades.Length; i++)
            {
                Console.Write(edades[i] + ",");
            }

        }

        static void eliminar()
        {
            int indice=-1;
            Console.Write("\nIngrese el número a eliminar: ");
            byte eli = byte.Parse(Console.ReadLine());
            for (int i=0; i < edades.Length; i++)
            {
                if (edades[i] == eli)
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                for (int i = indice; i < edades.Length-1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                cantidad--;
                Console.WriteLine("Edad eliminada con éxito");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("El número no existe no se puede eliminar!");
            }

        }
        static void ordenar()
        {
            for (int i=0; i < edades.Length; i++)
            {
                for (int j = 0; j < edades.Length - i - 1; j++ )
                {
                    if ()
                    {
                        byte temp = edades[i];
                        edades[j] = edades[j + 1];
                        edades[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine("Ordenado correctamente!");
        }
    }
}
