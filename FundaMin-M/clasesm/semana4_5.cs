using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana4_5
    {
        static void Main(string[] args)
        {
            string pares = "";
            string impares = "";
            for (int i=1; i<=1000; i++)
            {
                if (i%2 == 0)
                {
                    pares += i + "\n";

                }
                else
                {
                    impares += i + "\n";
                }
                //pares += (i % 2 == 0) ? i.tostring() : "";
                //impares += (i % 2 != 0) ? i.tostring() : "";
            }
        }
    }
}
