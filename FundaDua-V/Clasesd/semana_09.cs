using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_sem9;

namespace Clases
{
    internal class semana_09
    {
        static void Main(string[] args)
        {
            //Declarar Variables 
            int Cantidad = 0;
            double Precio = 0.00;
            double TVta;
            double Descuento;
            double TVtaCDscto;
            //Ingresar datos 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("\t Venta de Productos con Funciones");
            Console.WriteLine("\t ********************************");
            //Llamar a la función Ingreso 
            cventas.ingreso(ref Cantidad, ref Precio);
            //Calcular Venta sin Dscto. LLamar a la funcion
            TVta = cventas.FTSinDscto(Cantidad, Precio);
            cventas.MensajeRpta("total venta: ", TVta);
            Descuento = cventas.FTDscto(TVta);
            cventas.MensajeRpta("Total Dscto.:", Descuento);
            //Calcular Venta con Dscto. 
            TVtaCDscto = cventas.FTCDscto(TVta, Descuento);
            cventas.MensajeRpta("Total Venta con Dscto.:", TVtaCDscto);
            Console.ReadKey();

        }
    }
}
