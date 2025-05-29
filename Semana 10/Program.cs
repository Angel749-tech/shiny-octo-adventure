using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10
{
    class Program
    {
        double saldo = 1000;
        static void Main(string[] args)
        {
            char opcion, continuar;
            Cajero c = new Cajero();
            
            do
            {

                do
                {
                    Console.WriteLine("Bievenidos al sistemas de cajeros\n");
                    Console.WriteLine("1. Consultar saldo");
                    Console.WriteLine("2. Depositar saldo");
                    Console.WriteLine("3. Retirar saldo  ");
                    Console.WriteLine("4. Salir");

                    Console.Write("Ingrese una opción: \n");
                    opcion = Console.ReadKey().KeyChar;
                    Console.Clear();
                }
                while (opcion < '1' || opcion > '4');

                switch (opcion)
                {
                    case '1':
                        Console.WriteLine("Su saldo actual es: S/. " + c.consultar());

                        break;
                    case '2':

                        c.deposito(0);

                        break;
                    case '3':

                        c.retiro(0);

                        break;

                    case '4':

                        Console.WriteLine("¡Gracias por usar el programa!");
                        return;
                }

                do
                {

                    Console.WriteLine("\n¿Desea regresar al menú S/N: ?");
                    continuar = char.ToUpper(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    if (continuar != 'S' && continuar != 'N')
                    {
                        Console.WriteLine("¡Opción inválida! Ingrese solo S o N: ");
                    }

                }
                while (continuar != 'S' && continuar != 'N');
                Console.Clear();
            } while (continuar == 'S');

        }
    }
}
