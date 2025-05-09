using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class semana2_ejercicio_3
    {
        static void Main(string[] args)
        {
            double ingresocomprador, enganche, cuotacasa, costocasa;

            Console.WriteLine("bienes raices - compra tu casa");
            Console.WriteLine("******************************");
            Console.WriteLine("ingreso del comprador: ");

            ingresocomprador = double.Parse(Console.ReadLine());

            if (ingresocomprador > 0)
            {
                Console.WriteLine("el costo de la casa: ");
                costocasa = double.Parse(Console.ReadLine());

                if (costocasa > 0)
                {
                    if (ingresocomprador < 8000)
                    {
                        enganche = costocasa * 15 / 100;
                        cuotacasa = (costocasa - enganche) / 10 * 12;
                    }
                    else
                    {
                        enganche = costocasa * 30 / 100;
                        cuotacasa = costocasa - enganche / 10 * 12;
                    }
                    Console.WriteLine("enganche : " + enganche);
                    Console.WriteLine("cuota casa : " + cuotacasa);

                }
                else
                {
                    Console.WriteLine("el costo de la casa debe ser mayor a cero");
                }

            }
            else
            {
                Console.WriteLine("el ingreso del comprador debe ser mayor a cero");
            }
        }
    }
}
