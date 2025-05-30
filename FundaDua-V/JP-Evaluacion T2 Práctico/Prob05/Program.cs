using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using calularenta;



class Program
{
    static void Main()
    {
        //pedimos los datos como la renta aumeto total de departamentos y desocupados
        Console.Write("ingresar la renta mensual por departamento: ");
        double rentamen = double.Parse(Console.ReadLine());
        Console.Write("ingresar el monto de aumento: ");
        double aumento = double.Parse(Console.ReadLine());
        Console.Write("ingresar el total de departamentos: ");
        int totalDeptos = int.Parse(Console.ReadLine());
        Console.Write("ingresar el número de departamentos desocupados: ");
        int desocupados = int.Parse(Console.ReadLine());

        //llamamo a la biblioteca 
        var simulador = new simuladorrenta();
        double max, min, promedio;
        int conteo;
        List<resultadosimulacion> resultados = simulador.realizarsimulacionycálculos(
            rentamen, aumento, totalDeptos, desocupados,
            out max, out min, out conteo, out promedio
        );
        //limpiamos la consola
        Console.Clear();
        //mostramos los resultados 
        Console.WriteLine("\nCOMPAÑIA DE BIENES RAICES");
        Console.WriteLine("\nrenta mensual : {0} ", rentamen);
        Console.WriteLine("aumento de renta : {0} ", aumento);
        Console.WriteLine("total de departamentos : {0} ", totalDeptos);
        Console.WriteLine("renta total mensual : {0} ", desocupados);
        Console.WriteLine($"máxima renta total mensual: {max:C}");
        Console.WriteLine($"mínima renta total mensual: {min:C}");
        Console.WriteLine($"escenarios con renta >700 y <=1000: {conteo}");
        Console.WriteLine($"promedio de renta por dpto >1000: {(promedio > 0 ? promedio.ToString("C") : "no hay casos")}");

        Console.WriteLine("Incremento | Renta Total | Renta/Depto | Desocupados |");
        foreach (var r in resultados)
        {
            //mostramos la tabla
            Console.WriteLine($"| {r.Incremento,10} | {r.RentaTotal,11:C} | {r.RentaPorDepto,8} | {r.Desocupados,11} |");
        }
        Console.ReadKey();
    }
}