using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class semana3_ejercicio2
    {
        static void Main(string[] args)
        {
            double velocidad;
            Console.WriteLine("_______ Empresa CBC S.A. _______");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la velocidad del diseño: ");
            velocidad = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------------");
            if (velocidad >= 7)
            {
                if (velocidad >= 7 && velocidad <= 10)
                {
                    Console.WriteLine("El tipo de particula es de humos metalurgicos.");
                }
                else if (velocidad > 10 && velocidad <= 13)
                {
                    Console.WriteLine("El tipo de particula es muy finas y de muy baja densidad aparente.");
                }
                else if (velocidad > 13 && velocidad <= 18)
                {
                    Console.WriteLine("El tipo de particula es fina y secas de materiales de baja densidad.");
                }
                else if (velocidad > 18 && velocidad <= 20)
                {
                    Console.WriteLine("El tipo de particula es de densidad media o baja, humedas.");
                }
                else if (velocidad > 20 && velocidad <= 23)
                {
                    Console.WriteLine("El tipo de particula son gruesas de alta densidad.");
                }
                else
                {
                    Console.WriteLine("El tipo de particula es de muy alta densidad o humedas.");
                }
            }
            else
            {
                Console.WriteLine("ERROR, ingrese una velocidad mayor igual a 7.");
            }
            Console.ReadKey();
        }
    }
}
