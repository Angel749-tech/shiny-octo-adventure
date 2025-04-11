using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ejercicio1();
            Console.ReadKey();

        }

        static void ejercicio1()
        {
            string nombre;
            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Bienvenidos al mundo de la programación: " + nombre);
            Console.ReadKey();

        }
        static void ejercicio2()
        {

            Console.WriteLine("Mi nombre es Sebas"); Console.WriteLine("Tengo 19 años"); Console.WriteLine("Estudio ingeniería de sistemas");
            Console.ReadKey();


        }

        static void ejercicio3()
        {

            Console.WriteLine("\"Sebas\"");

        }

        static void ejercicio4()
        {

            // Declaración de Variables
            double a, b, suma, resta, multiplicacion, division, residuo;
            Console.WriteLine("Hola escribe el primer número: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ahora escribe el segundo número: ");
            b = double.Parse(Console.ReadLine());

            // Proceso

            suma = a + b;
            resta = a - b;
            multiplicacion = a * b;
            division = 1.0 * a / b;
            residuo = a % b;


            // Salida

            Console.WriteLine($"El resultado de la suma es: {suma} ");
            Console.WriteLine("El resultado de la resta es: " + resta);
            Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);
            Console.WriteLine("El resultado de la división es: " + division);
            Console.WriteLine("El residuo de la división previa es: " + residuo);
            Console.WriteLine("Gracias por usar la calculadora (.)|(.)");
            Console.ReadKey();

        }

        static void ejercicio5()
        {

            // Declaración de Variables
            double a, b, ar;
            Console.WriteLine("Digita la base del triángulo: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digita la altura del triángulo: ");
            b = double.Parse(Console.ReadLine());

            // Operaciones

            ar = (b * a) / 2;

            // Salida

            Console.WriteLine("El área del triangulo es:" + ar);

        }

        static void ejercicio6()
        {

            double d1, d2, d3, pro;
            Console.WriteLine("Escribe a continuación tres numeros decimales");
            d1 = double.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
            d3 = double.Parse(Console.ReadLine());

            pro = (d1 + d2 + d3) / 3;

            // El comando .ToString("Fx") no cambia el numero, en cambio, Math.Round(x) cambia el numero
            Console.WriteLine("El promedio es: " + pro.ToString("F2"));
            Console.WriteLine("El promedio es: " + Math.Round(pro, 2));

        }

        static void ejercicio7()
        {

            double a;

            Console.WriteLine("Digita un número decimal");
            a = double.Parse(Console.ReadLine());

            // Comando Math.Sqrt(x) para sacar raiz cuadrada y Math.Pow(x<--numero,x2<---potencia)
            Console.WriteLine("La raíz cuadrada es: " + Math.Sqrt(a));
            Console.WriteLine("La potencia a 3 es: " + Math.Pow(a, 3));

        }

        static void ejercicio8()
        {

            double radio, area;

            Console.WriteLine("Digita el radio del círculo");
            radio = double.Parse(Console.ReadLine());

            area = ((3.14) * (radio * radio));

            Console.WriteLine("El área del círculo es: " + area);

        }

        static void ejercicio9()
        {

            int a, b;

            a = 10;
            b = 20;

            Console.WriteLine("Para los valores a=10 y b=20, entonces...");
            Console.WriteLine("A es igual a B: " + (a == b));
            Console.WriteLine("A es diferente de B: " + (a != b));
            Console.WriteLine("A es menor que B: " + (a > b));
            Console.WriteLine("A es mayor que B: " + (a < b));
            Console.WriteLine("A es mayor o igual que B: " + (a >= b));
            Console.WriteLine("A es menor o igual que B: " + (a <= b));

        }

        static void ejercicio10()
        {

            bool x, y;

            x = true;
            y = false;

            Console.WriteLine("Si X es falso y Y verdaderos entonces... ");
            Console.WriteLine("X AND Y: " + (x && y));
            Console.WriteLine("X OR Y: " + (x || y));
            Console.WriteLine("NOT X: " + (!x));
            Console.WriteLine("NOT Y: " + (!y));


        }
    }
}