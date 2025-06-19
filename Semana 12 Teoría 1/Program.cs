using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Semana_12_Teoría_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100 };
            int obtenerdeposito;
            double obtenerpromedio;

            // LLAMADA A FUNCIONES
            Console.WriteLine($"El arreglo depósito es: [3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 3100]");
            // 1# TAMANIO
            Console.WriteLine($"El tamaño es: {tamanio(deposito)}");
            // 2# OBTENER DEPÓSITO
            obtenerdeposito = obtenerDeposito(deposito);
            // 3# PROMEDIO DE DEPOSITOS
            obtenerpromedio = promedioDepositos(deposito);
            Console.WriteLine($"El promedio de todos los depósitos es: {obtenerpromedio}");
            // 4# MAYOR DEPOSITO
            Console.WriteLine($"El depósito mayor es: {depositoMayor(deposito)}");
            // 5# MAYOR DEPOSITO
            Console.WriteLine($"El depósito menor es: {depositoMenor(deposito)}");
            // 6# CANTIDAD MAYORES A 3000
            Console.WriteLine($"La cantidad de depósitos mayores a 3000 es: {cantidadMayores3000(deposito)}");
            // 6# CANTIDAD MENORES A 2500
            Console.WriteLine($"La cantidad de depósitos menores a 2500 es: {cantidadMenores2500(deposito)}");
            // 7# UBICACIÓN POS PRIMER DEPÓSITO ENTRE 2000 A 2500
            Console.WriteLine($"La posición del primer depósito encontrado en el rango de 2000 a 2500 es (-1 si no existe): {posPrimerDeposito(deposito)}");
            // 7.1# UBICACIÓN POS PRIMER DEPÓSITO ENTRE 2000 A 2500
            Console.WriteLine($"La posición del segundo depósito encontrado en el rango de 2000 a 2500 es (-1 si no existe): {posSEGUNDODeposito(deposito)}");
            // 8# UBICACIÓN POS ULTIMO DEPÓSITO ENTRE 3500 A 4000
            Console.WriteLine($"La posición del ultimo depósito encontrado en el rango de 3500 a 4000 es (-1 si no existe): {posUltimoDeposito(deposito)}");
            // 9# Un método reemplazarDepósito que reciba como parámetros la posición y el nuevo depósito y ejecute el reemplazo en el arreglo.
            reemplazardeposito(2, 5555, deposito);
            // 9.1# Otra forma
            Reeemplazardeposito2(deposito);
            // 10# Intercambiar dos depositos de lugar
            intercambiardepositos(2, 5, deposito);
            // 11# Genera aleatorios
            Console.Write("Los números aleatorios generados del nuevo arreglo entre el rango 0 a 20 son los siguientes: "); generaraleatorio(deposito);



        }
        static int tamanio(int[] deposito)
        {
            int tamanio = deposito.Length;
            return tamanio;
        }
        static int obtenerDeposito(int[] deposito)
        {
            Console.WriteLine("Digitar una posición (de 0 a 9)");
            int obtenerdeposito = int.Parse(Console.ReadLine());
            int posicion = 0;
            if (obtenerdeposito >= 0 && obtenerdeposito <= 9)
            {
                posicion = deposito[obtenerdeposito];
                Console.WriteLine($"Deposito en la posición {obtenerdeposito} seleccionada: ${posicion}");
            }
            else
                Console.WriteLine("¡ERROR! : Digitar una posición válida");
            return obtenerdeposito;
        }

        static double promedioDepositos(int[] deposito)
        {
            double promedio;
            int suma = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            promedio = 1.0 * suma / deposito.Length;

            return promedio;
        }

        static int depositoMayor(int[] deposito)
        {
            int mayor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > mayor)
                    mayor = deposito[i];
            }
            return mayor;
        }

        static int depositoMenor(int[] deposito)
        {
            int menor = 100000;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < menor)
                    menor = deposito[i];
            }
            return menor;

        }

        static int cantidadMayores3000(int[] deposito)
        {
            int mayor3k = 3000, mayor = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > mayor3k)
                    mayor++;
            }
            return mayor;
        }

        static int cantidadMenores2500(int[] deposito)
        {
            int menor = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < 2500)
                    menor++;
            }
            return menor;
        }

        static int posPrimerDeposito(int[] deposito)
        {
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    return deposito[i];
            }

            return -1; // Si no existe
        }

        static int posUltimoDeposito(int[] deposito)
        {
            // Recorrido inverso (Desde la última posición)
            for (int i = deposito.Length - 1; i >= 0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                    return deposito[i];
            }

            return -1; // Si no existe
        }

        // SEGUNDODEPOSITO
        static int posSEGUNDODeposito(int[] deposito)
        {
            int can = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    can++;
                if (can == 2)
                    return deposito[i];
            }

            return -1; // Si no existe
        }

        static void reemplazardeposito(int pos, int nuevodep, int[] deposito)
        {
            deposito[pos] = nuevodep;
            Console.WriteLine($"Nuevo arreglo: ");
            for (int i = 0; i < deposito.Length; i++)
                Console.Write(deposito[i] + ",");
        }


        static int Reeemplazardeposito2(int[] deposito)
        {
            int pos2;
            Console.WriteLine("\nDigitar una posición (de 0 a 9)");
            pos2 = int.Parse(Console.ReadLine());
            if (pos2 >= 0 && pos2 <= 9)
            {
                Console.WriteLine("Digitar un nuevo depósito");
                deposito[pos2] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Deposito en la posición {pos2} seleccionada: ${deposito[pos2]}");
                Console.WriteLine($"Nuevo arreglo: ");
                for (int i = 0; i < deposito.Length; i++)
                    Console.Write(deposito[i] + ",");
            }
            else
                Console.WriteLine("¡ERROR! : Digitar una posición válida");
            return pos2;
        }


        static void intercambiardepositos(int pos1, int pos2, int[] deposito)
        {
            int s = 0;
            s = deposito[pos1];
            deposito[pos1] = deposito[pos2];
            deposito[pos2] = s;
            Console.WriteLine($"\nNuevo intercambio: ");
            for (int i = 0; i < deposito.Length; i++)
                Console.Write(deposito[i] + ",");


        }

        static void generaraleatorio(int[] deposito)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < deposito.Length; i++)
            {
                deposito[i] = aleatorio.Next(2000, 10000);
                Console.Write(deposito [i] + ", ");
            }

        }
    }
}
