using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_14_Teoría2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cad = "Lenguaje Programación Java C#";
            // Método split() --> Convierte una cadena String a Arreglo, debe exustur un separado de palabras que se indica como parámetro (' ')
            String[] arreglo = cad.Split(' ');
            Console.WriteLine("Palabra 1: " + arreglo[0]);
            Console.WriteLine("Palabra 2: " + arreglo[1]);
            Console.WriteLine("Palabra 3: " + arreglo[2]);
            Console.WriteLine("Palabra 4: " + arreglo[3]);
            Console.WriteLine(cad);
            Console.WriteLine($"Longitud: {arreglo.Length}");
            Console.WriteLine("Primera Letra: " + cad[0]);
            Console.WriteLine("Última Letra: " + cad[cad.Length - 1]);
            Console.WriteLine("PosPrimerEspacio: " + cad.IndexOf(" "));
            Console.WriteLine("Primera Palabra: " + arreglo[0]);
            Console.WriteLine("Última palabra: " + arreglo[3]);
            Console.WriteLine("MAYUSCULAS: " + cad.ToUpper());
            Console.WriteLine("MINÚSCULAS: " + cad.ToLower());

            //Elabore una función que reciba una cadena y retorne la cantidad de vocales/consonante de la cadena
            //Elabore una función que reciba una cadena y calcule la cantidad de vocales/consonante/digitos/símbolos especiales de la cadena

            int cona = 0, cone = 0, coni = 0, cono = 0, conu = 0, conespacio = 0, consonantes = 0, totalvocales = 0,simbolo=0;
            for (int i = 0; i <cad.Length; i++)
            {
                if (cad[i] == 'a' || cad[i] == 'á' || cad[i] == 'A')
                    cona++;
                if (cad[i] == 'e' || cad[i] == 'é' || cad[i] == 'E')
                    cone++;
                if (cad[i] == 'i' || cad[i] == 'í' || cad[i] == 'I')
                    coni++;
                if (cad[i] == 'o' || cad[i] == 'ó' || cad[i] == 'O')
                    cono++;
                if (cad[i] == 'u' || cad[i] == 'ú' || cad[i] == 'U')
                    conu++;
                if (cad[i] == ' ')
                    conespacio++;

            }
            totalvocales = cona + cone + coni + cono + conu;
            consonantes = cad.Length - (conespacio + cona + cone + coni + cono + conu);
            Console.WriteLine("Total de caracteres: " +cad.Length);
            Console.WriteLine("A: " + cona);
            Console.WriteLine("E: " + cone);
            Console.WriteLine("I: " + coni);
            Console.WriteLine("O: " + cono);
            Console.WriteLine("U: " + conu);
            Console.WriteLine("Símbolos: " +simbolo);
            Console.WriteLine("Total vocales: " + totalvocales);
            Console.WriteLine("Espacios en blanco: " + conespacio);
            Console.WriteLine("Consonantes: " + consonantes);






        }
    }
}
