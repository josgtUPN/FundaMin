using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana5_1
    {
        static void Main(string[] args)
        {
            //ejemplo1
            int num;
            int cont = 0;
            do
            {
                Console.Write("ingrese numero: ");

            }
            while (!int.TryParse(Console.ReadLine(),out num));
            while (cont <= 12)
            {
                Console.WriteLine(cont + " X " + num + (cont * num));
              //Console.WriteLine(cont + " X " + num + " = "(cont * num));
                cont++;
               //ERROR NO ME SALE LO QUE PIDE SI PONGO 1 APARECE 10 #RARO
            }
            Console.ReadLine();
        }
    }
}
