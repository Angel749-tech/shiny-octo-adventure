using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta01_AngelAlvarado
{
    internal class Program
    {
        static int oro = 0, plata = 0, bronce = 0, mh = 0, deportista1 = 0, deportista2 = 0, deportista3 = 0, deportista4 = 0;
        static int x1, puntaje;
        static void Main(string[] args)
        {
            int tipo = 0;
            int cantidad = 0;
            int pa = 0; 
            string rec;
            do
            {

                Console.WriteLine("\n* Tipo de medella: 1.Oro 2.Plata 3.Bronce 4.Mención honrosa 5. SALIR DEL PROGRAMA ");
                tipo = int.Parse(Console.ReadLine());

                if (tipo != 5)
                {
                    Console.WriteLine("\n* Cantidad: ");
                    cantidad = int.Parse(Console.ReadLine());
                }

                pa = puntajeacumulado_alvaradoSaravia(tipo, cantidad);
                rec = reconocimiento_alvaradosaravia(pa);

                acumuladorycontador_alvaradosaravia(cantidad, tipo);
                imprimeresultados_alvaradoSaravia(pa, rec);
                

            }
            while (tipo != 5);

            Console.WriteLine($"Total medellas oro: {oro} y total de deportistas: {deportista1}");
            Console.WriteLine($"Total medellas plata: {plata} y total de deportistas: {deportista2}");
            Console.WriteLine($"Total medellas bronce: {bronce} y total de deportistas: {deportista3}");
            Console.WriteLine($"Total medellas plata: {mh} y total de deportistas: {deportista4}");
            Console.WriteLine("PUNTAJE TOTAL: " + x1);

        }

        static void acumuladorycontador_alvaradosaravia(int cantidad, int tipo)
        {

            switch (tipo)
            {
                case 1:
                    oro += cantidad;
                    deportista1++;
                    break;
                case 2:
                    plata += cantidad;
                    deportista2++;
                    break;
                case 3:
                    bronce += cantidad;
                    deportista3++;
                    break;
                case 4:
                    mh += cantidad;
                    deportista4++;
                    break;
            }
        }




        static void imprimeresultados_alvaradoSaravia(int pa, string rec)
        {

            Console.WriteLine("\n*** RESULTADOS ***");
            Console.WriteLine("\nEl puntaje acumulado según el tipo y cantidad: " + pa);
            Console.WriteLine("El reconcimiento obtenido por puntaje acumulado es: " + rec);


        }
        static int puntajeacumulado_alvaradoSaravia(int tipo, int cantidad)
        {
            int puntaje = 0;
            
            switch (tipo)
            {
                case 1:
                    puntaje = 10 * cantidad;
                    break;
                case 2:
                    puntaje = 6 * cantidad;
                    break;
                case 3:
                    puntaje = 3 * cantidad;
                    break;
                case 4:
                    puntaje = 1 * cantidad;
                    break;
                case 5:
                    Console.WriteLine("Cerrando programa...");
                    break;

            }
            x1 += puntaje;
            return puntaje;
        }

        static string reconocimiento_alvaradosaravia(int puntaje)
        {
            string reconocimiento;

            if (puntaje >= 0 && puntaje < 7)
                reconocimiento = "Diploma";
            else if (puntaje < 14)
                reconocimiento = "Cena doble";
            else if (puntaje < 31)
                reconocimiento = "Pasaje Turístico Doble";
            else
                reconocimiento = "Pasaje turístico integral";

            return reconocimiento;
        }
    }
}
