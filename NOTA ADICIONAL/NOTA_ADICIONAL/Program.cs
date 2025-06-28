using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTA_ADICIONAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Registro reg = new Registro();


            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("¡Bievenidos al sistema de registro de productos!");
                    Console.WriteLine("\n*********************MENÚ***********************");
                    Console.WriteLine("\n1. Registrar producto");
                    Console.WriteLine("2. Mostrar productos ");
                    Console.WriteLine("3. Modificar producto");
                    Console.WriteLine("4. Salir del sistema ");
                    Console.WriteLine("\n************************************************");

                    Console.Write("\nSeleccionar una opción: ");
                    string entrada = Console.ReadLine();
                    if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 4)
                    {
                        Console.Write("\nEntrada inválida. Presione una tecla para intentarlo nuevamente...");
                        Console.ReadKey();
                    }
                }while (opcion < 1 || opcion > 4);

                switch (opcion)
                {
                    case 1:
                        reg.registrar();
                        break;
                    case 2: 
                        reg.mostrar();
                        break;
                    case 3:
                        reg.modificar();
                            break;
                        
                    case 4: Console.WriteLine("\n¡SALIENDO DEL SISTEMA....!"); return;
                }
                
                if (opcion != 4)
                {
                    Console.Write("\nPresione una tecla para regresar al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 4);
        }
    }
}
