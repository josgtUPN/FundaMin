using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranadaTorres_Josue_T1
{
    internal class pregunta3
    {
        static void Main(string[] args)
        {
            double consumo, costo_mensual = 0;
            double tarifa1 = 29.90;
            double tarifaA = 5.90;
            double gb_extra;
            double gbextraA;
            Console.WriteLine("ingrese tu consumo de internet en gigas:");
            consumo = double.Parse(Console.ReadLine());
            if (consumo <= 16)
            {
                costo_mensual = tarifa1;
            }
            else if (consumo > 16 && consumo <= 20)
            {
                gb_extra = consumo - 16;
                costo_mensual = tarifa1 + (gb_extra * tarifaA);
            }
            else
            {
                gbextraA = consumo - 20;
                gb_extra = consumo - 16;
                costo_mensual = tarifa1 + (5.9 * gb_extra ) + 4.5 *gbextraA;
            }

            Console.WriteLine("el costo mensual a pagar es: S/ " + costo_mensual.ToString("F2"));
            Console.ReadKey();
        }
    }
}
