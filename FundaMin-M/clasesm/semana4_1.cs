using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana4_1
    {
        static void Main(string[] args)
        {
            ulong num = 0;
            Console.Write("Ingrese numero: ");
            num = ulong.Parse(Console.ReadLine());
            for (ulong i = 1; i <= num; i++)
            {
                Console.WriteLine("esto es un numero: " + i );
            }
            


        }
    }
}

