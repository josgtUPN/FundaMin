using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class ejemplo
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántas casas vas a ingresar?: ");
            int cantidadCasas = int.Parse(Console.ReadLine());

            double totalAgua = 0, totalAlcantarillado = 0, totalCargoFijo = 0, totalIGV = 0, totalPago = 0;

            for (int i = 0; i < cantidadCasas; i++)
            {
                Console.WriteLine($"\n--- Casa {i + 1} ---");
                Console.Write("Lectura anterior: ");
                int lecturaAnterior = int.Parse(Console.ReadLine());

                Console.Write("Lectura actual: ");
                int lecturaActual = int.Parse(Console.ReadLine());

                int metrosCubicos = lecturaActual - lecturaAnterior;

                double importeAgua = 0;
                double importeAlcantarillado = 0;

                // Agua
                int m = metrosCubicos;
                if (m > 50)
                {
                    importeAgua += 20 * 1.499;
                    importeAgua += 30 * 2.128;
                    importeAgua += (m - 50) * 5.438;
                }
                else if (m > 20)
                {
                    importeAgua += 20 * 1.499;
                    importeAgua += (m - 20) * 2.128;
                }
                else
                {
                    importeAgua += m * 1.499;
                }

                // Alcantarillado
                m = metrosCubicos;
                if (m > 50)
                {
                    importeAlcantarillado += 20 * 0.935;
                    importeAlcantarillado += 30 * 1.309;
                    importeAlcantarillado += (m - 50) * 2.592;
                }
                else if (m > 20)
                {
                    importeAlcantarillado += 20 * 0.935;
                    importeAlcantarillado += (m - 20) * 1.309;
                }
                else
                {
                    importeAlcantarillado += m * 0.935;
                }

                // Cargo fijo
                double cargoFijo = 5.04 * (metrosCubicos / 25.0);

                // IGV
                double subtotal = importeAgua + importeAlcantarillado + cargoFijo;
                double igv = subtotal * 0.18;

                // Total
                double total = subtotal + igv;

                // Mostrar
                Console.WriteLine($"Metros cúbicos: {metrosCubicos}");
                Console.WriteLine($"Importe Agua: S/ {importeAgua:F2}");
                Console.WriteLine($"Importe Alcantarillado: S/ {importeAlcantarillado:F2}");
                Console.WriteLine($"Cargo Fijo: S/ {cargoFijo:F2}");
                Console.WriteLine($"IGV (18%): S/ {igv:F2}");
                Console.WriteLine($"Total a pagar: S/ {total:F2}");

                // Acumuladores
                totalAgua += importeAgua;
                totalAlcantarillado += importeAlcantarillado;
                totalCargoFijo += cargoFijo;
                totalIGV += igv;
                totalPago += total;
            }

            Console.WriteLine("\n--- TOTALES GENERALES ---");
            Console.WriteLine($"Total Agua: S/ {totalAgua:F2}");
            Console.WriteLine($"Total Alcantarillado: S/ {totalAlcantarillado:F2}");
            Console.WriteLine($"Total Cargo Fijo: S/ {totalCargoFijo:F2}");
            Console.WriteLine($"Total IGV: S/ {totalIGV:F2}");
            Console.WriteLine($"Total Pago: S/ {totalPago:F2}");
        }


    }
}
