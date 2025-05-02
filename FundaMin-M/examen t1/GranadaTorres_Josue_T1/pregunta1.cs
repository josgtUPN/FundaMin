using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranadaTorres_Josue_T1
{
    internal class pregunta1
    {
        static void Main(string[] args)
        {
            double ingreso_comprador;
            double cuota_mensual=0;
            int departamento;
            int años;
            double cuota_inicial = 0;
            Console.WriteLine("Ingrese el ingreso mensual del comprador: ");
            ingreso_comprador = double.Parse(Console.ReadLine());
            if (ingreso_comprador >= 2999)
            {
                Console.WriteLine("Ingrese precio del departamento que desea comprar: ");
                departamento = int.Parse(Console.ReadLine());

                if (departamento >= 0 )
                {
                    Console.WriteLine("Ingrese la cantidad de años en que desea pagar el departamento no mayo a 20 años : ");
                    años = int.Parse(Console.ReadLine());
                    if (años > 0 && años <= 20)
                    {

                        if (ingreso_comprador < 3000)
                        {
                            Console.WriteLine("fuente de ingresos bajos");
                        }
                        else if (ingreso_comprador >= 3000 && ingreso_comprador < 5000)
                        {
                            cuota_inicial = departamento * 0.2;
                            cuota_mensual = (departamento - cuota_inicial) / años;
                        }
                        else if (ingreso_comprador >= 5000 && ingreso_comprador < 8000)
                        {
                            cuota_inicial = departamento * 0.15;
                            cuota_mensual = (departamento - cuota_inicial) / años;

                        }
                        else 
                        {
                            cuota_inicial = departamento * 0.1;
                            cuota_mensual = (departamento - cuota_inicial) / años;
                        }
                        Console.WriteLine("El ingreso mensual del comprador es: " + ingreso_comprador);
                        Console.WriteLine("El precio del departamento es: " + departamento);
                        Console.WriteLine("El monto de la cuota inicial es: " + cuota_inicial);
                        Console.WriteLine("El monto de la cuota mensual es: " + cuota_mensual);

                    }
                    else
                    {
                        Console.WriteLine("vuelva a ingresar la cantidad de años mayor a 0 y menor igual a 20");
                    }
                }
                else
                {
                    Console.WriteLine("vuelva a ingresar el precio del departamento mayor a 0");
                }
            }
            else
            {
                Console.WriteLine("debe ingresar un monto mayor a 2999 ");
            }
            Console.ReadKey();


        }
    }
}
