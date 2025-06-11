using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK12;

namespace ConsoleApp1
{
    internal class semana12_1
    {
        static void Main(string[] args)
        {
            int elem;
            int[] numeros;
            do
            {
                Console.Write("ingrese numero de elementos: ");
            }
            while (!int.TryParse(Console.ReadLine(), out elem));
            numeros = new int[elem];
            Class1.arreglo(ref numeros);
            Class1.mostrar(numeros);
            numeros = Class1.ordenar(numeros);
            Class1.mostrar(numeros);
            Console.ReadKey();
                


        }
    }
}
