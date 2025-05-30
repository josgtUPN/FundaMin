using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_duarte
{
    public class cventas
    {

        
        //Crear el constructor 
        public cventas()
        {

        }
        //Declarar los prototipos de funciones 
        //Función para mostrar mensaje 
        static public void Mensaje(string Msje)
        {
            Console.Write(Msje);
        }
        //Funcion para Mostrar mensaje con respuesta 
        static public void MensajeRpta(string Msje, double Rpta)
        {
            Console.Write(Msje);
            Console.Write(Rpta);
            Console.Write("\n");
        }
        //funcion para calcular el total sin descuento
        static public double FTSinDscto(int cantidad, double precio)
        {
            //variable local
            double TotalsinDscto;
            //totañ sin descuento
            TotalsinDscto = cantidad * precio;
            return TotalsinDscto;

        }
        static public void ingreso(ref int cantidad, ref double precio)
        {
            Mensaje("ingrese cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            Mensaje("ingrese precio : ");
            precio = double.Parse(Console.ReadLine());
        }
        //funcion para calcular el total de descuento
        static public double FTDscto(double tventa)
        {
            double totalDscto;
            //calcular el total descuento
            totalDscto = tventa * 0.075;
            return totalDscto;
        }
        static public double FTCDscto(double tventa, double tDscto)
        {
            double totalDscto;
            totalDscto = tventa - tDscto;
            return totalDscto;
        }

        

    }
}
