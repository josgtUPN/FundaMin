using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana2
    {
        static void Main(string[] args)
        {
            string nombre;
            double T1, T2, T3, FINAL, PROMEDIO;
            Console.WriteLine("calcula tu nota del semestre");
            Console.Write("INGRESA TU NOMBRE:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu nota del T1: ");
            T1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tu nota del T2: ");
            T2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tu nota del T3: ");
            T3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa tu nota del FINAL: ");
            FINAL = Double.Parse(Console.ReadLine());
            PROMEDIO = T1 * 0.1 + T2 * 0.1 + T3 * 0.1 + FINAL * 0.4;
            Console.WriteLine("-----------------");

            if (PROMEDIO >= 12 && PROMEDIO <= 17)
            {
                Console.WriteLine(nombre + "ah aprobado el semestre con: " + PROMEDIO);
            }
            else if (PROMEDIO <= 11)
            {
                Console.WriteLine(nombre + "ah desaprobado el semestre con: " + PROMEDIO);
            }
            else if (PROMEDIO < 0 || PROMEDIO > 20)
            {
                Console.WriteLine(nombre + "error! intentalo de nuevo");
            }
            else
            {
                Console.WriteLine(nombre + " haz aprobado el curso con " + PROMEDIO + ", tienes excelencia academica ");
            }
            Console.ReadKey();
        }
    }
}
