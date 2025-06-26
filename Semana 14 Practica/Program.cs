using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_14_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese sus apellidos");
            string ape = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese sus nombres: ");
            string nom = Console.ReadLine().Trim();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Apellidos: " + ape);
            Console.WriteLine("Nombres: " + nom);

            Console.WriteLine("Cantidad de caractéres de apellidos: " + ape.Length);
            Console.WriteLine("Nombres mayúsculas: " + nom.ToUpper());
            Console.WriteLine("Apellidos minúsculas: " + ape.ToLower());

            Console.ForegroundColor = ConsoleColor.Blue;


            if (ape.CompareTo(nom) == 0)
                Console.WriteLine("APELLIDOS Y NOMBRES IGUALES");
            else
                Console.WriteLine("APELLIDOS Y NOMBRES DIFERENTES");

            if (nom.Contains("an"))
                Console.WriteLine("El nombre contiene \"an\" ");
            else
                Console.WriteLine("El nombre No contiene \"an\"");

            // Mostrar su primera posición del texto “a” en apellidos. Si no contiene mostrar mensaje no contiene la palabra “a”
            if (ape.Contains("a"))
                Console.WriteLine("Posición de \"a\" en apellidos: " + ape.IndexOf("a"));
            else
                Console.WriteLine("El apellido No contiene \"a\"");
            // Mostrar su última posición del texto “a” en apellidos. Si no contiene mostrar mensaje no contiene la palabra “a”.
            if (ape.Contains("a"))
                Console.WriteLine("Posición de \"a\" en apellidos: " + ape.LastIndexOf("a"));
            else
                Console.WriteLine("El apellido No contiene \"a\"");

            // Inserte la palabra “upn” al inicio de los nombres.
            Console.WriteLine("Insertar UPN en nombres: " + nom.Insert(0, "UPN "));
            // Inserte la palabra “Sistemas” al final de los apellidos.
            Console.WriteLine("Insertar Sistemas al final de apellidos: " + ape.Insert(ape.Length, " Sistemas"));
            // Eliminar los caracteres de los apellidos a partir de la 5ta posición, si no hay 5 o más caracteres mostrar mensaje “no contiene 5 caracteres o más”
            if (ape.Length > 5)
            {
                Console.WriteLine("Eliminamos a partir de la 5ta posición: " + ape.Remove(5));
            }
            else
                Console.WriteLine("No contiene más de cinco carácteres");

            // 
            Console.ResetColor();

            if (nom.Contains("a"))
            {
                String[] splitt = nom.Split('a');

                for (int i = 0; i < splitt.Length; i++)
                    Console.WriteLine(splitt[i]);
            }
            else
                Console.WriteLine("El nombre No contiene \"a\"");
            //

            if (ape.Length > 4)
            {
                Console.WriteLine(nom.Substring(4));
            }
            else
                Console.WriteLine("No tiene mas de 4 caracteres");
            // 

            char[] nombres = nom.ToCharArray();

            for (int i = 0; i < nom.Length; i++)
            {
                Console.WriteLine(nom[i]);
            }

            //
            Console.WriteLine("Nombre en reversa"); Array.Reverse(nombres);

            //


            Console.WriteLine("Nombres ordenados: "); Array.Sort(nombres);


            Console.ReadKey();
        }
    }
}
