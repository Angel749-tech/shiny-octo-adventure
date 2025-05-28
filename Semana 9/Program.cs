using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 3, exp = 2;
            double pot;

            pot = Math.Pow(b, exp);

            Console.Write("Potencia: " + pot);
        }
    }
}
