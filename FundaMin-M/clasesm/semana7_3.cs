using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana7_3
    {
        static void Main(string[] args)
        {
            /*Cree un algoritmo que permita el ingreso de un cliente y su categoría(A o B).
             Y pregunte si desea continuar con el ingreso. Además, al finalizar los
             ingresos, el algoritmo deberá mostrar el total de clientes, el número de
             clientes de cada categoría y su respetivo porcentaje.*/
            string nom;
            double total;
            double conA=0, conB=0;
            double PA, PB;
            string resp = " ";
            string cat;
            do
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("ingrese nombre: ");
                nom = Console.ReadLine();
                do
                {
                    Console.WriteLine("INGRESE CATEGORIA (A O B): ");
                    cat = Console.ReadLine();
                }
                while (cat.ToUpper() != "A" && cat.ToLower() != "b");
                switch(cat.ToUpper())
                {
                    //OTRA FORMA
                    //canA += (cat.ToLower() == "a") ?, 1 : 0;
                    //canB += (cat.ToUpper() == "B") ?, 1 : 0;
                    case "A":
                        conA = conA + 1;
                        break;
                    case "B":
                        conB = conB + 1;
                        break;
                }
                Console.Write("desea continuar? (si=s y no =n): ");
                resp = Console.ReadLine();
            }
            while (resp.ToLower() == "s");
            PA = conA / (conA + conB) * 100.0;
            PB = conB / (conB + conA)*100.0;
            Console.WriteLine("la cantidad total de clientes es: " + (conA + conB));
            Console.WriteLine("cantidad de clientes de A: " + conA);
            Console.WriteLine("cantidad de clientes de B: " + conB);
            Console.WriteLine("porcentaje de clientes de A: " + PA);
            Console.WriteLine("porcentaje de clienets de B: " + PB);
            Console.ReadKey();





        }
    }
}
