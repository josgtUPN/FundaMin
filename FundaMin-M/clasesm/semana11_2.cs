using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_semana11;


namespace ConsoleApp1
{
    internal class semana11_2
    {
        
        
        static void Main(string[] args)
        {
            double[] mañana = new double[4];
            double[] tarde = new double[4];
            Console.WriteLine("sueldos de los empleados turno mañana.");
            class2.Llennar_arreglo(ref mañana);
            Console.WriteLine("sueldo empleados turno tarde.");
            class2.Llennar_arreglo(ref tarde);
            Console.WriteLine("total de gastos del turno mañana: "+class2.suma_arreglo(mañana));
            Console.WriteLine("total de gastos del turno tarde: " + class2.suma_arreglo(tarde));
            Console.ReadKey();
        }
        
    }
}
