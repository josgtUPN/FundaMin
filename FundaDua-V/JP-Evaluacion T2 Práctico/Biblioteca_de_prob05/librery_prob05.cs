using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_de_prob05;

namespace calularenta
{
    //almacenamos los resultados 
    public class resultadosimulacion
    {
        public int Incremento { get; set; }
        public double RentaPorDepto { get; set; }
        public int DptosRentados { get; set; }
        public int Desocupados { get; set; }
        public int TotalDeptos { get; set; }
        public double RentaTotal { get; set; }
    }
    //simulamos las rentas 
    public class simuladorrenta
    {
        public List<resultadosimulacion> realizarsimulacionycálculos(
            //declaramos variables
            double rentamen, double aumento, int totalDeptos, int desocupados,
            out double maxRentaTotal, out double minRentaTotal,
            out int conteoEntre701y1000, out double promedioMayorA1000)
        {
            List<resultadosimulacion> resultados = new List<resultadosimulacion>();
            maxRentaTotal = double.MinValue;
            minRentaTotal = double.MaxValue;
            conteoEntre701y1000 = 0;
            double sumaMayorA1000 = 0;
            int conteoMayorA1000 = 0;
            //usamos el for para repertir hasat que no halla departamentos rentados
            for (int n = 1; ; n++)
            {
                //calculamos los departamentos
                int dptosRentados = totalDeptos - (desocupados * n);
                if (dptosRentados <= 0) break;
                double rentaPorDepto = rentamen + (aumento * n);
                double rentaTotal = rentaPorDepto * dptosRentados;
                //calculamos los depas que son mayores a 1000
                if (rentaTotal > maxRentaTotal) maxRentaTotal = rentaTotal;
                if (rentaTotal < minRentaTotal) minRentaTotal = rentaTotal;
                //calculamos los depas con rentas desde 700 hasta 1000
                if (rentaPorDepto > 700 && rentaPorDepto <= 1000)
                    conteoEntre701y1000++;
                //calculamos los depas que son mayores a 1000
                if (rentaPorDepto > 1000)
                {
                    sumaMayorA1000 += rentaPorDepto;
                    conteoMayorA1000++;
                }
                //guardamos los resultados en una lista
                resultados.Add(new resultadosimulacion
                {
                    Incremento = n,
                    RentaPorDepto = rentaPorDepto,
                    DptosRentados = dptosRentados,
                    Desocupados = desocupados * n,
                    TotalDeptos = totalDeptos,
                    RentaTotal = rentaTotal
                });
            }
            //calculamos el promedio de los depas mayores a 1000
            promedioMayorA1000 = conteoMayorA1000 > 0 ? sumaMayorA1000 / conteoMayorA1000 : 0;
            return resultados;
        }
    }
}