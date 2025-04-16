using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana_1
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            int fecha=0;
            Console.WriteLine("bienvenido al curso de fundamentos de algoritmos");
            Console.Write("Ingrese nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.Write("ingrese la edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine(nombre + " tiene " + edad + " años ");
            Console.WriteLine("{0} tiene {1} años", nombre, edad);
            Console.Write("ingrese fecha de nacimeinto: ");
           
            //fecha = Convert.ToDateTime(Console.ReadLine());
            //edad = DateTime.Now.Year - fecha.Year;
            Console.WriteLine(nombre + " tiene " + edad + " años ");

            Console.ReadKey();
            //console.readline() solo enter;
        }
    }
}
