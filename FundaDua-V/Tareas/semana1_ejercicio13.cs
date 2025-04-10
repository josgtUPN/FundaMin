using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class semana1_ejercicio13
    {
        static void Main(string[] args)
        {
            //La empresa de Transportes CIVA S.A. ha registrado el viaje de pasajeros para 5 días considerando las
            //siguientes cifras: 640, 684, 863, 876,753. Se pide mediante un algoritmo y programa ingresar los datos y
            //calcular su promedio, Varianza y Desviación Estándar.(promedio=763.2|varianza=8847.76|desviacion estandar=94.06)
            //definimos las variables
            double dia1, dia2, dia3, dia4, dia5;
            double x1, x2, x3, x4, x5;
            double promedio_de_pasajeros, varianza, desviacion_estandar;
            Console.WriteLine("==promedio-varianza-desviación_estandar==");
            Console.Write("numero de pasajeros dia 1:");
            dia1 = double.Parse(Console.ReadLine());
            Console.Write("numero de pasajeros dia 2:");
            dia2 = double.Parse(Console.ReadLine());
            Console.Write("numero de pasajeros dia 3:");
            dia3 = double.Parse(Console.ReadLine());
            Console.Write("numero de pasajeros dia 4:");
            dia4 = double.Parse(Console.ReadLine());
            Console.Write("numero de pasajeros dia 5:");
            dia5 = double.Parse(Console.ReadLine());
            //sacamos el promedio de la cantidad de pasajeros
            promedio_de_pasajeros = (dia1 + dia2 + dia3 + dia4 + dia5) / 5;
            Console.WriteLine("el promedio de pasajeros en los 5 dias es: " + promedio_de_pasajeros);

            x1 = Math.Pow((dia1 - promedio_de_pasajeros), 2);
            x2 = Math.Pow((dia2 - promedio_de_pasajeros), 2);
            x3 = Math.Pow((dia3 - promedio_de_pasajeros), 2);
            x4 = Math.Pow((dia4 - promedio_de_pasajeros), 2);
            x5 = Math.Pow((dia5 - promedio_de_pasajeros), 2);
            //la varianza es la resta de cada dia menos el promed
            varianza = (x1 + x2 + x3 + x4 + x5) / 5;
            desviacion_estandar = Math.Sqrt((x1 + x2 + x3 + x4 + x5) / 5);
            Console.WriteLine("la varianza es: " + varianza);
            Console.WriteLine("la desviacion estandar es: " + desviacion_estandar);
            Console.ReadKey();
        }
    }
}
