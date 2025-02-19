using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto20
{
    internal class Calculator
    {
        public static void Triple(int origin, out int result) // fazendo isso, ao inves do resultado ser guardado no (a), vai ser guardado
        {                                                     // no (triple)
            result = origin * 3;
        }
    }
}
