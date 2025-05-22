using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    class semana8_ejercicio6
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            saludar(nombre, apellido);
            Console.ReadLine();

        }
        public static void saludar(string nombre, string apellido)
        { 
            Console.WriteLine("hola {0}___{1}.", nombre, apellido);
            Console.WriteLine("¡hola" + nombre + "!");
        }
    }
}
