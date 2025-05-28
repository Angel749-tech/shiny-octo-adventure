using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_9._3_EJERCICIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String marca;
            int mCantidad;
            double importe, importebruto, descuento, mouseCantidad;

            Console.WriteLine("A partir de las siguientes marcas de computadora: ");
            Console.WriteLine("\n* Dell");
            Console.WriteLine("\n* Hp");
            Console.WriteLine("\n* Apple");
            Console.WriteLine("\n* Asus");


            Console.WriteLine($"Marca seleccionada: {marca = Console.ReadLine()}");
            Console.WriteLine("Ingrese cantidad");
            mCantidad = int.Parse(Console.ReadLine());


            importe = importee(marca, mCantidad);
            descuento = importedescuento(mCantidad, importe);
            importebruto = importepago(importe, descuento);
            mouseCantidad = regalo(marca, mCantidad);

            Console.WriteLine("Importe: S/. " + importe);
            Console.WriteLine("Descuento: S/. " + descuento);
            //Llamamos a las funciones
            Console.WriteLine("Importe bruto: S/. " + importebruto);
            Console.WriteLine("MousePads de Regalo: " + mouseCantidad);

        }


        // Función que calcule el importe de la compra
        // Si una variable se ingresa por el teclado, entonces, se declara como parámetro (regla)
        static double importee(string marca, int mCantidad)
        {
            double precio = 0;
            switch (marca)
            {
                case "Dell":
                    precio = 11000;
                    break;

                case "Hp":
                    precio = 9000;
                    break;
                case "Apple":
                    precio = 13000;
                    break;
                case "Asus":
                    precio = 12500;
                    break;

            }
            return mCantidad * precio;
        }

        // Función descuento
        // Si una variable se calculó en una función anterior, entonces, se debe clarar como parámetro
        static double importedescuento(int mCantidad, double iCom)
        {
            double descuento;
            if (mCantidad <= 3)
                descuento = 3.5 / 100 * iCom;
            else if (mCantidad < 6)
                descuento = 5.0 / 100 * iCom;
            else if (mCantidad < 9)
                descuento = 6.5 / 100 * iCom;
            else
                descuento = 8.0 / 100 * iCom;
            return descuento;
        }

        static double importepago(double impCom, double descuento)
        {

            return impCom - descuento;
        }

        static double regalo(string marca, int mCantidad)
        {
            double obs;
            if (marca == "Hp")
                obs = (mCantidad / 3) * 3;
            else
                obs = 0;
            return obs;
        }
    }
}
