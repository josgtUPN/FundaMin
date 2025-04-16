using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana4_3
    {
        static void Main(string[] args)
        {
            int elementos;
            double promedio=0;
            double suma=0;
            double num;
            Console.Write("INGRESE NUMERO DE ELEMENTOS: ");
            elementos = int.Parse(Console.ReadLine());
            for(int i=1; i <= elementos; i++)
            {

                Console.Write("INGRESE NUMERO " + i + ": ");
                num = double.Parse(Console.ReadLine());
                suma = suma + num;
                promedio = suma / elementos;
            }
        }
    }
}
