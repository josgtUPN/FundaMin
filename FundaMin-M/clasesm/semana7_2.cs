using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana7_2
    {
        static void Main(string[] args)
        {
            /*La empresa FishBox desea conocer qué tipos de empaques puede utilizar
            para enviar sus productos(conservas de pescado) al extranjero; sus
            presentaciones son las siguientes:
            a.Caja Jumbo de 100 unidades
            b.Caja Mid de 50 unidades
            c.Caja Tiny de 20 unidades
            d.Paquete mini de 10 unidade*/

            double jumbo, mid, tiny, mini, cantidad;

            do
            {
                do
                {
                    Console.Write("ingrese cantidad a solicitar:");

                }
                while (!double.TryParse(Console.ReadLine(), out cantidad));

            }
            while (cantidad < 15000 || cantidad > 50000);
            jumbo = Math.Floor(cantidad / 100.0);
            cantidad = cantidad % 100;
            mid = Math.Floor(cantidad / 50);
            cantidad = cantidad % 50;
            tiny = Math.Floor(cantidad / 20);
            cantidad = cantidad % 20;
            mini = Math.Floor(cantidad / 10);
            cantidad = cantidad % 10;

            if (cantidad >0)
            {
                mini++;
            }
            Console.WriteLine("de acuerdo a la canmtidad se enytregara: ");
            Console.WriteLine("cantidad de cajas de jumbo: "+ jumbo);
            Console.WriteLine("cantidad de cajas mid: "+ mid);
            Console.WriteLine("cantidad de cajas tiny: "+ tiny);
            Console.WriteLine("cantidad de cajas mini: "+ mini);
            Console.ReadKey();


          


        }
    }
}
