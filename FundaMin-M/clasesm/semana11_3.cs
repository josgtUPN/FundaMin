using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_semana11;

namespace ConsoleApp1
{
    internal class semana11_3
    {
        static void Main(string[] args)
        {
            int[] quimica = new int[5];
            int[] fisica = new int[5];
            Console.WriteLine("ingrese las notas de quimica");
            class2.Llenar_Arreglo(ref quimica);
            Console.WriteLine("ingrese las notas de fisica");
            class2.Llenar_Arreglo(ref fisica);
            Console.WriteLine("el curso de "+((class2.suma_arreglo(quimica) > class2.suma_arreglo(fisica)) ? "quimica" : "fisica") + " tiene mayor promedio");
            
            Console.ReadKey();

        }
    }
}
