using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaradoSaravia_02
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Dados el tipo de habitación
            // y el número de días de alojamiento de un cliente,
            // diseñe una función que calcule y retorne el importe de compra.

            double tipodehabitacion, diasalojamiento, importedecompra=0;

            Console.WriteLine("Seleccione un tipo de habitación: \n");
            Console.WriteLine("1. Simple");
            Console.WriteLine("2. Matrimonial: ");
            Console.WriteLine("3. Doble ");
            Console.WriteLine("4. Triple: \n");

            tipodehabitacion = double.Parse(Console.ReadLine());

            if (tipodehabitacion <= 0 & tipodehabitacion <= 0)
            {
                Console.WriteLine("Digitar un número válido por favor");
                return;
            }

            Console.WriteLine("Digitar cantidad de días de alojamiento: \n");
            diasalojamiento = double.Parse(Console.ReadLine());

            if (diasalojamiento <= 0 & tipodehabitacion <= 0)
            {
                Console.WriteLine("Digitar un número válido por favor");
            }
            else 
            {
                importedecompra = importe(tipodehabitacion, diasalojamiento);
                Console.WriteLine($"El importe a pagar es de: {+importedecompra} soles");
            } 

        }

        static double importe (double tipodehabitacion, double diasalojamiento)
        {
            double precio = 0;
            switch (tipodehabitacion)
            {
                
                case '1':

                    precio = 80;
                    break;
                case '2':
                    precio = 160;

                    break;
                case '3':

                    precio = 200;
                    break;
                case '4':

                    precio = 240;
                    break;

            }
            return precio * diasalojamiento;
        } 

    }
}
