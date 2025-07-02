using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca_15
{
    public class Class1
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
            public static string[,] llenar_pedido()
            {
                int filas;
                double precio;
                int cantidad;
                string[,] pedido;
                do
                {
                    Console.Write("Ingrese número de productos: ");
                }
                while (!int.TryParse(Console.ReadLine(), out filas));
                pedido = new string[filas, 3];
                for (int i = 0; i < pedido.GetLength(0); i++)
                {
                    Console.Write("Ingrese el nombre del producto " + (i + 1) + ": ");
                    pedido[i, 0] = Console.ReadLine();
                    do
                    {
                        Console.Write("Ingrese el precio del producto " + (i + 1) + ": ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out precio));
                    pedido[i, 1] = precio.ToString();
                    do
                    {
                        Console.Write("Ingrese la cantidad del producto " + (i + 1) + ": ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out cantidad));
                    pedido[i, 2] = cantidad.ToString();
                }
                return pedido;
            }
            public static void Imprimir_Pedido(string[,] pedido)
            {
                string cad = "";
                int cantidad;
                double precio;
                double total = 0;
                Console.WriteLine("PRODUCTO".PadRight(15, ' ') + "PRECIO".PadLeft(10, ' ') + "CANTIDAD".PadLeft(10, ' ') + "SUBTOTAL".PadLeft(10, ' '));
                Console.WriteLine("".PadRight(45, '-'));
                for (int i = 0; i < pedido.GetLength(0); i++)
                {
                    cantidad = int.Parse(pedido[i, 2]);
                    precio = double.Parse(pedido[i, 1]);
                    total += precio * cantidad;
                    cad += pedido[i, 0].PadRight(15, ' ') + precio.ToString().PadLeft(10, ' ') + cantidad.ToString().PadLeft(10, ' ') + (precio * cantidad).ToString().PadLeft(10, ' ') + "\n";
                    Console.WriteLine(cad);
                    cad = " ";
                }
                Console.WriteLine("-".PadRight(45, '-'));
                Console.WriteLine("TOTAL".PadRight(35, ' ') + total.ToString("c").PadLeft(10, ' '));
                Console.ReadKey();  
            }
            public static int[,] Llenar_Matriz(int f, int c)
            {
                int[,] M = new int[f, c];
                for (int i = 0; i < f; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        do
                        {
                            Console.Write("Ingrese elemento [" + (i + 1) + "," + (j + 1) + "]: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out M[i, j]));
                    }
                }
                return M;
            }
            public static int[,] Suma_matrices(int[,] A, int[,] B)
            {
                int[,] R = new int[A.GetLength(0), A.GetLength(1)];
                for (int i = 0; i< A.GetLength(1); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        R[i, j] = A[i, j] + B[i, j];
                    }
                }
                return R;
            }
            public static void REST_matrices(int[,] A, int[,] B,)
            {
                for (int i = 0; i < A.GetLength(1); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        R[i, j] = A[i, j] - B[i, j];
                    }
                }
                return R;
            }


        }
    }
}
