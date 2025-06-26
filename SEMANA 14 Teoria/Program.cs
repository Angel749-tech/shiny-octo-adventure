using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_14_Teoria
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombres = "Carlos Carbajal";
            // Obtenemos la longitud de la cadena
            int longitud = nombres.Length;
            Console.WriteLine($"Longitud: {longitud}");


            // Busca la posición a partir de "C"
            int pos = nombres.IndexOf("C");
            Console.WriteLine($"Posición: {pos}");



            // Busca la posición del índice a partir de una posición (1)
            int pos2 = nombres.IndexOf("C",1);
            Console.WriteLine($"Posición: {pos2}");



            // Convierte la cadena en mayúscula
            String nombresMayus = nombres.ToUpper();
            Console.WriteLine($"Nombre en mayúscula: {nombresMayus}");



            // Convierte la cadena en minúscula
            String nombresMinus = nombres.ToLower();
            Console.WriteLine($"Nombre en minúscula: {nombresMinus}");



            // Extrae una desde la posición (7)
            String nombre1 = nombres.Substring(7);
            Console.WriteLine($"Nombres: {nombre1}");


            // Extrae una cadena desde (0) hasta la posición (6)
            String nombre2 = nombres.Substring(0, 6);
            Console.WriteLine($"Nombres: {nombre2}");

            // Extraemos 1 carácter especificando su posición
            Console.WriteLine($"Caracter: {nombres[5]}");

            // Obtenemos la última posición del carácter buscado
            int ultimapos = nombres.LastIndexOf(" ");
            Console.WriteLine($"Ultima posición carácter: {ultimapos}");


            // De la cadena siguiente, mostrar las primeras letras de cada término...

            String estudiante2 = "Ana Naomi Arles Lexi";
            String letra1, letra2, letra3, letra4;

            letra1 = estudiante2[0].ToString();
            letra2 = estudiante2[estudiante2.IndexOf(" ") + 1].ToString(); 
            letra3 = estudiante2[estudiante2.IndexOf(" ", estudiante2.IndexOf(" ") + 1) + 1].ToString();
            letra4 = estudiante2[estudiante2.LastIndexOf(" ")+1].ToString();


            Console.WriteLine($"\nResultado segunda forma (adecuada con funciones): {letra1} {letra2} {letra3} {letra4}");
        }
    }
}
