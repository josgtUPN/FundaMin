using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class semana7_6ejercicio
    {
        static void Main(string[] args)
        {
            /*  En un condominio de 20 casas, se desea saber el pago mensual por consumo de agua, basado en el siguiente
                reporte:
                Consideraciones a tomar en cuenta para los cálculos:
                • Metros cúbicos es la diferencia entre la lectura actual y la lectura anterior.
                • El Importe de agua se considera según el tarifario del reporte, es decir para los primeros 20 metros
                  cúbicos se cobra la tarifa de 1.499 soles, para los siguientes 30 metros cúbicos, la tarifa de 2.128
                  soles y los restantes, es decir más de 50, la tarifa de 5.438 soles.
                • El Importe de Alcantarillado se considera según el tarifario del reporte, es decir para los primeros
                  20 metros cúbicos se cobra la tarifa de 0.935 soles, para los siguientes 30 metros cúbicos, la tarifa
                  de 1.309 soles y los restantes, es decir más de 50, la tarifa de 2.592 soles.
                • Para el Cargo Fijo se considera 5.04 soles por 25 metros cúbicos de consumo de agua.
                • El IGV es el 18% de la suma de Importe de Agua, Importe de Alcantarillado y Cargo Fijo.
                • Total Pago es la suma de Importe de Agua, Importe de Alcantarillado, Cargo Fijo e IGV.
                • Además, hallar los totales según el reporte indicado
            */
            
            int lectura_anterior, lectura_actual, metros_cubicos=0;
            int house= 0;


            do
            {
                house++;
                
                Console.Clear();

                do
                {
                    Console.Write("\tIngrese la lectura anterior de la casa " + house + " : ");
                    lectura_anterior = int.Parse(Console.ReadLine());
                    Console.Write("\tIngrese la lectura actual de la casa " + house + " : ");
                    lectura_actual = int.Parse(Console.ReadLine());

                    metros_cubicos = lectura_actual - lectura_anterior;
                    
                    metros_cubicos += metros_cubicos;


                } while (house < 1 && house >= 19);
            } while (house < 21);
            Console.WriteLine(" " + metros_cubicos);


            Console.ReadKey();
        }
    }
}
