using System;
using System.Text.RegularExpressions;


//Importar librerias
//Manejo de texto con PDF
//Acceso a la E/S datos para archivos

namespace AgenciaViajes
{
    internal class Program
    {
        //Definir constante para un maximo de 100 elementos en el arreglo
        const int MAX = 100;

        //Definir los arreglos para el programa de agencia
        static int[] numPasaje = new int[MAX]; //Arreglo para el numero de pasajes
        static int[] numAsiento = new int[MAX]; //Arreglo para el numero de asiento
        static string[] nombre = new string[MAX]; //Arreglo para el nombre del pasajero
        static int[] piso = new int[MAX]; //Arreglo para el piso
        static int[] mes = new int[MAX]; //Arreglo para el numero de mes
        static string[] origen = new string[MAX]; //Arreglo para el origen de la ruta
        static string[] destino = new string[MAX]; //Arreglo para el destino de la ruta
        static double[] precio = new double[MAX]; //Arreglo para el precio del pasaje
        static DateTime[] fechaEmision = new DateTime[MAX]; //Arreglo para la fecha de emision del boleto
        static DateTime[] fechaViaje = new DateTime[MAX]; //Arreglo para la fecha de viaje del boleto

        static double[] pesoequipaje = new double[MAX]; // ARREGLO PARA EL PESO DEL EQUIPAJE EN KG
        //DEFINIR UNA MATRIZ DE RUTAS
        static string[,] rutas = new string[,]
        {
            //ingresar datos de la matriz de rutas
            {"lima","Chiclayo","120.00" },
            {"lima","Piura","170.00"},
            {"lima","Trujillo","60.00"},
            {"lima","Ica","45.00"},
            {"lima","Arequipa","90.00"},
            {"lima","Tacna","110.00" },
            {"lima","Chiclayo","190.00" },
        };

        static int contador = 0;

        static void Main(string[] args)
        {
            //Definir la variable de opcion de menu
            int opcion;
            do
            {
                Console.Clear(); //Limpiar la consola
                //Definir el menu
                Console.WriteLine("\n--- Agencia Cruz del Sur ---");
                Console.WriteLine("1. Agregar Pasajero");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opcion : ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: AgregarPasajero(); break;
                }
                //Pausa
                Console.ReadKey();
            } while (opcion != 0);
        }
        //Metodo para agregar al pasajero
        static void AgregarPasajero()
        {
            //Validar el tamaño del ingreso en el arreglo
            if (contador >= MAX)
            {
                Console.WriteLine("No se pueden registrar mas pasajeros");
                return; //Salir
            }

            //Ingresar el numero de pasaje
            Console.Write("Numero de Pasaje (1-900) : ");
            int nPasaje = int.Parse(Console.ReadLine());

            //Validar el numero de pasaje
            if (nPasaje < 1 || nPasaje > 900 || ExistePasaje(nPasaje))
            {
                Console.WriteLine("Numero de Pasaje invalido o ya registrado...!");
                return; //Salir
            }

            Console.Write("Numero de Asiento (1-52) : ");
            int asiento = int.Parse(Console.ReadLine());
            //Validar el numero de asiento
            if (asiento < 1 || asiento > 52 || ExisteAsiento(asiento))
            {
                Console.WriteLine("Asiento invalido o ya ocupado...!");
                return;
            }

            Console.Write("Nombre del Pasajero : ");
            string nom = Console.ReadLine();

            

            //Origen y destino de la ruta
            Console.Write("Origen  : ");
            string ori = Console.ReadLine();
            Console.Write("Destino : ");
            string dest = Console.ReadLine();
            //ingresar el mes de viaje
            int m;
            //capturar el mes actual segun fecha del sistema
            int mesactual = DateTime.Now.Month;
            //VALIDAR el mes de viaje
           


        






            

        //Metodo para determinar si el pasaje ya fue vendido a otra persona
        static bool ExistePasaje(int n)
        {
            //Recorrer el arreglo de numero de pasajes
            for (int i = 0; i < contador; i++)
                if (numPasaje[i] == n)
                    return true; //El pasaje ya fue vendido
            return false; //El pasaje esta disponible
        }
        //Metodo para determinar la disponibilidad del asiento
        static bool ExisteAsiento(int a)
        {
            //Recorrer el arreglo de numeros de asientos
            for (int i = 0; i < contador; i++)
                if (numAsiento[i] == a)
                    return true; //El asiento no esta disponible
            return false; //El asiento esta disponible
        }
        //metodo para validar el nombre del pasajero
        static bool esnombrevalido(string nombre)
        {
            //retonar el patron de caracteres
            return Regex.IsMatch(nombre, @"^[A-Za-záéíóúÁÉÍÓÚÑñÜü\s]+$");

        }

    }

}
