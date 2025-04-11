using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana2_ejercicio_1
    {
        static void Main(string[] args)
        {
            double monto_total, banco, fabricante, propio, interes;

            Console.Write("ingrese un monto total");
            monto_total = double.Parse(Console.ReadLine());
            if (monto_total < 500000)
            {
                propio = monto_total * 0.70;
                fabricante = monto_total * 0.30;

            }
            else
            {
                propio = monto_total * 0.55;
                banco = monto_total * 0.30;
                fabricante = monto_total * 0.15;
            }
            interes = fabricante * 0.2;
            Console.WriteLine("el importe a pagar por la empresa sera: ");
            Console.WriteLine("importe inversion                     : " + propio.ToString("c"));
            Console.WriteLine("importe banco                         : " + banco.ToString("c"));
            Console.WriteLine("importe fabricante                    : " + fabricante.ToString("c"));
            Console.WriteLine("importe interes                       : " + interes.ToString("c"));
            Console.WriteLine("importe total                         : " + (propio + fabricante + banco + interes).ToString("c"));
            Console.ReadKey();
        }
    }
}
