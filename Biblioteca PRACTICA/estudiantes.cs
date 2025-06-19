using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_PRACTICA
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

                Console.WriteLine("Se registró con exito! ¿Desea seguir registrando (S): ?");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

        
        }
    }
}
