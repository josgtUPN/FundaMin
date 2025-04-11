using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class semana2_ejercicio5
    {
        static void Main(string[] args)
        {
            //5.Una fábrica de camisetas produce N camisetas con un
            //costo de mano de obra total de $1.3N y costo total
            //por material de $0.4N. Los gastos generales constantes
            //para la planta son de $6500. Si cada camiseta
            //se vende en $3.50. ¿Cuántas camisetas deben venderse para
            //que la compañía obtenga utilidades? Se tiene
            //la siguiente simulación:
            //
            //  Mediante un algoritmo y programa se pide calcular: 
            //
            //    •	Costo Total de Mano de Obra obtenido de multiplicar las Unidades por el Costo de Mano de Obra. 
            //    •	El Costo Fijo que es el costo total de la planta y es constante para todas las unidades producidas, así suban o bajen. 
            //    •	El Costo Total que es la suma del Costo Total de Obra y el Costo Fijo. 
            //    •	Los Ingresos que se obtienen de multiplicar el Precio de la Camiseta por las Unidades.
            //    •	Las Utilidades que se obtienen de la diferencia entre los Ingresos y el Costo Total.
            //    •	Para la Calificación, si las Utilidades es Cero la calificación es Punto de Equilibrio, Mayor a cero Ganancia y menor a cero es Pérdida. 
            

            //definimos las variables
            double costomanoobra, preciocamiseta, costofijoplanta, costototalmanoobra, costototal, ingresos, utilidades;
            int unidades;

            //ingresamos los datos
            Console.WriteLine("========= Fabrica de Camisetas =========");
            Console.WriteLine("ingrese el costo de mano de obra: ");
            costomanoobra = double.Parse(Console.ReadLine());

            //filtramos los datos erroneos
            if (costomanoobra >= 0)
            {
                Console.WriteLine("ingrese precio de las camisetas: ");
                preciocamiseta = double.Parse(Console.ReadLine());
                if (preciocamiseta >= 0)
                {
                    Console.WriteLine("ingrese el costo fijo: ");
                    costofijoplanta = double.Parse(Console.ReadLine());
                    if (costofijoplanta >= 0)
                    {
                        Console.WriteLine("ingrese cantidad de camisetas: ");
                        unidades = int.Parse(Console.ReadLine());
                        if (unidades >= 0)
                        {
                            //calculamos los datos
                            costototalmanoobra = costomanoobra * unidades;
                            costototal = costototalmanoobra + costofijoplanta;
                            ingresos = preciocamiseta * unidades;
                            utilidades = ingresos - costototal;
                            
                            Console.WriteLine("Con " + unidades + " unidades tendrias un costo total de mano de obra de $" + costototalmanoobra + ",");
                            Console.WriteLine("un costo fijo de $" + costofijoplanta + ", un costo total de $" + costototal + ", ingresos de $" + ingresos);
                            Console.WriteLine("y una utilidad de $" + utilidades + ". Por ende los resultados son:");

                            //con el if averiguaremos si se tiene ganancia o no
                            if (utilidades == 0)
                            {
                                Console.WriteLine("=No Hay Ganancia ni Perdida.");
                            }
                            else if (utilidades > 0)
                            {
                                Console.WriteLine("=Hay ganancia.");
                            }
                            else
                            {
                                Console.WriteLine("=Hay perdida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ingrese nuevamente un monto mayor o igual a 0.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ingrese nuevamnete un monto mayor o igual a 0.");
                    }
                }
                else
                {
                    Console.WriteLine("ingrese nuevamente un monto mayor o igual a 0.");
                }
            }
            else 
            {
                Console.WriteLine("ingrese nuevamente un monto mayor o igual a 0.");
            }
            Console.ReadKey();
        }
    }
}
