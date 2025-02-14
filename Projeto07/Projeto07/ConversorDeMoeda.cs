using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double Conversor(double cotacao, double dolares)
        {
            double total = dolares * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
