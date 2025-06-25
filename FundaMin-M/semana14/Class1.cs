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
        public static void Mostrar_Cadena_Triangulo(string str)
        {
            string cad = "";
            for (int i = 0; i < str.Length; i++)
            {
                cad += str[i];
                Console.WriteLine(cad);
            }
        }
        //variables generales
        public static string[] placa = new string[0];
        public static string[] marca = new string[0];
        public static int[] año = new int[0];
        public static DateTime[] fecha = new DateTime[0];
        public static void Registrar()
        {
            //Rendimientos tamaño de arreglo
            Array.Resize(ref placa, placa.Length + 1);
            Array.Resize(ref marca, marca.Length + 1);
            Array.Resize(ref año, año.Length + 1);
            Array.Resize(ref fecha, fecha.Length + 1);
            do
            {
                Console.WriteLine("Ingrese placa de vehiculo: ");
                placa[placa.Length - 1] = Console.ReadLine();
            }
            while (placa[placa.Length - 1] == "");
            do
            {
                Console.WriteLine("Ingrese marca de vehiculo: ");
                marca[marca.Length - 1] = Console.ReadLine();
            }
            while (marca[marca.Length - 1] == "");
            do
            {
                Console.WriteLine("INgrese año del vehiculo: ");
            }
            while (!int.TryParse(Console.ReadLine(), out año[año.Length - 1]));
            do
            {
                Console.WriteLine("Ingrese fecha de inscripcion: ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out fecha[fecha.Length - 1]));
            Console.WriteLine("REgistro realizado satisfactoriamente......");
            Console.ReadKey();
            Console.Clear();
        }
        public static int Buscar_vehiculo()
        {
            string busq = "";
            int indice = -1;
            Console.WriteLine("INgrese la placa del vehiculo: ");
            busq = Console.ReadLine();
            if (busq != "")
            {
                for (int i = 0; i < placa.Length; i++)
                {
                    if (placa[i] == busq)
                    {
                        indice = i;
                        break;
                    }
                }
                //Indice = array.IndexOf(placa, busq);
            }
            else
            {
                Console.WriteLine("NO se ingreso valor a buscar ....");
                Console.ReadKey();
                Console.Clear();
            }
            return indice;
        }
        public static void Modificar()
        {
            int ind = Buscar_vehiculo();
            if (ind >= 0)
            {
                do
                {
                    Console.WriteLine("Ingrese maracde vehuculo: ");
                    marca[ind] = Console.ReadLine();
                }
                while (marca[ind] == "");
                do
                {
                    Console.WriteLine("INgrese año del vehiculo: ");
                }
                while (!int.TryParse(Console.ReadLine(), out año[ind]));
                do
                {
                    Console.Write("Ingrese fecha de inscripcion: ");
                }
                while (!DateTime.TryParse(Console.ReadLine(), out fecha[ind]));
                Console.WriteLine("MOdificacion modificada satisfactoriamente....");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("placa de vahiculo no encontrado ");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void Eliminar()
        {
            int ind = Buscar_vehiculo();
            if (ind >= 0)
            {
                placa = placa.Where(x => x != placa[ind]).ToArray();
                marca = marca.Where(x => x != marca[ind]).ToArray();
                año = año.Where(x => x != año[ind]).ToArray();
                fecha = fecha.Where(x => x != fecha[ind]).ToArray();
                Console.WriteLine("Vehiculo eliminado satisfactoriamente....");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Codigo de placa no encotrado....");
                Console.ReadKey();
                Console.Clear();
            }

        }



    }

}
