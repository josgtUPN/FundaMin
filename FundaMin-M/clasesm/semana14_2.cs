using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana14;

namespace ConsoleApp1
{
    internal class semana14_2
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.WriteLine("*****menu*****");
                Console.WriteLine("1. agregar vehivulo");
                Console.WriteLine("2. modificar vehicculo");
                Console.WriteLine("3. eliminar vehiculo");
                Console.WriteLine("4. reporte");
                Console.WriteLine("5. Salir");
                op = Console.ReadLine();
                if (op == "1")
                    Class1.Registrar();
                else if (op == "2")
                    Class1.Modificar();
                else if (op == "3")
                    Class1.Eliminar();
                else if (op == "4")
                {
                    string op1 = " ";
                    string ord = " ";

                }
            } while (op != "0");
            
                
                    
        }
    }
}
