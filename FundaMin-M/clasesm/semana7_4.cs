using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class semana7_4
    {
        static void Main(string[] args)
        {
            int cont = 0;
            string op = " ";
            string cadena = " ";
            do
            {
                Console.WriteLine("******MENU******");
                Console.WriteLine("1) cantidad de vocales");
                Console.WriteLine("2) cantidad de consonantes");
                Console.WriteLine("3) cantidad de positivos");
                Console.WriteLine("4) cantidad de ceros");
                Console.WriteLine("5) cantidad de especiales");
                Console.WriteLine("6) Salir");
                Console.WriteLine("ingrese una opcion: ");
                op = Console.ReadLine();
                if (op != "6")
                {
                    Console.WriteLine("ingrese cadena a aevaluar: ");
                    cadena = Console.ReadLine();
                }
                cont = 0;
                switch (op)
                {
                    case "1":
                        for (int i = 0; i < cadena.Length; i++)
                        {
                            string c = cadena.Substring(i, 1);
                            if (c == "a" || c == "e" || c == "o" || c == "i" || c == "u") ;
                            {
                                cont++;
                            }

                        }
                        Console.WriteLine("la cantidad de vocales es: " + cont);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        for (int i = 0; i < cadena.Length; i++)
                        {
                            char c = char.Parse(cadena.Substring(i, 1));
                            if (char.IsLetter(c));
                            {
                                if (c != 'a' && c != 'e' && c != 'o' && c != 'i' && c != 'u')
                                {
                                    cont++;
                                }
                                
                            }

                        }
                        Console.WriteLine("la cantidad de consonante es: " + cont);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        for (int i = 0; i < cadena.Length; i++)
                        {
                            char c = char.Parse(cadena.Substring(i, 1));
                            if (char.IsDigit(c))
                            {
                                if (int.Parse(c.ToString())>0)
                                {
                                    cont++;
                                }
                            }
                        }
                        Console.WriteLine("la cantidad de numeros positivos es: "+cont);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        for (int i = 0; i < cadena.Length; i++) ;
                        {
                            char c = char.Parse(cadena.Substring(i, 1));
                            if (char.IsDigit(c))
                            {
                                if (int.Parse(c.ToString()) = 0)
                                {
                                    cont++;
                                }

                            }
                               
                        }
                        Console.WriteLine("la cantidad de numeros positivos es: " + cont);
                        Console.ReadKey();
                        Console.Clear();
                        break;




                }





            }
            while (true);

        }
    }
}
