using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_semana11;


namespace ConsoleApp1
{
    internal class semana11_1
    {
        static void Main(string[] args)
        {

            double[] sueldos = new double[5];
            sueldos = class2.Llenar_sueldos(5);
            Console.WriteLine("los 5 sueldos de los operarios");
            class2.mostrar_sueldos(sueldos);
            Console.ReadKey();

        }
    }
}

