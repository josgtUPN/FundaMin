using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace josue_granada_torres
{
    internal class Program
    {
        static void Main()
        {
            string tipo;
            int cant;

            tipo = tip();
            cant = ingcant();

            if (tipo == "2L")
            {
                calcuempaq(cant, 30, 15, 10, 6, "2L");
            }
            else
            {
                calcuempaq(cant, 50, 30, 20, 12, "0.5L");
            }

            Console.ReadKey();
        }

        static string tip()
        {
            string tipo = "";

            while (tipo != "2L" && tipo != "0.5L")
            {
                Console.Write("ingrese tipo de bebida (2L o 0.5L): ");
                tipo = Console.ReadLine();

                if (tipo != "2L" && tipo != "0.5L")
                {
                    Console.WriteLine("ERROR, ingrese '2L' o '0.5L'.");
                }
            }

            return tipo;
        }

        static int ingcant()
        {
            int cant = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write("ingrese cantidad (mínimo 550): ");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out cant))
                {
                    if (cant >= 550)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR,la cantidad debe ser mayor o igual a 550.");
                    }
                }
            }

            return cant;
        }

        static void calcuempaq(int cant, int grande, int mediana, int normal, int pack, string tipo)
        {
            int cajgran = 0, cajmed = 0, cajnor = 0, p = 0;
            int queda = cant;

            while (queda >= grande)
            {
                cajgran++;
                queda -= grande;
            }

            while (queda >= mediana)
            {
                cajmed++;
                queda -= mediana;
            }

            while (queda >= normal)
            {
                cajnor++;
                queda -= normal;
            }

            while (queda >= pack)
            {
                p++;
                queda -= pack;
            }


            bool packIncompleto = false;
            int ultPackBotellas = 0;

            if (queda > 0)
            {
                packIncompleto = true;
                ultPackBotellas = queda;
                p++; 
                queda = 0;
            }

            Console.WriteLine("\nEmpaque para bebida de " + tipo);
            Console.WriteLine("Caja Grande: " + cajgran);
            Console.WriteLine("Caja Mediana: " + cajmed);
            Console.WriteLine("Caja Normal: " + cajnor);
            Console.WriteLine("Pack: " + p);

            if (packIncompleto)
            {
                Console.WriteLine("El último pack tiene solo " + ultPackBotellas + " botellas.");
            }
        }
    }
}
