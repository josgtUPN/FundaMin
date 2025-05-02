using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranadaTorres_Josue_T1
{
    internal class pregunta2
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            DateTime Nacimiento;

            Console.WriteLine("ingrese tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese tu fecha de nacimiento (formato: años-mes-dia):");
            Nacimiento = DateTime.Parse(Console.ReadLine());

            edad = DateTime.Now.Year - Nacimiento.Year;

            Console.WriteLine("hola " + nombre + " y tu edad es de " + edad + " años");
            switch (edad)
            {
                case 0:
                case 1:
                    Console.WriteLine("Tu eres un bebé");
                    break;
                case int n when (n >= 2 && n <= 15):
                    Console.WriteLine("tu eres un niño");
                    break;
                case int n when (n >= 16 && n <= 21):
                    Console.WriteLine("tu eres un joven");
                    break;
                default:
                    Console.WriteLine("tu eres un adulto");
                    break;
            }
            Console.ReadKey();

        }
    }
}
