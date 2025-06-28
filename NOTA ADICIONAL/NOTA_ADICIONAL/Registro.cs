using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTA_ADICIONAL
{
    internal class Registro
    {
        private string[] productos = new string[0];
        private int[] precio = new int[0];
        private int[] stock = new int[0];
        private int cantidad = 0;
        public void registrar()
        {
            string continuar;
            do
            {
                Console.Clear();
                Console.WriteLine("***** REGISTRAR PRODUCTO ***** ");
                Array.Resize(ref productos, productos.Length + 1);
                Array.Resize(ref precio, precio.Length + 1);
                Array.Resize(ref stock, stock.Length + 1);

                Console.WriteLine("1. Ingrese producto: ");
                productos[cantidad] = Console.ReadLine();
                Console.WriteLine("2. Ingrese precio: ");
                precio[cantidad] = int.Parse(Console.ReadLine());
                Console.WriteLine("3. Ingrese stock: ");
                stock[cantidad] = int.Parse(Console.ReadLine());
                cantidad++;

                Console.WriteLine("*** Registro de producto satisfactorio... ¿Desea continuar? --> (s)");
                continuar = Console.ReadLine();

            } while (continuar == "s" || continuar == "S");
        }

        public void mostrar()
        {
            Console.Clear();
            Console.WriteLine("***** MOSTRAR PRODUCTO ***** ");

            if (cantidad != 0)
            {
                for (int i = 0; i < productos.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. Nombre del producto: {productos[i]} / Precio: S/. {precio[i]} / Stock: {stock[i]} u.");
                }
            }
            else
                Console.WriteLine("ERROR: ¡No hay productos registrados!");
        }

        public void modificar()
        {


            Console.Clear();
            Console.WriteLine("***** MODIFICAR PRODUCTO ***** ");
            Console.Write("- Ingrese el producto a modificar: ");
            string ingreso = Console.ReadLine();

            int indice = -1;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] == ingreso)
                {
                    indice = i;
                }
            }

            if (indice != -1)
            {
                Console.Write("\n1. Ingrese otro nombre para el producto: ");
                productos[indice] = Console.ReadLine();
                Console.Write("\n2. Ingrese otro precio: ");
                precio[indice] = int.Parse(Console.ReadLine());
                Console.Write("\n3. Ingrese otro stock: ");
                stock[indice] = int.Parse(Console.ReadLine());
            }
            else
                Console.WriteLine("ERROR: ¡No existe el producto!");
        }


    }
}
