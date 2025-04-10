using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom;
            DateTime fecha;
            int eda;

            Console.WriteLine("ingrese nombre: ");
            nom = Console.ReadLine();
            Console.WriteLine("ingrese fecha de nacimineto: ");
            fecha = DateTime.Parse(Console.ReadLine());
            eda = DateTime.Now.Year - fecha.Year;


            switch (eda)
            {
                case 0:
                Console.WriteLine("es un bebé");
                break;
                case 1:
                Console.WriteLine("es un bebe");
                break;
                case 2:
                Console.WriteLine("es un bebe");
                break;
                case 3: case 4: case 5: case 6: case 7: case 8:
                Console.WriteLine(nom + " es niño");
                break;
                case int n when (n >= 9 && n <= 12):
                Console.WriteLine(nom + " es puber");
                    break;
                case int n when (n >= 12 && n <= 18):
                Console.WriteLine(nom + " es adolescente");
                    break;
                case int n when (n >= 18 && n <= 25):
                Console.WriteLine(nom + " es joven");
                    break;
                case int n when (n >= 25 && n <= 60):
                Console.WriteLine(nom + " es adulto");
                    break;
                case int n when (n >= 60):
                Console.WriteLine(nom + " es joven");
                    break;
                default:
                    Console.WriteLine("fecha invalida");
                    break;
                
            }
            Console.ReadKey();

            
        }
    }
}
