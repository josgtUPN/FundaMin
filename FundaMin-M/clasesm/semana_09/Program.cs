using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1_semana9;

namespace semana_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            double imp = 0, tc = 0, resultado = 0;
            clase_no_estatica cne = new clase_no_estatica();
            while (variables_globales.tcc_dolares==0)
            {
                do
                {
                    Console.WriteLine("ingrese t/c compra dolares: ");
                }while(!double.TryParse(Console.ReadLine(), out variables_globales.tcc_dolares));
            }
            while(variables_globales.tcv_dolares == 0)
            {
                do
                {
                    Console.WriteLine("ingrese t/c venta dolares: ");
                } while (!double.TryParse(Console.ReadLine(), out variables_globales.tcv_dolares));
            }
            while (variables_globales.tcc_euros==0)
            {
                do
                {
                    Console.WriteLine("ingrese t/c compra euros: ");
                } while (!double.TryParse(Console.ReadLine(), out variables_globales.tcc_euros));
            }
            while (variables_globales.tcv_euros == 0)
            {
                do
                {
                    Console.WriteLine("ingrese t/c venta euros: ");
                } while (!double.TryParse(Console.ReadLine(), out variables_globales.tcv_euros));
            }

            do
            {
                clase_estatica.menu(ref op);
                switch (op)
                {
                    case "1":
                        do
                        {
                            Console.Write("ingrese importe: ");

                        }
                        while (!double.TryParse(Console.ReadLine(), out imp));
                        //do
                        //{
                        //    Console.Write("ingrese tipo de cambio: ");
                        //}
                        //while (!double.TryParse(Console.ReadLine(), out tc));
                        clase_estatica.soles_dolares(imp, tc, ref resultado);
                        Console.WriteLine("el improte convertido es: "+ resultado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        do
                        {
                            Console.Write("ingrese importe: ");

                        }
                        while (!double.TryParse(Console.ReadLine(), out imp));
                        //do
                        //{
                        //    Console.Write("ingrese tipo de cambio: ");
                        //}
                        //while (!double.TryParse(Console.ReadLine(), out tc));
                        clase_estatica.dolares_soles(imp, tc, ref resultado);
                        Console.WriteLine("el improte convertido es: " + resultado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        do
                        {
                            Console.Write("ingrese importe: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out imp));
                        //do
                        //{
                        //    Console.Write("ingrese el tipo de cambio: ");
                        //}
                        //while (!double.TryParse(Console.ReadLine(),out tc));
                        Console.Write("el importe convertido es: " + cne.soles_euros(imp, tc));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        do
                        {
                            Console.Write("ingrese importe: ");
                        }
                        while (!double.TryParse(Console.ReadLine(), out imp));
                        //do
                        //{
                        //    Console.Write("ingrese el tipo de cambio: ");
                        //}
                        //while (!double.TryParse(Console.ReadLine(), out tc));
                        Console.Write("el importe convertido es: " + cne.eurosoles(imp, tc));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        Console.Clear();
                        break;
                }


            }
            while (op != "5"); 
        }
    }
}
