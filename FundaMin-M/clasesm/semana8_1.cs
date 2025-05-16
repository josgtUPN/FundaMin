using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Semana8_1
    {// JP-LFAL-Sem08 Ejercicios con Funciones.pdf_ ejercicio 03
        public static void mensaje(string msle)
        {
            Console.Write(msle);
        }
        public static void mensajerpta(string msle, double rpta)
        {
            Console.Write(msle);
            Console.Write(rpta);
            Console.Write("\n");
        }
        public static int fppuntualidad(int mt)
        {
            int pptosPuntualidad;
            switch (mt)
            {
                case 0: 
                    pptosPuntualidad = 10; break;
                case 1:
                case 2: 
                    pptosPuntualidad = 8; break;
                case 3:
                case 4:
                case 5: 
                    pptosPuntualidad = 6; break;
                case 6:
                case 7:
                case 8:
                case 9: 
                    pptosPuntualidad = 4; break;
                default:
                    pptosPuntualidad = 0;
                    break;
            }
            return pptosPuntualidad;
        }
        public static int fpdmto(int nobs)
        {
            int pptosrdmto;
            switch (nobs)
            {
                case 0: pptosrdmto = 10; break;
                case 1: pptosrdmto = 8; break;
                case 2: pptosrdmto = 5; break;
                case 3: pptosrdmto = 1; break;
                default:
                    pptosrdmto = 0;
                    break;

            }
            return pptosrdmto;
        }
        public static void ingreso(ref int tard, ref int nobs)
        {
            int resultado;
            resultado= 0;
            while (resultado == 0)
            {
                mensaje("minutos de tardanza > 0 : ");
                tard = int.Parse(Console.ReadLine());
                resultado = validartardanza(tard);
                if (resultado == 0)
                    mensaje("tardanza incorrecta..intente de nuevo...!\n");

            }
            resultado = 0;
            while(resultado == 0)
            {
                mensaje("numero de onservaciones: ");
                nobs = int.Parse(Console.ReadLine());
                resultado = validarrobs(nobs);
                if (resultado == 0)
                    mensaje("numero de observaciones incorrectas.. intente de nuevo");
            }

        }
        public static int validartardanza(int mintard)
        {
            int rpta;
            if (mintard >= 0)
            {
                rpta = 1;
            }
            else
            {
                rpta = 0;

            }
            return rpta;

        }
        public static int validarrobs(int nobs)
        {
            int rpta;
            if (nobs >= 0) 
            {
                rpta = 1;
            
            }
            else
            {
                rpta = 0;
            }
            return rpta;
               
        }
        public static double fboni(int pt)
        {
            double bonif;
            switch (pt)
            {
                case 11:
                case 12:
                case 13:
                    bonif =5*pt;
                    break;
                case 14: case 15:
                case 16:
                    bonif = 7.5*pt;
                    break;
                case 17: case 18:
                case 19:
                    bonif = 10 *pt;
                    break;
                case 20:
                    bonif = 12.5 * pt;
                    break;
                default:
                    bonif = 2.5 * pt ;
                    break;
            }
            return bonif;
        }
        public static int fpuntajet(int ppp, int ppr)
        {
            int pt;
            pt = ppp + ppr;
            return pt;
        }
        static void Main(string[] args)
        {
            int mintard = 0;
            int nobs = 0;   
            int ptospp = 0;
            int ptospr;
            int ptotal;
            double tbonif;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("evaluacion de empelados");
            Console.WriteLine("***********************");
            ingreso(ref mintard, ref nobs);
            ptospp = fppuntualidad(mintard);
            ptospr = fpdmto(nobs);
            ptotal = fpuntajet(ptospp, ptospr);
            tbonif = fboni(ptotal);
            mensajerpta("puntaje por puntualidad: ", ptospr);
            mensajerpta("puntaje por rendimiento : ", ptospr);
            mensajerpta("puntaje total: ", ptotal);
            mensajerpta("bonificacion: ", tbonif);
            Console.ReadKey();

        }
    }
}
