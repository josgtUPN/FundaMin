using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana2_ejercicio_2
    {
        static void Main(string[] args)
        {
            string nombre;
            int horas;
            double pago;
            Console.Write("ingrese nombre del trabajdor");
            nombre = Console.ReadLine();
            Console.Write("ingrese horas trabajadas");
            horas = int.Parse(Console.ReadLine());
            if (horas <= 40)
            {
                pago = horas * 16000;
            }
            else
            {
                pago = (horas - 40) * 20000 + 40 * 16000;
            }
            Console.WriteLine(nombre + " recibira el importe de " + pago.ToString("c"));
            Console.ReadKey();
        }
    }
}
