using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana4_2
    {
        static void Main(string[] args)
        {
            int num;
        
            Console.Write("ingrese numero a evaluar: ");
            num = int.Parse(Console.ReadLine());
            for(int i=1; i<=12; i++)
            {
                Console.WriteLine(i + "x" + num + "="  );
                //Console.WriteLine(i + "x" + num + "=" + num * i);

            }
            Console.ReadLine();
        }
    }
}
