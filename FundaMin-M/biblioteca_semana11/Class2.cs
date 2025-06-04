using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_semana11
{

    
    public static class class2
    {
        public static double[] Llenar_sueldos(int elementos)
        {
            double[] sueldos = new double[elementos];
            for (int i = 0; i < elementos; i++)
            {
                do
                {
                    Console.Write("ingrese el sueldo del operario " + (i + 1) + ": ");
                }
                while (!double.TryParse(Console.ReadLine(), out sueldos[i]));
            }
            return sueldos;
        }
        public static double[] mostrar_sueldos(double[] sueldos)
        {
            string cadena = "";
            for (int i = 0;i < sueldos.Length;i++)
            {
                cadena += "[" + sueldos[i] + "]";
            }
            Console.WriteLine(cadena);
            return sueldos;
        }
        public static void Llennar_arreglo(ref double[] sueldos)
        {
            for (int i = 0; ; i < sueldos.Length; i++)
            {
                do
                {
                    Console.Write("INGRESE SUELDOS" + (i + 1) + ": ");

                }
                while (!double.TryParse(Console.ReadLine(), out sueldos[i]));
            }
           
        }
        public static double suma_arreglo(double[] sueldos)
        {
            double suma = 0;
            for (int i = 0; i < sueldos.Length; i++)
            {
                suma += sueldos[i];
            }
            return suma;
        }
    }
    
}
