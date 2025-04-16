using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana4_6
    {
        static void Main(string[] args)
        {
            int elementos;
            int negativos = 0;
            int positivos = 0;
            double sumaposi = 0;
            double sumanega = 0;
            double promedioposi = 0;
            double promedionega = 0;
            int c_m7 = 0;
            int c_m5 = 0;
            double s_m7 = 0;
            double s_m5 = 0;
            double promedio_m7 = 0;
            double promedio_m5 = 0;
            double suma = 0;
            double promedio = 0;
            double num = 0;
            Console.Write("INGRESE NUMERO DE ELEMENTOS: ");
            elementos = Convert.ToInt32(Console.ReadLine());
            for ( int i=1; i<= elementos; i++)
            {
                Console.Write("ingrese numero " + i + ": ");
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    positivos++;
                    sumaposi += num;
                }
                if (num > 0)
                {
                    negativos++;
                    sumanega += num;
                }
                if (num%7 == 0)
                {
                    c_m7++;
                    s_m7 += num;
                }
                if (num % 5 == 0)
                {
                    c_m5++;
                    s_m5 += num;
                }
                //positivos += (num > 0) ? 1 : 0;
                //negativos += (num < 0) ? num : 0;
                //suma += num;
            }
            promedio = suma / elementos;
            promedioposi = sumaposi / positivos;
            promedionega = sumanega / negativos;
            promedio_m7 = s_m7 / c_m7;
            promedio_m5 = s_m5 / c_m5;
            Console.WriteLine("cantidad de positivos: " + positivos);
            Console.WriteLine("cantidad de negativos: " + negativos);
            Console.WriteLine("suma de positivos: " + sumaposi);
            Console.WriteLine("suma de negativos: " + sumanega);
            Console.WriteLine("promedio de positivos: " + promedioposi);
            Console.WriteLine("promedio de negativos: " + promedionega);
            Console.WriteLine("suma multiplo de 7: " + s_m7);
            Console.WriteLine("suma multiplo de 5: " + s_m5);
            Console.WriteLine("promedio multiplo de 7: " + promedio_m7);
            Console.WriteLine("promedio multiplo de 5: " + promedio_m5);
            Console.WriteLine("promedio total: " + promedio);
            Console.ReadKey();
        }
    }
}
