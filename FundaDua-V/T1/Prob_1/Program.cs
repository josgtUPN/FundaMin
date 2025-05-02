using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //una mepresa quiere evaluar 3 importantes salarios y se desea calcular:
            //a. Suma de los tres salarios 
            //b.Promedio de los tres salarios
            //c.Porcentaje de cada salario con respecto a la suma.
            //d.La media ponderada(MP) asignándole un peso(Pi) a cada salario:
            //    MP = (P1 x Salario1 +P2 x Salario2 +P3 x Salario3) / (P1 + P2 + P3)
            //e.La media geométrica(MG):
            //    MG = (Salario1 x Salario2 x Salario3) (1/3) 
            //fLa media armónica (MA): 
            //    MA = (∑Salarios) / (1 / Salario1 + 1 / Salario2 + 1 / Salario3)
            double salario1, salario2, salario3, suma;
            double Promedio, ponderado, geometrica, armonica;
            double porcen1, porcen2, porcen3;
            int p1, p2, p3;

            Console.WriteLine("====== Empresa A.P.C.I ======");
            Console.WriteLine("Ingresa los salario en soles");
            Console.WriteLine("Ingresar el primer salario: ");
            salario1 = double.Parse(Console.ReadLine());
            //--------------------------------------------------------------------------------------------------
            while (salario1 < 0)
            {
                Console.WriteLine("ERROR. El monto debe ser mayor o igual a cero.");
                Console.WriteLine("vuelva a ingresar el primer salario:");
                salario1 = double.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------
            Console.Write("Ingresar el segundo salario: ");
            salario2 = double.Parse(Console.ReadLine());
            while (salario2 < 0)
            {
                Console.WriteLine("ERROR. El monto debe ser mayor o igual a cero.");
                Console.WriteLine("vuelva a ingresar el segundo salario: ");
                salario2 = double.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------
            Console.Write("Ingresar el tercer salario: ");
            salario3 = double.Parse(Console.ReadLine());
            while (salario3 < 0)
            {
                Console.WriteLine("ERROR. El monto debe ser mayor o igual a cero.");
                Console.WriteLine("Vuelva a ingrese nuevamente el tercer salario: ");
                salario3 = double.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------






            Console.WriteLine("ingrese el peso del primer salario:");
            p1 = int.Parse(Console.ReadLine());
            while (p1 < 0) //validamos si el valor ingresado si es negativo sale error y vuelve a preguntar por el peso
            {
                Console.WriteLine("ERROR.el monto debe ser mayor a cero");
                Console.WriteLine("ingrese nuevamente el primer peso");
                p1 = int.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("ingrese el peso del segundo salario:");
            p2 = int.Parse(Console.ReadLine());
            while (p2 < 0) //validamos si el valor ingresado si es negativo sale error y vuelve a preguntar por el peso
            {
                Console.Write("ERROR.el monto debe ser mayor a cero");
                Console.WriteLine("ingrese nuevamente el segundo peso");
                p2 = int.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("ingrese el peso del tercer salario:");
            p3 = int.Parse(Console.ReadLine());
            while (p3 < 0) //validamos si el valor ingresado si es negativo sale error y vuelve a preguntar por el peso
            {
                Console.Write("ERROR.el monto debe ser mayor a cero");
                Console.WriteLine("ingrese nuevamente el tercer peso");
                p3 = int.Parse(Console.ReadLine());
            }
            //--------------------------------------------------------------------------------------------------
            //operamos suma de salarios
            suma = salario1 + salario2 + salario3;
            //operamos el promedio de salarios
            Promedio = suma / 3;
            //operamos los porcentajes de cada salario
            porcen1 = salario1 / suma * 100;
            porcen2 = salario2 / suma * 100;
            porcen3 = salario3 / suma * 100;
            //operamos la media ponderada
            ponderado = (salario1 * p1 + salario2 * p2 + salario3 * p3) / (p1 + p2 + p3);
            //operamos la media geometrica
            geometrica = Math.Pow((salario1 * salario2 * salario3), (1.0 / 3));
            //operamos la medai armonica
            armonica = 3 / (1 / salario1 + 1 / salario2 + 1 / salario3);
            //hacemos que vote cada resultado
            Console.WriteLine("la suma de los tres salarios es       : s/." + suma);
            Console.WriteLine("el promedio de los tres salarios es   : s/." + Promedio);
            Console.WriteLine("el porcentaje del primer salario es   : " + porcen1 + "%");
            Console.WriteLine("el porcentaje del segundo salario es  : " + porcen2 + "%");
            Console.WriteLine("el porcentaje del tercer salario es   : " + porcen3 + "%");
            Console.WriteLine("la media ponderada de los salarios es : s/." + ponderado);
            Console.WriteLine("la media geometrica de los salarios es: s/." + geometrica);
            Console.WriteLine("la media armonica de los salarios es  : s/." + armonica);
            Console.ReadKey();

        }
    }
}
