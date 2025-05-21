using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_semana9
{
    public class clase_no_estatica
    {
        public double soles_euros(double importe, double tc)
        {
            double res = 0;
            if (tc == 0)
            {
                res = 0;
            }
            else
            {
                res = importe / tc;

            }
            return res;
        }
        public double eurosoles(double importe, double tc)
        {
            double res = 0;
            if (tc == 0)
            {
                res = 0;
            }
            else
            {
                res = importe * tc;

            }
            return res;
        }
    }
}
