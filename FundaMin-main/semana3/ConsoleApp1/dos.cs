using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dos
    { static void Main(string[] args)
            {
            double n1, n2, n3;
            Console.WriteLine("ingrese el primer numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer numero: ");
            n3 = double.Parse(Console.ReadLine());

            if ((n1 > n2 && n1 < n3) || (n1 < n2 && n1 > n3))
            {
                Console.WriteLine("El numero del medio es: " + n1);

            }
            else if ((n2 < n1 && n2 < n3) || (n2 < n1 && n2 > n3))
            {
                Console.WriteLine("el numero del medio es: " + n2);
            }
            else
                Console.WriteLine("el numero del medio es: " + n3);
            Console.ReadKey();  
            }
    }
}
