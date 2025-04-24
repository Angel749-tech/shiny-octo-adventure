using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SEMANA4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ejercicio4();
            Console.ReadKey();
          
        }


        static void ejercicio1()
        {

            int num1;
            Console.WriteLine("Ingresa un numero");
            num1= int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Es par");

            }
            else
            {
                Console.WriteLine("Es impar");
            }

        }

        static void ejercicio2()
        {
            int edad;
            Console.WriteLine("ingrese una edad");
            edad=int.Parse(Console.ReadLine());

           if (edad < 0)
            {
                Console.WriteLine("Edad invalida");

            }
           else if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");

            }
           else
            {
                Console.WriteLine("Es menor de edad");
            }
        }

        static void ejercicio3()
        {

            // Programar un algoritmo que determine la clasificación de un ángulo según el grado,  minutos y segundos

            double angulo, grados, minutos, segundos;


            Console.WriteLine("Digita los grados");
            grados = double.Parse(Console.ReadLine());
            if (grados < 0 || grados > 360)
            {
                Console.WriteLine("Grado inválido");
                return;
            }
            Console.WriteLine("Digita los minutos");
            minutos = double.Parse(Console.ReadLine());
            if (minutos < 0 || minutos > 59)
            {
                Console.WriteLine("Minuto inválido");
                return;
            }
            Console.WriteLine("Digita los segundos");
            segundos = double.Parse(Console.ReadLine());
            if (segundos < 0 || segundos > 59)
            {
                Console.WriteLine("Segundos inválido");
                return;
            }

            angulo = grados + (minutos / 60) + (segundos / 3600);

            if (angulo == 0)
            {
                Console.WriteLine("Angulo Nulo");
            }
            else
                    if (angulo < 90 && angulo > 0)
            {
                Console.WriteLine("Ángulo agudo");
            }
            else
                if (angulo == 90)
            {
                Console.WriteLine("Ángulo recto");
            }
            else
                if (angulo > 90 && angulo < 180)
            {
                Console.WriteLine("Angulo obtuso");
            }
            else 
                if (angulo == 180)
            {
                Console.WriteLine("Ángulo llano");
            }
            else 
                if (angulo > 180 && angulo<360)
            {
                Console.WriteLine("Ángulo cóncavo");
            }
            else 
                if (angulo == 360)
            {
                Console.WriteLine("Ángulo completo");
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static void Ejercicio4()
        {
            // Dado el tipo de chocolate y la cantidad de unidades adquiridas,
            // diseñe un programa que determine el importe de la compra, el importe
            // del descuento, el importe a pagar y la cantidad de caramelos de obsequio.


            double tipochocolate, preciounitario=0, cantichocolate, descuento, importebruto, importedescuento, importefinal, regalo=0;

            Console.WriteLine("Seleccione un tipo de chocolate por el número: Primor (1), Dulzura (2), Tentación (3), Explosión (4)");
            tipochocolate=double.Parse(Console.ReadLine());
            Console.WriteLine("Digitar la cantidad de chocolates");
            cantichocolate = double.Parse(Console.ReadLine());

            switch (tipochocolate)
            {
                case 1:
                    Console.WriteLine("Primor seleccionado");
                    preciounitario = 8.5;
                break;

                case 2:
                    Console.WriteLine("Dulzura seleccionado");
                    preciounitario = 10;
                    break;

                case 3:
                    Console.WriteLine("Tentación seleccionado");
                    preciounitario = 7;
                    break;

                case 4:
                    Console.WriteLine("Explosión seleccionado");
                    preciounitario = 12.5;
                    break;

                default:
                    Console.WriteLine("Tipo de chocolate inválido");
                break;
            }

            importebruto = preciounitario * cantichocolate;

            if (cantichocolate < 5)
            {
                descuento = 0.04;
            }
            else
                if (cantichocolate < 10 && cantichocolate >= 5)
            {
                descuento = 0.065;
            }
            else
                if (cantichocolate >= 10 && cantichocolate < 15)
            {
                descuento = 0.09;
            }
            else
            {
                descuento = 0.115;
            }

            importedescuento = descuento * importebruto;

            importefinal = importebruto - importedescuento;

            if (importefinal>=250)
            {
                regalo = cantichocolate * 3;
            }
            else
            {
                regalo = cantichocolate * 2;
            }

            Console.WriteLine("\nResumen de la compra:");
            Console.WriteLine($"El importe bruto es:" + importebruto);
            Console.WriteLine($"El descuento aplicado es de ({descuento * 100}%) --> S/. {descuento}");
            Console.WriteLine($"Importe Final: " + importefinal);
            Console.WriteLine($"Caramelos de Regalo: " + regalo);

            Console.WriteLine("Fin de la compra, ¡vuelva pronto =D !");
            Console.ReadKey();
        }

    }
}
