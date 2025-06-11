using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK12
{
    public static class ejercicio_2
    {
        public static void llenar
        public static void mostrar
        public static int[] ordenar
        public static string[] codl = new string[0];
        public static string[] noml = new string[0];
        public static int[] año = new int[0];
        public static void registrarl()
        {

            Array.Resize(ref codl,codl.Length+1);
            Array.Resize(ref noml, noml.Length+1);
            Array.Resize(ref año,año.Length+1);
            string aux = "";
            do
            {
                Console.Write("INGRESE CODIGO DEL LIBRO: ");
                aux = Console.ReadLine();
            }
            while (aux == "");
            codl[codl.Length - 1] = aux;
            do
            {
                Console.Write("INGRESE nombre DEL LIBRO: ");
                aux = Console.ReadLine();
            }
            while (aux == "");
            noml[noml.Length - 1] = aux;
            do
            {
                Console.Write("INGRESE año DEL LIBRO: ");
                aux = Console.ReadLine();
            }
            while (!int.TryParse(Console.ReadLine(), out año[año.Length - 1]));
            Console.WriteLine("libro registrado correctamente. ");
            Console.ReadKey();
            Console.Clear();
        }
        public static int buscar()
        {
            int indice = -1;
            string busq;
            Console.Write("ingrese codigo a buscar: ");
            busq = Console.ReadLine();
            for (int i = 0; i < busq.Length; i++)
            {
                if (codl[i].ToLower() == busq.ToLower())
                {
                    indice=i;
                    break;
                }
            }
            return indice;
        }
        public static void modificar()
        {
            int  indice;
            string aux = "";
            indice = ejercicio_2.buscar();
            if (indice < 0)
            {
                Console.WriteLine("codigo de libro no se ha encontrado");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                do
                {
                    Console.Write("ingrese nombre de libro: ");
                    aux = Console.ReadLine();
                }
                while (aux == "");
                noml[indice] = aux;
                do
                {
                    Console.Write("INGRESE AÑO DE PUBLICACION: ");
                }
                while (!int.TryParse(Console.ReadLine(), out año[indice]));
                Console.WriteLine("libro modificado correctamente.");
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}
