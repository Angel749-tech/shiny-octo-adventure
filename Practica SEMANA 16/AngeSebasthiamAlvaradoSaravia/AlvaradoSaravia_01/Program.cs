using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlvaradoSaravia_01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            byte marca;
            int cantidad;
            double precio = 0;
            int i = 0;
            double descuento = 0, importef = 0, cantidadmouse = 0;

            do
            {
                Console.WriteLine("Ingrese la marca de computadora a comprar: 1. Dell 2. HP 3. Apple 4. Asus 5. SALIR DEL PROGRAMA");
                marca = byte.Parse(Console.ReadLine());
                if (marca == 5)
                {
                    Console.WriteLine("Cerrando programa...");
                    return;
                }
                Console.WriteLine("Ingrese la cantidad a comprar");
                cantidad = int.Parse(Console.ReadLine());

                precio=importe_alvaradoSaravia(marca, cantidad);
                descuento = descuento_alvaradoSaravia(precio, cantidad);
                importef = importefinal_alvaradoSaravia(descuento, precio);
                cantidadmouse = mouse_alvaradoSaravia(marca, cantidad);
                
                i++;
                imprimir_alvaradoSaravia(i, precio, descuento, importef, cantidadmouse);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("");
            }
            while (marca != 5);

        }

        static void imprimir_alvaradoSaravia(int i, double precio, double descuento, double importef, double cantidadmouse)
        {
            Console.WriteLine($"\nComputadora {i}#:");
            Console.WriteLine($"Importe: S/. {precio}");
            Console.WriteLine($"Descuento: S/. {descuento}");
            Console.WriteLine($"Importe final : S/. {importef}");
            Console.WriteLine($"Cantidad de mouses de regalo: {cantidadmouse}");
        }
        
        static double mouse_alvaradoSaravia(int marca, int cantidad)
        {
            double mousepad = 0, cantidad_mouse = 0;
            if (marca == 2)
            {
                if (cantidad >= 3)
                {
                    mousepad = cantidad / 3;
                    cantidad_mouse = mousepad * 3;
                }
            }
            return cantidad_mouse;
        }

        static double importe_alvaradoSaravia(byte marca, int cantidad)
        {
            double precio = 0;
            switch (marca)
            {
                case 1:
                    precio = cantidad * 11000; break;
                case 2:
                    precio = cantidad * 9000; break;

                case 3:
                    precio = cantidad * 13000; break;
                case 4:
                    precio = cantidad * 12500; break;

            }
            return precio;
        }
        
        static double descuento_alvaradoSaravia(double precio, int cantidad)
        {
            double descuento = 0;
            if (cantidad > 0 && cantidad <= 3)
                descuento = 1.0 * precio * 0.035;
            else
    if (cantidad < 6)
                descuento = 1.0 * precio * 0.05;
            else
    if (cantidad < 9)
                descuento = 1.0 * precio * 0.065;
            else
                descuento = 1.0 * precio * 0.08;

            return descuento;
        }

        static double importefinal_alvaradoSaravia(double descuento, double precio)
        {
          double importe_final = 0;
            importe_final = 1.0 * precio - descuento;
            return importe_final;
        }
    }
}
