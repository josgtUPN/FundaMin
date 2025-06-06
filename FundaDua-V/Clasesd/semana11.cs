using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar libreria
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace semana11

{
    
    internal class semana11
    {
        //definir constantE pata una maximo de 100 elementos en el arreglo
        const int max = 100;
        //definir los arreglos para el programa de agencia
        static int[] numpasaje = new int[max];//arreglo para pasajeros
        static int[] numasiento = new int[max];//arreglo parar asientos
        static string[] nombre = new string[max];//arreglo para nombres
        static int[] piso = new int[max];//arreglo para piso
        static int[] mes = new int[max];//arreglo para el mes
        static string[] origen = new string[max];//arreglo para el origen de la ruta
        static string[] destino = new string[max];//arreglo para la ruta
        static double[] precio = new double[max];//arreglo parar el precio
        static DateTime[] fechaemision =new DateTime[max];//arreglo de fecha emision
        static DateTime[] fechaviaje = new DateTime[max];//arrelgo para fecha viaje
        static int contador = 0;
        static void Main(string[] args)
        {
            //definir la variable de opcion de menu
            int opcion;
            do
            {
                Console.Clear();//limpiar consola
                //definir menu
                Console.WriteLine("\n--- Agencia Cruz del Sur ---");
                Console.WriteLine("1.agregar pasajero");
                Console.WriteLine("0. Salir");
                Console.Write("seleccione una opcion : ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1 : AgregarPasajero();break;
                }
                //pausa
                Console.ReadKey();
            }while (opcion != 0);
        }
        static void AgregarPasajero()
        {
            //validar el tamaño del ingreso en el arreglo
            if(contador >= max)
            {
                Console.WriteLine("nose puede registra mas psasjeros");
                return;
            
            }
            //ingrese numero de pasajeros
            Console.Write("Número de pasaje (1-900): ");
            int nPasaje = int.Parse(Console.ReadLine());
            if (nPasaje < 1 || nPasaje > 900 || ExistePasaje(nPasaje))
            {
                Console.WriteLine("Número de pasaje inválido o ya registrado.");
                return;
            }

            Console.Write("Número de asiento (1-52): ");
            int asiento = int.Parse(Console.ReadLine());
            if (asiento < 1 || asiento > 52 || ExisteAsiento(asiento))
            {
                Console.WriteLine("Asiento inválido o ya ocupado.");
                return;
            }

            Console.Write("Nombre del pasajero: ");
            string nom = Console.ReadLine();
            Console.Write("mes de viaje (1-12): ");
            int m = int.Parse(Console.ReadLine());
            //validar el mes de viaje
            if (m < 1 || m > 12)
            {
                Console.WriteLine("MES INVALIDO::!");
                return;
            }
            //ORIGEN Y DESTINO DE LA RUTA
            Console.Write("origen : ");
            string ori = Console.ReadLine();
            Console.Write("destino: ");
            string dest= Console.ReadLine();
            //calcular el precio del pasaje segun la ruta
            double pre = CalcularPrecio(ori, dest);
            if (pre == -1)
            {
                Console.WriteLine("Ruta inválida.");
                return;
            }

        }
        //metodo para determinar si el pasaje ya fue vendido a otra persona
        static bool ExistePasaje(int n)
        {
            for (int i = 0; i < contador; i++)
                if (numpasaje[i] == n)
                    return true;
            return false;
        }
        static bool ExisteAsiento(int a)
        {
            //recorrer el arreglo de numeros de asientos
            for(int i = 0;i < contador;i++)
                if (numasiento[i]==a)
                    return true;
            return false;
        }
        //metodo para calcular el precio del pasaje segun la ruta
        static double CalcularPrecio(string ori, string dest)
        {
            //definir ruta
            string ruta = ori.ToLower()+"-"+dest.ToLower();
            if (ruta == "lima-chiclayo" || ruta == "chiclayo-lima") return 120.00;
            else if (ruta == "lima-piura" || ruta == "piura-lima") return 170.00;
            else if (ruta == "lima-trujillo" || ruta == "trujillo-lima") return 60.00;
            else if (ruta == "lima-ica" || ruta == "ica-lima") return 45.00;
            else if (ruta == "lima-arequipa" || ruta == "arequipa-lima") return 90.00;
            else if (ruta == "lima-tacna" || ruta == "tacna-lima") return 110.00;
            else if (ruta == "lima-tumbes" || ruta == "tumbes-lima") return 190.00;
            else return -1;
        }
    }
}
