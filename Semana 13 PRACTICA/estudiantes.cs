using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_PRACTICA
{
    class estudiantes
    {
        private string[] nombres = new string[0];
        private byte[] edad = new byte[0];
        private int cantidad = 0;
        public void insertar()
        {
            string continuar;

            do
            {

                Console.Clear();

                Console.WriteLine("=== R E G I S T R A R  E S T U D I A N T E S ===");

                Array.Resize(ref nombres, nombres.Length + 1);
                Array.Resize(ref edad, nombres.Length + 1);

                Console.WriteLine("* Ingrese sus nombres");
                nombres[cantidad] = Console.ReadLine();
                Console.WriteLine("* Ingrese su edad");
                edad[cantidad] = byte.Parse(Console.ReadLine());
                cantidad++;


                Console.WriteLine("Se registró con exito! ¿Desea seguir registrando (S): ?");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");


        }


        public void mostrar()
        {
            Console.Clear();
            Console.WriteLine("=== E S T U D I A N T E S   R E G I S T R A D O S ===");
            if (cantidad != 0)
            {
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {nombres[i]}\t{edad[i]}");
                }

            }
            else
                Console.WriteLine("No hay usuarios registrados");

        }

        public int buscar(string nom)
        {
            int indice = -1;
            for (int i=0; i < nombres.Length; i++)
            {
                if (nombres[i] == nom)
                {
                    indice = i;
                }
            }
            return indice;
        }
        public void modificar()
        {
            Console.Clear();

            Console.WriteLine("== SELECCIONAR ESTUDIANTES ===");
            Console.Write("Ingrese el nombre");
            string ingreso = Console.ReadLine();
            int indice = buscar(ingreso);
            if (indice != -1)
            {
                Console.Write("\nIngrese el nuevo nombre");
                nombres[indice] = Console.ReadLine();
                Console.Write("Ingrese la nueva edad: ");
                edad[indice] = byte.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\nNo se puede modificar. No existe el estudiante ");
            }





        }
    }


}


