using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Semana2
    {
        static void Main(string[] args)
        {
            double cuota, monto_prestamo;

            Console.WriteLine("captacion de clientes - finanzas");
            Console.WriteLine("********************************");
            Console.WriteLine("ingrese monto del prestamo:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //limpiar consola

            monto_prestamo = double.Parse(Console.ReadLine());

            if (monto_prestamo > 0)
            {
                if (monto_prestamo < 50000)
                {
                    cuota = monto_prestamo * 3 / 100;
                }
                else
                {
                    cuota = monto_prestamo * 2 / 100;
                }
                //salida 
                Console.WriteLine("MONTO DE LA CUOTA: " + cuota);
            }
            else
            {
                Console.WriteLine("error. ingrese prestamo mayor a cero");
            }
            Console.ReadKey();
        }
    }
}
