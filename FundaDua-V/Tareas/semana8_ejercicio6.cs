using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    class semana8_ejercicio6
    {
        public static void Main()
        {

            Console.Write("ingresa tu nombre: ");
            string nombre = Console.ReadLine();
            Console.Clear();
            Console.Write("hola {0} ingresa tus horas laboradas: ", nombre);
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora {0} ingresa a que categoria pertenecer (A)(B)(C)(D): ",nombre);
            string categoria = Console.ReadLine().ToUpper();
            double tarifa = 0;
            if (categoria == "A")
            {
                tarifa = 21;
            }
            else if (categoria == "B")
            {
                tarifa = 19.50;
            }
            else if (categoria == "C")
            {
                tarifa = 17;
            }
            else if (categoria == "D")
            {
                tarifa = 15.5;
            }
            else
            {
                Console.WriteLine("categoria no valida");
            }
            (double sueldo_bruto, double sueldo_neto, double descuento) = operar(tarifa, categoria, horas);

            Console.Clear();
            Console.WriteLine("hola {0} ", nombre);
            Console.WriteLine("tu sueldo bruto es: {0}", sueldo_bruto);
            Console.WriteLine("el descuento es: {0}", descuento);
            Console.WriteLine("tu sueldo neto es: {0}", sueldo_neto);
            Console.ReadKey();
        }
        public static (double,double,double) operar(double tarifa, string categoria, int horas)
        {
            double descuento = 0;
            double sueldo_neto = 0;
            double sueldo_bruto = tarifa * horas;
            if (sueldo_bruto > 2500)
            {
                descuento = sueldo_bruto * 20 / 100;
                sueldo_neto = sueldo_bruto - descuento;
            }
            else if(sueldo_bruto <0)
            {
                Console.WriteLine("sueldo no valido");
            }
            else
            {
                descuento = sueldo_bruto * 15 / 100;
                sueldo_neto = sueldo_bruto - descuento;
            }
            return (sueldo_bruto, sueldo_neto, descuento);
        }
    }
}
