using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK12
{
    public static class Class1
    {
        public static void arreglo(ref int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                do
                {
                    Console.WriteLine("ingrese elementos " + (i + 1) + ": ");
                }
                while (!int.TryParse(Console.ReadLine(), out num[i]));
            }
        }
        public static void mostrar(int[] num)
        {
            for (int i = 0;i < num.Length; i++)
            {
                Console.Write("elemento " + (i + 1) + ": " + num[1]);
            }
        }
        public static int[] ordenar(int[] num)
        {
            int aux = 0;
            for (int i = 0; i <= num.Length; i++)
            {
                for(int j = i + 1; j < num.Length; j++)
                {
                    //orden de menor a amyor ascendente
                    if (num[i] > num[j])
                    {
                        aux = num[i];
                        num[i] = num[j];
                        num[j] = aux;

                    }
                }
            }
            return num;
        }
    }
}
