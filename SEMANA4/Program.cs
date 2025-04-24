using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace SEMANA4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ejercicio14();
            Console.ReadKey();

        }


        static void ejercicio1()
        {

            int num1;
            Console.WriteLine("Ingresa un numero");
            num1 = int.Parse(Console.ReadLine());

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
            edad = int.Parse(Console.ReadLine());

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
                if (angulo > 180 && angulo < 360)
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

        static void Ejercicio5()
        {
            // Dado el tipo de chocolate y la cantidad de unidades adquiridas,
            // diseñe un programa que determine el importe de la compra, el importe
            // del descuento, el importe a pagar y la cantidad de caramelos de obsequio.


            double tipochocolate, preciounitario = 0, cantichocolate, descuento, importebruto, importedescuento, importefinal, regalo = 0;

            Console.WriteLine("Seleccione un tipo de chocolate por el número: Primor (1), Dulzura (2), Tentación (3), Explosión (4)");
            tipochocolate = double.Parse(Console.ReadLine());
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

            if (importefinal >= 250)
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

        static void Ejercicio6()
        {
            // Algoritmo que retorne temperatura alta, si el ingreso es mayor o igual a 37

            double temp;

            Console.WriteLine("Digitar temperatura");
            temp = double.Parse(Console.ReadLine());

            if (temp >= 37)
            {
                Console.WriteLine("TEMPERATURA ALTA; RETORNANDO!!!!!!.....");
            }
            else
            {
                Console.WriteLine("Temperatura normal carajo");
            }
            Console.WriteLine("Gracias por usar el medidor de temperatura, presione cualquier tecla para salir");
            Console.ReadKey();
        }

        static void ejercicio7()
        {
            double ruta, calidad, descuento, importe, cantidad, importedescuento;

            Console.WriteLine("Seleccionar ruta");
            Console.WriteLine("Rutas disponibles: Lima a Huanuco (1) - Lima a Huancayo (2)");
            ruta = double.Parse(Console.ReadLine());



            switch (ruta)
            {
                case 1:
                    Console.WriteLine("Seleccionar calidad");
                    Console.WriteLine("Calidad A (1) - Calidad B (2) - Calidad (3)");
                    calidad = double.Parse(Console.ReadLine());

                    if (calidad == 1)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());
                        if (cantidad > 4)
                        {
                            importe = cantidad * 45;
                            descuento = importe * 0.05;
                            importedescuento = importe - descuento;
                            Console.WriteLine($"El importe de la compra es S/. {importe}, el importe del descuento es S/. {descuento} y el importe a pagar es {importedescuento}");
                            Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                            Console.ReadKey();
                        }
                        else
                        {
                            importe = cantidad * 45;
                            Console.WriteLine($"El importe a pagar es: " + importe);
                            Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                            Console.ReadKey();
                        }
                    }

                    if (calidad == 2)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());

                        importe = cantidad * 35;
                        Console.WriteLine($"El importe a pagar es: " + importe);
                        Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                        Console.ReadKey();

                    }

                    if (calidad == 3)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());

                        importe = cantidad * 30;
                        Console.WriteLine($"El importe a pagar es: " + importe);
                        Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                        Console.ReadKey();

                    }

                    break;

                case 2:

                    Console.WriteLine("Seleccionar calidad");
                    Console.WriteLine("Calidad A (1) - Calidad B (2) - Calidad (3)");
                    calidad = double.Parse(Console.ReadLine());

                    if (calidad == 1)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());
                        if (cantidad > 4)
                        {
                            importe = cantidad * 38;
                            descuento = importe * 0.05;
                            importedescuento = importe - descuento;
                            Console.WriteLine($"El importe de la compra es S/. {importe}, el importe del descuento es S/. {descuento} y el importe a pagar es {importedescuento}");
                            Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                            Console.ReadKey();
                        }
                        else
                        {
                            importe = cantidad * 38;
                            Console.WriteLine($"El importe a pagar es: " + importe);
                            Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                            Console.ReadKey();
                        }
                    }

                    if (calidad == 2)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());

                        importe = cantidad * 33;
                        Console.WriteLine($"El importe a pagar es: " + importe);
                        Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                        Console.ReadKey();

                    }

                    if (calidad == 3)
                    {
                        Console.WriteLine("Digitar cantidad de boletos");
                        cantidad = double.Parse(Console.ReadLine());

                        importe = cantidad * 28;
                        Console.WriteLine($"El importe a pagar es: " + importe);
                        Console.WriteLine("Gracias por su compra. Presione cualquier tecla para salir");
                        Console.ReadKey();

                    }

                    break;
                default:
                    Console.WriteLine("Número inválido, reiniciar el sistema");
                    break;



            }








        }

        static void ejercicio8()
        {
            // Algoritmo que determine la condición de un alumno, si
            // su nota es mayor o igual a 13 "aprobado", caso contrario "desaprobado"

            double nota;

            Console.WriteLine("Digitar Nota");
            nota = double.Parse(Console.ReadLine());
            if (nota >= 0 && nota <= 20)
                if (nota >= 13)
                {
                    Console.WriteLine("Nota aprobatoria");
                }
                else
                {
                    Console.WriteLine("Nota desaprobatoria");
                }

        }

        static void ejercicio9()
        {
            double n1, n2, n3;
            Console.WriteLine("Digitar tres números");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El primer número es mayor");
            }
            else
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("El segundo número es mayor");
            }
            else
            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("El tercer número es mayor");
            }

        }

        static void ejercicio10()
        {
            double sueldo, comisión, ventas, sueldofinal;
            Console.WriteLine("Ingresar ventas");
            ventas = double.Parse(Console.ReadLine());
            sueldo = 930;
            comisión = ventas * 0.10;
            sueldofinal = comisión + sueldo;
            Console.WriteLine($"El sueldo de un vendedor es S/. {sueldo}, la comisión de sus ventas es S/. {comisión} y su sueldo neto calculado es: {sueldofinal}");

        }

        static void ejercicio11()
        {
            Console.Write("Ingrese sueldo base: ");
            double sueldo = double.Parse(Console.ReadLine());
            double maria = (sueldo * 0.95) - 25;
            double juan = (sueldo * 1.23) + 72;
            double patricio = (sueldo * 1.85) - 56;
            Console.WriteLine();
            Console.WriteLine($"El sueldo de maría: {maria:F2}");
            Console.WriteLine($"El sueldo de juan: {juan:F2}");
            Console.WriteLine($"El sueldo de patricio: {patricio:F2}");
            Console.WriteLine($"Suma de sueldos es: {maria + juan + patricio:F2}");

        }
        static void ejercicio12()
        {

            Console.WriteLine("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());
            Console.ReadLine();

            if (año % 4 == 0 && año % 100 != 0 | (año % 400 == 0))
            {
                Console.WriteLine("Es un año bisiesto");
            }
            Console.WriteLine("No es un año bisiesto");
        }

        // Desarrolla un programa usando switch que permita al usuario ingresar un
        // monto en soles peruanos(PEN) y seleccionar a qué moneda desea convertir
        // 1: Dólares(USD) - 1 USD = 3.75 PEN
        // Opción 2: Euros(EUR) - 1 EUR = 4.05 PEN

        static void ejercicio13()
        {
            double monto, moneda;
            Console.WriteLine("Ingrese un monto en soles peruanos");
            monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una opción: Dolares (1) - Euros (2)");
            moneda = double.Parse(Console.ReadLine());

            switch (moneda)
            {
                case 1:

                    Console.WriteLine($"USD: {(monto / 3.75):F2}");

                    break;

                case 2:

                    Console.WriteLine($"EUR: {(monto / 4.05):F2}");

                    break;
                default: Console.WriteLine("Opción inválida, por favor, seleccione una de las opciones, gracias...");
                    break;

            }

        }

        static void ejercicio14()
        {
            Console.WriteLine("Bienvenido al cálculo de áreas");
            Console.WriteLine("\n1. Cuadrado \n2. Rectángulo\n3. Triángulo\n4. Círculo");
            Console.WriteLine("\nIngrese una opción");
            int opción = int.Parse(Console.ReadLine());


            switch (opción)
            {
                case 1:




                    break;
                case 2:



                    break;
                case 3:



                    break;
                case 4:


                    break;
            }

        }


    }
}