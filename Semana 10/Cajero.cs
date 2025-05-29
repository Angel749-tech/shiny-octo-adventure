using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10
{
    class Cajero
    {
        private double saldo = 1000;

        public double consultar()
        {
            return saldo;
        }

        public void deposito(double monto)
        {
            do
            {
                Console.WriteLine("Ingrese el monto a depositar: ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out monto))
                {
                    if (monto > 0)
                    {
                        saldo += monto;
                        Console.WriteLine("Deposito Exitoso");
                        break;
                    }
                    else
                        Console.WriteLine("ERROR: Solo se pueden depositar números mayores a 0. ");
                }
                else
                {
                    Console.WriteLine("¡Error, solo se permiten números!");
                }

            } while (true);
        }

        public void retiro(double monto)
        {
            do
            {
                Console.WriteLine("Cuanto decea retirar");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out monto))
                {
                    if (monto > saldo)
                    {
                        Console.WriteLine("ERRROR404: El monto no puede ser mayor al saldo");

                    }
                    else if (monto < 0)
                        Console.WriteLine("ERROR: Solo se pueden retirar números mayores a 0...");
                    else
                    {
                        saldo -= monto;
                        Console.WriteLine("Retiro Exitoso, saldo actual: S/. " + saldo);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("¡Error, solo se permiten números!");
                }

            } while (true);
        }
    }
}
