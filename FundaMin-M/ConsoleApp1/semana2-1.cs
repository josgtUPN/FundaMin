using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana2_1
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.Write("ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            //edad = convert.toInt32(console.readline());
            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad");

            }
            else
            {
                Console.WriteLine(nombre + " es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
