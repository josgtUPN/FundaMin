using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana15
{
    public static class semana15_1
    {
        public static string[,] LLENAR_ALUMNOS()
        {
            string[,] alumnos = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("ingrese " + ((j == 0) ? "nombre" : "apellido") + " del alumno " + (i + 1) + ":"); alumnos[i, j] = Console.ReadLine();

                }
            }
            return alumnos;
        }
        public static void imprimir_alumnos(string[,] alumnos)
        {
            for (int i = 0; i < 5; i++)
            {
                string cad = " ";
                for (int j = 0; j < 2; j++)
                {
                    cad += alumnos[i, j] + "\t";
                }
                Console.Write(cad);
            }
        }
    }
}
