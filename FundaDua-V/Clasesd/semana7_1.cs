using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class semana7_1
    {
        static void Main(string[] args)
        {
   
            /*
            Escriba un programa para controlar las preferencias de 20 electores en una votación con respuestas SI, NO,
            BLANCO y NULO, y generar la siguiente salida de datos:
            */
            string espacio = " ";
            int Nroelector = 0;
            int opc;

            int fas_si=0;
            int fas_no=0;
            int fas_blanco=0;
            int fas_nulo=0;

            int fas_acum=0;
            int total_fa;

            double frs_si=0;
            double frs_no=0;
            double frs_blanco = 0;
            double frs_nulo = 0;

            double fr_acum=0;
            double total_fr;

            do
            {
                Nroelector++;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\tControl de votacion de electores");
                    Console.WriteLine("\t********************************");
                    Console.WriteLine("\tElector : " + Nroelector);
                    Console.WriteLine("\tElija Respuesta : ");
                    Console.WriteLine("\t1. SI");
                    Console.WriteLine("\t2. NO");
                    Console.WriteLine("\t3. BLANCO");
                    Console.WriteLine("\t4. NULO");
                    Console.Write("\tOpcion [1-4] : ");
                    opc = int.Parse(Console.ReadLine());
                    while (opc < 1 || opc > 4)
                    {
                        Console.WriteLine("\n\tOpcion no valida, vuelva a ingresar");
                        Console.Write("\tOpcion [1-4] : ");

                        opc = int.Parse(Console.ReadLine());
                    }
                } while (opc < 1 || opc > 4);
                switch (opc)
                {
                    case 1:
                        fas_si++;
                        break;
                    case 2:
                        fas_no++;
                        break;
                    case 3:
                        fas_blanco++;
                        break;
                    case 4:
                        fas_nulo++;
                        break;
                }
                frs_si = (frs_si / 20) * 100;
                frs_no = (frs_no / 20) * 100;
                frs_blanco = (frs_blanco / 20) * 100;
                frs_nulo = (frs_nulo / 20) * 100;

            } while (Nroelector < 20);

            total_fa = fas_si + fas_no + fas_blanco + fas_nulo;

            total_fr = frs_si + frs_no + frs_blanco + frs_nulo;


            Console.Write("\n");
            Console.WriteLine("{0:2}", "\tvalor");
            Console.WriteLine("{0:25}", "\tfrec. abs. simple");
            Console.WriteLine("{0:20}", "\tfrec. abs. acum");
            Console.WriteLine("{0:20}", "\tfrec. rel. simple");
            Console.WriteLine("{0:20}", "\tfrec. rel. acum");

            fas_acum += fas_si;
            fr_acum += frs_si;

            Console.WriteLine("{0}{2}", espacio.PadRight(7, ' '),"SI".PadLeft(7,' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_si.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_acum.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), frs_si.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            fas_acum += fas_no;
            fr_acum += frs_no;

            Console.WriteLine("{0}{2}", espacio.PadRight(7, ' '), "No".PadLeft(7, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_no.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_acum.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), frs_no.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            fas_acum += fas_blanco;
            fr_acum += frs_blanco;

            Console.WriteLine("{0}{2}", espacio.PadRight(7, ' '), "Blanco".PadLeft(7, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_blanco.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_acum.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), frs_blanco.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            fas_acum += fas_nulo;
            fr_acum += frs_nulo;

            Console.WriteLine("{0}{2}", espacio.PadRight(7, ' '), "Nulos".PadLeft(7, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_nulo.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fas_acum.ToString("N").PadLeft(14, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), frs_nulo.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), "total".PadLeft(7, ' ')); 
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), total_fa.ToString("N").PadLeft(30, ' '));
            Console.WriteLine("{0}{1}", espacio.PadRight(7, ' '), total_fr.ToString("N2").PadLeft(30, ' '));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            int i;
            Console.WriteLine("{0:2}", "\n\tGrafica de votos de los electores");
            Console.WriteLine("{0:2}", "\t*********************************");
            Console.Write("{0:2}", "\tValor");
            Console.Write("{0:2}", "BARRAS");
            Console.Write("{0:2}", "\n");

            Console.Write("{0:2}", "\tSi     ");

            for (i = 1; i <= fas_si + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_si.ToString("N2"));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            Console.Write("{0:2}", "\tNo     ");

            for (i = 1; i <= fas_no + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_no.ToString("N2"));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            Console.Write("{0:2}", "\tBlanco ");

            for (i = 1; i <= fas_blanco + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_blanco.ToString("N2"));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            Console.Write("{0:2}", "\tNulo   ");

            for (i = 1; i <= fas_nulo + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_nulo.ToString("N2"));
            Console.WriteLine("{0:2}", "%");
            Console.WriteLine("{0:2}", "\n");

            Console.ReadKey();






        }
    }
}
