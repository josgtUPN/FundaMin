using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana14;

namespace ConsoleApp1
{
    internal class semana14_1
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("ingrese la cadena a convertir: ");
            cadena = Console.ReadLine();
            Class1.Mostrar_cadena_triangulo(cadena);
            Console.ReadKey();

        }
    }
}
