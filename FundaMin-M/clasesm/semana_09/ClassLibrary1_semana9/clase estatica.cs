using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_semana9
{
    public static class clase_estatica
    {
        public static void soles_dolares(double importe, double tc, ref double convertido)
        {
            if (tc == 0)
            {
                convertido = 0;
            }
            else
            {
                convertido= importe/ tc;
            }
        }
        public static void dolares_soles(double importe, double tc, ref double convertido)
        {
            if (tc == 0)
            {
                convertido = 0;
            }
            else
            {
                convertido = importe * tc;
            }
        }
        public static void menu(ref string op)
        {
            Console.WriteLine("*************MENU*************");
            Console.WriteLine("1. comprar dolares");
            Console.WriteLine("2. vender dolares");
            Console.WriteLine("3. comprar euros");
            Console.WriteLine("4. vender euros");
            Console.WriteLine("5. salir");
            Console.Write("selecciones opcion: ");
            op = Console.ReadLine();
        }
    }
}
