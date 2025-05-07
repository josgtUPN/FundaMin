using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana7_1
    {
        static void Main(string [] args)
        {
            //*Hacer un programa que Muestre cuantos "lunes" Hay entre las fechas 19 de
            //Setiembre del 2004 y el 25 de diciembre del mismo año 
                
            DateTime fecha;
            int con = 0;
            do
            {
                Console.WriteLine("ingrese fecha a evaluar: ");

            }
            while (!DateTime.TryParse(Console.ReadLine(), out fecha)); 
            while (fecha <= DateTime.Now) ;
            Console.ReadKey();
            
        }
    }
}
