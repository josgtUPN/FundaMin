using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_semana11;

namespace ConsoleApp1
{
    internal class semana11_4
    {
        static void Main(string[] args)
        {
            int[] t1;
            int[] t2;
            int[] t3;
            int[] ef;
            double[] promedios;
            int elementos;
            do
            {
                Console.Write("Ingrese el numero de alumnos: ");
            } while (!int.TryParse(Console.ReadLine(), out elementos));
            t1 = new int[elementos];
            t2 = new int[elementos];
            t3 = new int[elementos];
            ef = new int[elementos];
            promedios = new double[elementos];
            Console.WriteLine("ingrse notas de la t1");
            class2.Llenar_Arreglo(ref t1);
            Console.WriteLine("ingrese notas de la t2");
            class2.Llenar_Arreglo(ref t2);
            Console.WriteLine("ingrese notas de la t3");
            class2.Llenar_Arreglo(ref t3);
            Console.WriteLine("ingrese notas de la ef");
            class2.Llenar_Arreglo(ref ef);
            promedios = class2.calcular_promedio(t1, t2, t3, ef);
            Console.WriteLine("Los promedios DE LOS ALUMNOS ES: " + (class2.suma_arreglo(promedios) / elementos));
            Console.ReadKey();
        }
    }
}
