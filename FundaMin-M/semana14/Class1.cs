using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace semana14
{
    public static class Class1
    {
        public static void Mostrar_cadena_triangulo(string str)
        {
            string cad = " ";
            for (int i = 0; i <str.Length; i++)
            {
                cad += str[i];
                Console.WriteLine(cad);
            }
        }
        //variables generales
        public static string[] placa = new string[0];
        public static string[] marcas= new string[0];
        public static int[] años= new int[0];
        public static DateTime[] fecha = new DateTime[0];
        public static void Registrar()
        {
            Array.Resize(ref placa, placa.Length+1);
            Array.Resize(ref marcas, marcas.Length+1);
            Array.Resize(ref años, años.Length+1);
            Array.Resize(ref fecha, fecha.Length+1);
            do
            {
                Console.Write("ingrese placa de vehiculo: ");
                placa[placa.Length - 1] = Console.ReadLine();

            }
            while (placa[placa.Length - 1] = Console.ReadLine);
            do
            {
                    Console.Write()
            }


        }
        public static int buscar_vehiculo()
        {
            Console.rite("INGRESE LA PLACA")
        }

        
    }

}
