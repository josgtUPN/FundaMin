using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicas
{
    internal class semana3_ejercicio3
    {
        static void Main(string[] args)
        {
            double ingresocomprador, preciocasa, cuotainicial, cuotas, preciototal;
            Console.WriteLine("_______ Bienes y Raices _______");
            Console.WriteLine("Ingrese precio de la casa: ");
            preciocasa = double.Parse(Console.ReadLine());
            if (preciocasa > 0)
            {
                Console.WriteLine("ingrese el ingreso mensual del comprador: ");
                ingresocomprador = double.Parse(Console.ReadLine());

                if (ingresocomprador < 2250)
                {
                    cuotainicial = preciocasa * 15 / 100;
                    cuotas = (preciocasa - cuotainicial) / 120;
                    preciototal = cuotainicial + cuotas * 120;
                    Console.WriteLine("El monto de la cuota inicial es: " + cuotainicial);
                    Console.WriteLine("El monto de la cuota mensual es: " + cuotas);
                    Console.WriteLine("El monto precio total de la casa es: " + preciototal);
                }
                else if (ingresocomprador >= 2250)
                {
                    cuotainicial = preciocasa * 30 / 100;
                    cuotas = (preciocasa - cuotainicial) / 75;
                    preciototal = cuotainicial + cuotas * 75;
                    Console.WriteLine("El monto de la cuota inicial es: " + cuotainicial);
                    Console.WriteLine("El monto de la cuota mensual es: " + cuotas);
                    Console.WriteLine("El monto precio total de la casa es: " + preciototal);
                }
                else
                {
                    Console.WriteLine("ERROR, Su ingreso mensual debe ser mayor igual a 0.");
                }
            }
            else
            {
                Console.WriteLine("ERROR, ingrese un precio mayor a 0.");
            }
            Console.ReadKey();
        }
    }
}

